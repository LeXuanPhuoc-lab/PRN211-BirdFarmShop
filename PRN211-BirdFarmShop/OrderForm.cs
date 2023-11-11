﻿using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopRepository;
using BFShopService;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class OrderForm : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IAccountService _accountService;
        List<OrderDetail> orderDetailList = new List<OrderDetail>();

        int totalItem = 0;
        double totalOrder = 0;

        public OrderForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
            _accountService = new AccountService();
            btn_ThemSanPham.Enabled = false;
            btn_LuuHoaDon.Enabled = false;
            btn_HuyHoaDon.Enabled = false;
            btn_InHoaDon.Enabled = false;
            cbx_EmailNhanVien.DataSource = _accountService.getAllAccountByRole(Constants.IsStaff);
            cbx_EmailNhanVien.DisplayMember = "Email";
            cbx_EmailNhanVien.ValueMember = "Email";
            cbx_SoDienThoai.DataSource = _accountService.getAllAccountByRole(Constants.IsCustomer);
            cbx_SoDienThoai.DisplayMember = "Phone";
            cbx_SoDienThoai.ValueMember = "Phone";
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        void ResetForm()
        {
            txt_MaHoaDon.Text = string.Empty;
            dt_NgayBan.Text = DateTime.Now.ToString("dd-MM-yyyy");
            cbx_MaHang.Text = string.Empty;
            txt_DonGia.Text = string.Empty;
            txt_GiongLoai.Text = string.Empty;
            txt_SoLuong.Text = string.Empty;
            txt_TongTien.Text = string.Empty;
            orderDetailList.Clear();
            dtg_OrderDetailList.DataSource = null;
        }

        private void cbx_MaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            Product pro = _productService.GetProduct(cbx_MaHang.SelectedValue.ToString());
            if (pro is not null)
            {
                txt_TenHang.Text = pro.ProductName;
                txt_GiongLoai.Text = pro.Category.CategoryName;
                txt_DonGia.Text = String.Format("{0:0,00}", pro.Price);
                txt_SoLuong.Text = "1";
                txt_ThanhTien.Text = String.Format("{0:0,00}", pro.Price);
            }
        }

        private void cbx_EmailNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            Account acc = null;
            if (cbx_EmailNhanVien.SelectedValue is not null)
            {
                acc = _accountService.GetAccount(cbx_EmailNhanVien.SelectedValue.ToString());
            }
            if (acc is not null)
            {
                txt_TenNhanVien.Text = acc.Fullname;
            }
        }

        private void cbx_SoDienThoai_SelectedValueChanged(object sender, EventArgs e)
        {
            Account acc = null;
            if (cbx_SoDienThoai.SelectedValue is not null)
            {
                acc = _accountService.GetAccountCusByPhone(cbx_SoDienThoai.SelectedValue.ToString());
            }
            if (acc is not null)
            {
                txt_TenKhachHang.Text = acc.Fullname;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (BFShopUtils.ContainsLettersOrSpecialCharacters(txt_SoLuong.Text.ToString()))
            {
                MessageBox.Show("Phải nhập chữ số");
                txt_SoLuong.Text = "1";
                return;
            }
            int sl;
            float dg, tt;
            sl = txt_SoLuong.Text == "" ? 0 : Int32.Parse(txt_SoLuong.Text);
            dg = float.Parse(txt_DonGia.Text);
            tt = sl * dg;
            txt_ThanhTien.Text = tt == 0 ? "0" : String.Format("{0:0,00}", tt);

        }


        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            txt_MaHoaDon.Text = _orderService.createOrderID();
            cbx_MaHang.DataSource = _productService.GetAllProduct();
            cbx_MaHang.DisplayMember = "ProductId";
            cbx_MaHang.ValueMember = "ProductId";
            dt_NgayBan.Text = DateTime.Now.ToString("dd-MM-yyyy");

            orderDetailList.Clear();
            dtg_OrderDetailList.DataSource = null;

            loadOrderDetailListView();

            btn_ThemSanPham.Enabled = true;
            btn_LuuHoaDon.Enabled = true;
            btn_InHoaDon.Enabled = true;
            btn_HuyHoaDon.Enabled = false;
        }

        private void loadOrderDetailListView()
        {
            if (dtg_OrderDetailList.Columns.Count == 0)
            {
                dtg_OrderDetailList.Columns.Add("ProductId", "Mã hàng");
                dtg_OrderDetailList.Columns.Add("ProductName", "Tên hàng");
                dtg_OrderDetailList.Columns.Add("Quantity", "Số lượng");
                dtg_OrderDetailList.Columns.Add("Price", "Đơn giá");
                dtg_OrderDetailList.Columns.Add("Total", "Thành tiền");

                dtg_OrderDetailList.Columns[0].Width = 200;
                dtg_OrderDetailList.Columns[1].Width = 250;
                dtg_OrderDetailList.Columns[2].Width = 200;
                dtg_OrderDetailList.Columns[3].Width = 200;
                dtg_OrderDetailList.Columns[4].Width = 200;

                dtg_OrderDetailList.AutoGenerateColumns = true;

                // Tên hiển thị của cột
                dtg_OrderDetailList.Columns["ProductId"].HeaderText = "Mã hàng";
                dtg_OrderDetailList.Columns["ProductName"].HeaderText = "Tên hàng";
                dtg_OrderDetailList.Columns["Quantity"].HeaderText = "Số lượng";
                dtg_OrderDetailList.Columns["Price"].HeaderText = "Đơn giá";
                dtg_OrderDetailList.Columns["Total"].HeaderText = "Thành tiền";
            }
            dtg_OrderDetailList.AutoGenerateColumns = false;
            dtg_OrderDetailList.DataSource = orderDetailList.Select(
                p => new
                {
                    p.ProductId,
                    p.Product.ProductName,
                    p.Quantity,
                    Price = string.Format("{0:0,00}", p.Price),
                    Total = string.Format("{0:0,00}", p.Total)
                }).ToList();
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (orderDetailList is not null && BFShopUtils.CheckProductIDExist(cbx_MaHang.SelectedValue.ToString(), orderDetailList))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Product pro = _productService.GetProduct(cbx_MaHang.SelectedValue.ToString());
            int qtyBuy = Convert.ToInt32(txt_SoLuong.Text.ToString());
            if (qtyBuy > pro.QuantityAvailable)
            {
                MessageBox.Show("Sản phẩm này chỉ còn " + pro.QuantityAvailable, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Product = new Product();
            orderDetail.Product.Category = new Category();
            orderDetail.OrderId = txt_MaHoaDon.Text.ToString();
            orderDetail.ProductId = cbx_MaHang.SelectedValue.ToString();
            orderDetail.Product.ProductName = txt_TenHang.Text.ToString();
            orderDetail.Product.Category.CategoryName = txt_GiongLoai.Text.ToString();
            orderDetail.Quantity = qtyBuy;
            orderDetail.Price = Convert.ToDouble(txt_DonGia.Text.ToString());
            orderDetail.Total = Convert.ToDouble(txt_ThanhTien.Text.ToString());
            orderDetailList.Add(orderDetail);
            loadOrderDetailListView();
            totalOrder += orderDetail.Total;
            totalItem += orderDetail.Quantity;
            txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);

        }

        private void dtg_OrderDetailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value is not null)
            {
                string productId = dtg_OrderDetailList.Rows[rowIndex].Cells["ProductId"].Value.ToString();
                int qtyBuy = Convert.ToInt32(dtg_OrderDetailList.Rows[rowIndex].Cells["Quantity"].Value.ToString());
                totalOrder -= orderDetailList.Find(item => item.ProductId.Equals(productId)).Total;
                totalItem -= orderDetailList.Find(item => item.ProductId.Equals(productId)).Quantity;
                txt_TongTien.Text = string.Format("{0:0,00}", totalOrder);
                orderDetailList.RemoveAll(item => item.ProductId.Equals(productId));
                loadOrderDetailListView();
            }
        }

        private void btn_LuuHoaDon_Click(object sender, EventArgs e)
        {
            if (orderDetailList is null || orderDetailList.Count == 0)
            {
                MessageBox.Show("Hoá đơn chưa có sản phẩm, vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Order order = new Order();
            order.OrderId = txt_MaHoaDon.Text;
            order.Email = cbx_EmailNhanVien.SelectedValue.ToString();
            order.StaffName = txt_TenNhanVien.Text;
            order.CustomerPhone = cbx_SoDienThoai.SelectedValue.ToString();
            order.CustomerName = txt_TenKhachHang.Text;
            order.CreateDate = DateTime.Now;
            order.TotalItem = totalItem;
            order.TotalPrice = totalOrder;
            if (_orderService.AddNewOrder(order) && _orderDetailService.AddNewOrderDetails(orderDetailList))
            {
                foreach (var item in orderDetailList)
                {
                    Product pro = _productService.GetProduct(item.ProductId);
                    pro.QuantityAvailable = pro.QuantityAvailable - item.Quantity;
                    pro.QuantitySold = pro.QuantitySold + item.Quantity;
                    _productService.Update(pro.ProductId, pro);
                }
                MessageBox.Show("Lưu hoá đơn thành công!");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string orderID = txt_TimMaHH.Text;
            Order order = _orderService.Search(orderID);
            orderDetailList = _orderDetailService.GetOrderDetail(orderID)
            .Select(od => new OrderDetail
            {
                ProductId = od.ProductId,
                Product = od.Product,
                Quantity = od.Quantity,
                Price = od.Price,
                Total = od.Total
            })
            .ToList();
            if (order is not null && orderDetailList is not null)
            {
                txt_MaHoaDon.Text = order.OrderId;
                dt_NgayBan.Text = order.CreateDate.HasValue ? order.CreateDate.Value.ToString("dd-MM-yyyy") : string.Empty;
                cbx_EmailNhanVien.SelectedValue = order.Email;
                txt_TenNhanVien.Text = order.StaffName;
                cbx_SoDienThoai.SelectedValue = order.CustomerPhone;
                txt_TenKhachHang.Text = order.CustomerName;
                totalOrder = order.TotalPrice;
                loadOrderDetailListView();
                btn_HuyHoaDon.Enabled = true;
                btn_InHoaDon.Enabled = true;
                btn_ThemSanPham.Enabled = false;
                btn_LuuHoaDon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hoá đơn không tồn tại!");
            }
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (_orderDetailService.DeleteOrderDetail(txt_MaHoaDon.Text.ToString())
                && _orderService.DeleteOrder(txt_MaHoaDon.Text.ToString()))
            {
                MessageBox.Show("Huỷ hoá đơn thành công!");
            }
            foreach (var item in orderDetailList)
            {
                Product pro = _productService.GetProduct(item.ProductId);
                pro.QuantityAvailable = pro.QuantityAvailable + item.Quantity;
                pro.QuantitySold = pro.QuantitySold - item.Quantity;
                _productService.Update(pro.ProductId, pro);
            }
            ResetForm();
            loadOrderDetailListView();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}