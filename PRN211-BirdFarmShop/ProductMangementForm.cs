﻿using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class ProductMangementForm : Form
    {
        private static string _imageFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
        private static string _birdImage = string.Empty;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IConfiguration _config;
        private readonly AppSettings _appSetting;

        public ProductMangementForm()
        {
            InitializeComponent();

            // services
            _productService = new ProductService();
            _categoryService = new CategoryService();

            // config appsettings
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            // monitor appsettings
            _appSetting = BFShopUtils.ConfigureAppSettings();
        }


        /// <summary>
        /// Get all form controls
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }

        /// <summary>
        /// Change data grid view cells Font
        /// </summary>
        void UpdateFont()
        {
            var colIndex = 0;
            //Change cell font
            foreach (DataGridViewColumn c in dgv_Product.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 18F, GraphicsUnit.Pixel);
                // header font custom
                dgv_Product.Columns[colIndex].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

                // increase column index 
                ++colIndex;
            }
        }

        /// <summary>
        /// Styling form
        /// </summary>
        void StyleDatagridview()
        {

            dgv_Product.BorderStyle = BorderStyle.None;
            dgv_Product.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Product.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Product.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgv_Product.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgv_Category.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgv_Product.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dgv_Product.EnableHeadersVisualStyles = false;
            dgv_Product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Product.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dgv_Product.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 122, 219);
            dgv_Product.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        /// <summary>
        /// resize form when shrink
        /// </summary>
        void ResizeForm()
        {
            // no smaller than design time size
            //this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            //this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, 0);

            // get all form elements
            var controls = GetAllControls(this).OfType<Control>();
            // resize form element  
            foreach (var control in controls)
            {
                Resize_Control(control, new Rectangle(control.Location, control.Size));
            }

            Resize_Control(btn_Add, new Rectangle(btn_Add.Location, btn_Add.Size));

            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Resize form controls
        /// </summary>
        /// <param name="c"></param>
        /// <param name="r"></param>
        void Resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(this.Size.Width);
            float yRatio = (float)(this.Height) / (float)(this.Size.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        /// <summary>
        /// Data Grid View column with
        /// </summary>
        void CustomDataGridViewColumn()
        {
        }

        void CustomDataGridViewHeader()
        {
            // update to dgv datasource
            dgv_Product.Columns["ProductId"].HeaderText = "Mã hàng hóa";
            dgv_Product.Columns["ProductName"].HeaderText = "Tên hàng hóa";
            dgv_Product.Columns["Age"].HeaderText = "Tuổi";
            dgv_Product.Columns["Color"].HeaderText = "Màu lông";
            dgv_Product.Columns["Gender"].HeaderText = "Giới tính";
            dgv_Product.Columns["QuantityAvailable"].HeaderText = "Số lượng tồn kho";
            dgv_Product.Columns["QuantitySold"].HeaderText = "Số lượng đã bán";
            dgv_Product.Columns["CategoryName"].HeaderText = "Loại chim";
            dgv_Product.Columns["DateCreated"].HeaderText = "Ngày nhập";
            dgv_Product.Columns["Price"].HeaderText = "Giá bán";
            dgv_Product.Columns["Characteristics"].HeaderText = "Đặc trưng";
            dgv_Product.Columns["Status"].HeaderText = "Trạng thái";
            dgv_Product.Columns["Detail"].HeaderText = "Mô tả";
            dgv_Product.Columns["Discount"].HeaderText = "Giảm giá";

            for (int i = 0; i <= 10; ++i)
            {
                dgv_Product.Columns[i].Width = 100;
            }

        }

        private void DefaultTextBox()
        {
            tb_ProductId.Text = string.Empty;
            tb_ProductName.Text = string.Empty;
            tb_AvailableQuantity.Text = string.Empty;
            tb_SoldQuantity.Text = string.Empty;
            dtp_CreateDate.Value = DateTime.Now;
            tb_Price.Text = string.Empty;
            tb_Chacteristic.Text = string.Empty;
            tb_Detail.Text = string.Empty;
            _birdImage = string.Empty;
            pic_Camera.Show();
            pic_Avatar.Image = null!;

            // default combobox
            if (cb_Category.Items.Count > 0)
            {
                cb_Category.SelectedIndex = 0;
            }
            if (cb_Color.Items.Count > 0)
            {
                cb_Color.SelectedIndex = 0;
            }
            if (cb_Gender.Items.Count > 0)
            {
                cb_Gender.SelectedIndex = 0;
            }
            if (cb_Age.Items.Count > 0)
            {
                cb_Age.SelectedIndex = 0;
            }
            if (cb_Status.Items.Count > 0)
            {
                cb_Status.SelectedIndex = 0;
            }

            // hide status
            cb_Status.Enabled = false;
        }

        private void ProductMangementForm_Load(object sender, EventArgs e)
        {
            // set default features
            DefaultTextBox();

            // custom form
            StyleDatagridview();


            // load all category
            var categories = _categoryService.GetCategories();
            cb_Category.ValueMember = "CategoryId";
            cb_Category.DisplayMember = "CategoryName";
            cb_Category.DataSource = categories;

            // load gender
            cb_Gender.DataSource = _appSetting.Genders;
            // load tail color 
            cb_Color.DataSource = _appSetting.TailColors;
            // load age
            cb_Age.DataSource = _appSetting.Ages;
            // load status
            cb_Status.DataSource = _appSetting.ProductStatus;

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            // get all product
            var products = _productService.GetProducts()
                                          .Select(x => new
                                          {
                                              x.ProductId,
                                              x.ProductName,
                                              x.Age,
                                              x.Color,
                                              x.Gender,
                                              x.QuantityAvailable,
                                              x.QuantitySold,
                                              x.Category.CategoryName,
                                              x.DateCreated,
                                              x.Price,
                                              x.Characteristics,
                                              x.Status,
                                              x.Detail,
                                              x.Discount
                                          })
                                          .ToList();
            // binding source
            var bindingSource = new BindingSource();
            // set to bs datasoure <- products
            bindingSource.DataSource = products;
            dgv_Product.DataSource = bindingSource;

            // custom data grid view column
            CustomDataGridViewColumn();
            // custom data grid view header
            CustomDataGridViewHeader();
            // custom font
            UpdateFont();

            // hide delete btn
            btn_Delete.Enabled = false;
            // hide update btn
            btn_Update.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // ID,Name,Price are required to create new product
                // the others may update later
                if (String.IsNullOrEmpty(tb_ProductId.Text)
                    || String.IsNullOrEmpty(tb_ProductName.Text)
                    || String.IsNullOrEmpty(tb_Price.Text))
                {
                    MessageBox.Show("Vui lòng điền thông tin để thêm sản phẩm");
                    return;
                }

                /// VALIDATION
                #region
                //Id Pattern: [Bxxx]
                var isValidProductId = BFShopUtils.IsValidPattern(tb_ProductId.Text.Trim(), "^[Bb][0-9 ]+$");
                isValidProductId.ToMessage("Mã sản không đúng định dạng [Bxxx]");
                if (!isValidProductId) return;

                // validate product name 
                var isValidProductName = BFShopUtils.IsNotNumericString(tb_ProductName.Text.Trim());
                isValidProductName.ToMessage("Tên sản phẩm không được chưa số");
                if (!isValidProductName) return;

                // validate number
                if (!double.TryParse(tb_Price.Text.Trim().Replace(".", ""), out var price))
                {
                    if (price < 0) MessageBox.Show("Giá tiền không thể âm");
                    MessageBox.Show("Giá tiền không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_AvailableQuantity.Text.Trim(), out var availableQuantity))
                {
                    if (availableQuantity < 0) MessageBox.Show("Số lượng tồn kho không thể âm");
                    MessageBox.Show("Số lượng tồn kho không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_SoldQuantity.Text.Trim(), out var soldQuantity))
                {
                    if (soldQuantity < 0) MessageBox.Show("Số lượng đã bán không thể âm");
                    MessageBox.Show("Số lượng đã bán không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_Coupon.Text.Trim(), out var coupon))
                {
                    if (coupon < 0) MessageBox.Show("Số lượng đã bán không thể âm");
                    else if (coupon > 100) MessageBox.Show("Mức giảm giá tối đa là 100%");
                    MessageBox.Show("Giảm giá không hợp lệ");
                    return;
                }

                // validate date
                if (!DateTime.TryParse(dtp_CreateDate.Text, out var date))
                {
                    MessageBox.Show("Ngày nhập không hợp lệ");
                    return;
                }
                #endregion


                // product features
                #region
                var productId = tb_ProductId.Text.Trim().ToUpper();
                var productName = tb_ProductName.Text.Trim();
                var color = cb_Color.SelectedValue.ToString();
                var gender = cb_Gender.SelectedValue.ToString();
                var age = cb_Age.SelectedValue.ToString();
                var categoryId = Convert.ToInt32(cb_Category.SelectedValue);
                var dateFormat = date.ToString("yyyy-MM-dd");
                var createDate = DateTime.ParseExact(dateFormat,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var Characteristics = tb_Chacteristic.Text.Trim();
                var status = cb_Status.SelectedValue.ToString();
                var detail = tb_Detail.Text.Trim();
                #endregion

                // generate product model 
                var product = new Product()
                {
                    ProductId = productId,
                    ProductName = productName,
                    Age = age,
                    Color = color,
                    Gender = gender,
                    CategoryId = categoryId,
                    QuantityAvailable = availableQuantity,
                    QuantitySold = soldQuantity,
                    Price = price,
                    Characteristics = Characteristics,
                    Status = status,
                    DateCreated = createDate,
                    Detail = detail,
                    Image = _birdImage,
                    Discount = coupon
                };

                // create product
                var isSucess = _productService.Create(product);

                if (isSucess)
                {
                    // load form
                    ProductMangementForm_Load(sender, e);

                    MessageBox.Show("Tạo mới sản phẩm thành công");
                    return;
                }

                MessageBox.Show("Tạo mới sản phẩm thất bại");
                return;
            }
            catch (FormatException ex)
            {

            }
            catch (DbUpdateException ex)
            {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var productId = tb_ProductId.Text.Trim();

            // delete product
            var isSuccess = _productService.Delete(productId);

            if (isSuccess)
            {
                // load form
                ProductMangementForm_Load(sender, e);
                MessageBox.Show("Xóa sản phẩm thành công");
                return;
            }

            MessageBox.Show("Xóa sản phẩm thất bại");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                /// VALIDATION
                #region
                //Id Pattern: [Bxxx]
                var isValidProductId = BFShopUtils.IsValidPattern(tb_ProductId.Text.Trim(), "^[Bb][0-9 ]+$");
                isValidProductId.ToMessage("Mã sản không đúng định dạng [Bxxx]");
                if (!isValidProductId) return;

                // validate product name 
                var isValidProductName = BFShopUtils.IsNotNumericString(tb_ProductName.Text.Trim());
                isValidProductName.ToMessage("Tên sản phẩm không được chưa số");
                if (!isValidProductName) return;

                // validate number
                if (!double.TryParse(tb_Price.Text.Trim().Replace(".", ""), out var price))
                {
                    if (price < 0) MessageBox.Show("Giá tiền không thể âm");
                    MessageBox.Show("Giá tiền không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_AvailableQuantity.Text.Trim(), out var availableQuantity))
                {
                    if (availableQuantity < 0) MessageBox.Show("Số lượng tồn kho không thể âm");
                    MessageBox.Show("Số lượng tồn kho không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_SoldQuantity.Text.Trim(), out var soldQuantity))
                {
                    if (soldQuantity < 0) MessageBox.Show("Số lượng đã bán không thể âm");
                    MessageBox.Show("Số lượng đã bán không hợp lệ");
                    return;
                }
                if (!int.TryParse(tb_Coupon.Text.Trim(), out var coupon))
                {
                    if (coupon < 0) MessageBox.Show("Số lượng đã bán không thể âm");
                    else if (coupon > 100) MessageBox.Show("Mức giảm giá tối đa là 100%");
                    MessageBox.Show("Giảm giá không hợp lệ");
                    return;
                }

                // validate date
                if (!DateTime.TryParse(dtp_CreateDate.Text, out var date))
                {
                    MessageBox.Show("Ngày nhập không hợp lệ");
                    return;
                }
                #endregion

                // product features
                #region
                var productId = tb_ProductId.Text.Trim().ToUpper();
                var productName = tb_ProductName.Text.Trim();
                var color = cb_Color.SelectedValue.ToString();
                var gender = cb_Gender.SelectedValue.ToString();
                var age = cb_Age.SelectedValue.ToString();
                var categoryId = Convert.ToInt32(cb_Category.SelectedValue);
                var dateFormat = date.ToString("yyyy-MM-dd");
                var createDate = DateTime.ParseExact(dateFormat,
                        "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var Characteristics = tb_Chacteristic.Text.Trim();
                var status = cb_Status.SelectedValue.ToString();
                var detail = tb_Detail.Text.Trim();
                #endregion

                // get product
                var productEntity = _productService.GetProduct(productId);

                if (!String.IsNullOrEmpty(_birdImage)
                    && productEntity.Image is not null)
                {
                    // delete prev image
                    FileInfo f = new FileInfo(Path.Combine(_imageFolderPath, productEntity.Image));
                    if (f.Exists)
                    {
                        f.Delete();
                    }
                }

                // generate product model 
                var product = new Product()
                {
                    ProductName = productName,
                    Age = age,
                    Color = color,
                    Gender = gender,
                    CategoryId = categoryId,
                    QuantityAvailable = availableQuantity,
                    QuantitySold = soldQuantity,
                    Price = price,
                    Characteristics = Characteristics,
                    Status = status,
                    DateCreated = createDate,
                    Detail = detail,
                    Image = _birdImage,
                    Discount = coupon
                };

                // update product
                var isSuccess = _productService.Update(productId, product);

                if (isSuccess)
                {
                    // load form
                    ProductMangementForm_Load(sender, e);
                    MessageBox.Show("Sửa sản phẩm thành công");
                    return;
                }

                MessageBox.Show("Sửa sản phẩm thất bại");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và đúng định dạng");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // set default textbox
            DefaultTextBox();

            // unhide add button
            btn_Add.Enabled = true;
            tb_ProductId.Enabled = true;
            // hide update,delete btn
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var totalRow = dgv_Product.Rows.Count;
            if (e.RowIndex != -1
                && e.RowIndex < totalRow)
            {
                tb_ProductId.Text = dgv_Product.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_ProductName.Text = dgv_Product.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_AvailableQuantity.Text = dgv_Product.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_SoldQuantity.Text = dgv_Product.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_Chacteristic.Text = dgv_Product.Rows[e.RowIndex].Cells[10].Value.ToString();
                cb_Status.SelectedIndex = _appSetting.ProductStatus.ToList().IndexOf(dgv_Product.Rows[e.RowIndex].Cells[11].Value.ToString());
                tb_Detail.Text = dgv_Product.Rows[e.RowIndex].Cells[12].Value.ToString();
                cb_Age.SelectedIndex = _appSetting.Ages.ToList().IndexOf(dgv_Product.Rows[e.RowIndex].Cells[2].Value.ToString());
                cb_Color.SelectedIndex = _appSetting.TailColors.ToList().IndexOf(dgv_Product.Rows[e.RowIndex].Cells[3].Value.ToString());
                cb_Gender.SelectedIndex = _appSetting.Genders.ToList().IndexOf(dgv_Product.Rows[e.RowIndex].Cells[4].Value.ToString());

                // price format
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                var price = dgv_Product.Rows[e.RowIndex].Cells[9].Value.ToString();
                tb_Price.Text = double.Parse(price).ToString("#,###", cul.NumberFormat);

                // datetime format
                var dateFormat = Convert.ToDateTime(dgv_Product.Rows[e.RowIndex].Cells[8].Value).ToString("yyyy-MM-dd");
                dtp_CreateDate.Value = DateTime.ParseExact(dateFormat,
                    "yyyy-MM-dd", CultureInfo.InvariantCulture);

                // get category by name
                var categories = _categoryService.GetCategories();
                var categoryName = dgv_Product.Rows[e.RowIndex].Cells[7].Value.ToString();
                cb_Category.SelectedValue = categories.Where(x => x.CategoryName.Equals(categoryName))
                                                      .Select(x => x.CategoryId)
                                                      .FirstOrDefault();
                tb_Coupon.Text = dgv_Product.Rows[e.RowIndex].Cells[13].Value.ToString();

                // load image
                var product = _productService.GetProduct(tb_ProductId.Text);
                if (!String.IsNullOrEmpty(product.Image)
                   && Guid.TryParse(product.Image.Substring(0, 36), out var guidType))
                {
                    //var imagePath = Path.Combine(imageFolderPath, profile.Image);
                    var imagePath = _imageFolderPath + @"\" + $"{product.Image}";

                    FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    pic_Avatar.Image = Image.FromStream(fs);
                    fs.Close();

                    //pictureBox1.Image = Image.FromFile(imagePath);
                    pic_Camera.Hide();
                }
                else
                {
                    _birdImage = string.Empty;
                    pic_Avatar.Image = null!;
                    pic_Camera.Show();
                }
            }

            // hide productId
            tb_ProductId.Enabled = false;
            // hide add button
            btn_Add.Enabled = false;
            // unhide btns
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            // unhide status
            cb_Status.Enabled = true;
        }

        private void pic_Camera_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pic_Avatar.Image = new Bitmap(open.FileName);

                Image img = Image.FromStream(open.OpenFile());

                var guidId = Guid.NewGuid();
                var imageDetail = $"{guidId}.Jpeg";
                img.Save(Path.Combine(_imageFolderPath, imageDetail), ImageFormat.Jpeg);
                _birdImage = imageDetail;

                //// get profile
                //var candidateProfile = _candidateService.GetById(CandidateID);
                //// set new image
                //candidateProfile.Image = imageDetails;
                //// update profile image
                //_candidateService.UpdateCandidateProfile(candidateProfile);

                pic_Camera.Hide();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            var seachValue = tb_Search.Text.Trim();

            // search Products
            var products = _productService.Search(seachValue);

            // set default features
            DefaultTextBox();

            // custom form
            StyleDatagridview();


            // load all category
            var categories = _categoryService.GetCategories();
            cb_Category.ValueMember = "CategoryId";
            cb_Category.DisplayMember = "CategoryName";
            cb_Category.DataSource = categories;

            // get all product
            var result = products.Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.Age,
                x.Color,
                x.Gender,
                x.QuantityAvailable,
                x.QuantitySold,
                x.Category.CategoryName,
                x.DateCreated,
                x.Price,
                x.Characteristics,
                x.Status,
                x.Detail,
                x.Discount
            }).ToList();

            // binding source
            var bindingSource = new BindingSource();
            // set to bs datasoure <- products
            bindingSource.DataSource = result;
            dgv_Product.DataSource = bindingSource;

            // custom data grid view column
            CustomDataGridViewColumn();
            // custom data grid view header
            CustomDataGridViewHeader();
            // custom font
            UpdateFont();
        }
    }

    // Extension method
    public static class ProductManagementFormExtension
    {
        public static void ToMessage(this bool isValid, string message)
        {
            if (!isValid)
            {
                MessageBox.Show(message);
            }
        }
    }
}
