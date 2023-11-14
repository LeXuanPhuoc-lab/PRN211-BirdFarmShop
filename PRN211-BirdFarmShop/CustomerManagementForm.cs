using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopBussinessObjects.Utils;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211_BirdFarmShop
{
    public partial class CustomerManagementForm : Form
    {
        private readonly AccountService _account;
        private readonly CustomerService _customer;

        public CustomerManagementForm()
        {
            InitializeComponent();
            _account = new AccountService();
            _customer = new CustomerService();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            var CusAcc = _account.GetAccounts().Where(x => x.RoleId == 4).Select(x => new
            {
                x.Email,
                x.Password,
                x.Fullname,
                x.Phone,
                x.Gender,
                x.Street,
                x.City,
                x.Birthday,
            }).ToList();
            if (CusAcc is null)
            {
                MessageBox.Show("Không có tài khoản khách hàng nào!");
            }
            else
            {
                dtg_CusAcc.DataSource = new BindingSource();
                dtg_CusAcc.DataSource = null;
                dtg_CusAcc.DataSource = CusAcc;
            }
            orderInfo.Enabled = false;
            SetAddButtonOn();
            SetErrorMessageOff();
        }
        private void CheckFemaleBox()
        {
            cb_Female.Checked = true;
            cb_Male.Checked = false;
        }
        private void CheckMaleBox()
        {
            cb_Male.Checked = true;
            cb_Female.Checked = false;
        }

        private void SetAddButtonOn()
        {
            btn_Add.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }
        private void SetAddButtonOff()
        {
            btn_Add.Enabled = false;
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
        }

        private void SetErrorMessageOff()
        {
            emailError.Visible = false;
            passwordError.Visible = false;
            nameError.Visible = false;
            cityError.Visible = false;
            streetError.Visible = false;
            phoneError.Visible = false;
            birthDayError.Visible = false;
            genderError.Visible = false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchString = tbox_Search.Text.Trim();
            if (searchString != string.Empty)
            {
                var searchList = _customer.SearchMember(searchString).Select(x => new
                {
                    x.Email,
                    x.Password,
                    x.Fullname,
                    x.Phone,
                    x.Gender,
                    x.Street,
                    x.City,
                    x.Birthday,
                });
                if (searchList is null)
                {
                    MessageBox.Show("Không tìm thấy kết quả tương ứng");
                }
                else
                {
                    dtg_CusAcc.DataSource = new BindingSource();
                    dtg_CusAcc.DataSource = null;
                    dtg_CusAcc.DataSource = searchList.ToList();
                }
            }
            else
            {
                CustomerManagementForm_Load(sender, e);
            }
        }

        private void dtg_CusAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderInfo.Text = string.Empty;
            tbox_Email.Text = dtg_CusAcc.CurrentRow.Cells["Email"].Value.ToString();
            tbox_Pasword.Text = dtg_CusAcc.CurrentRow.Cells["Password"].Value.ToString();
            tbox_Fullname.Text = dtg_CusAcc.CurrentRow.Cells["FullName"].Value.ToString();
            tbox_Phone.Text = dtg_CusAcc.CurrentRow.Cells["Phone"].Value is null ? "" :
                dtg_CusAcc.CurrentRow.Cells["Phone"].Value.ToString();
            tbox_Street.Text = dtg_CusAcc.CurrentRow.Cells["Street"].Value is null ? "" :
                dtg_CusAcc.CurrentRow.Cells["Street"].Value.ToString();
            tbox_City.Text = dtg_CusAcc.CurrentRow.Cells["City"].Value is null ? "" :
                dtg_CusAcc.CurrentRow.Cells["City"].Value.ToString();
            if (dtg_CusAcc.CurrentRow.Cells["Gender"].Value is not null)
            {
                if (dtg_CusAcc.CurrentRow.Cells["Gender"].Value.ToString().Equals("Male"))
                {
                    CheckMaleBox();
                }
                else
                {
                    CheckFemaleBox();
                }
            }
            if (dtg_CusAcc.CurrentRow.Cells["Birthday"].Value is not null)
            {
                DateTime birthDay = DateTime.Parse(dtg_CusAcc.CurrentRow.Cells["Birthday"].Value.ToString());
                DateOfBirth.Value = DateTime.ParseExact(birthDay.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                DateOfBirth.Value = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            var orderList = _account.GetAccount(tbox_Email.Text).Orders;
            foreach( var order in orderList ) 
            {
                orderInfo.Text = order.ToString() + @"/r";
            }
            orderInfo.Enabled = false;
            SetAddButtonOff();
            tbox_Email.Enabled = false;
            tbox_Pasword.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SetErrorMessageOff();
            bool flag = true;
            if (!BFShopUtils.IsValidFullName(tbox_Fullname.Text))
            {
                flag = false;
                nameError.Visible = true;
            }
            DateTime birthDay = DateTime.ParseExact(DateOfBirth.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy",
                CultureInfo.InvariantCulture);
            if (!BFShopUtils.isPhoneNum(tbox_Phone.Text))
            {
                flag = false;
                phoneError.Visible = true;
            }
            if (!BFShopUtils.NotIncludeSpecialCharacter(tbox_Street.Text))
            {
                flag = false;
                streetError.Visible = true;
            }
            if (!BFShopUtils.NotIncludeSpecialCharacter(tbox_City.Text))
            {
                flag = false;
                cityError.Visible = true;
            }
            if (cb_Female.Checked == false && cb_Male.Checked == false)
            {
                flag = false;
                genderError.Visible = true;
            }
            if (BFShopUtils.CalculateAge(birthDay) < 1)
            {
                flag = false;
                birthDayError.Visible = true;
            }

            if (flag)
            {
                string email = tbox_Email.Text.ToString();
                var account = _account.GetAccount(email);
                if (account is null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản");
                }
                else
                {
                    account.Fullname = tbox_Fullname.Text;
                    account.Street = tbox_Street.Text;
                    account.City = tbox_City.Text;
                    account.Phone = tbox_Phone.Text;
                    account.Birthday = birthDay;
                    if (cb_Female.Checked)
                    {
                        account.Gender = cb_Female.Text;
                    }
                    else
                    {
                        account.Gender = cb_Male.Text;
                    }
                    bool isSuccess = _customer.UpdateMember(email, account);
                    if (isSuccess)
                    {
                        SetErrorMessageOff();
                        btn_Cancel_Click(sender, e);
                        btn_Search_Click(sender, e);
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra");
                    }
                }

            }

        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            tbox_Email.Clear();
            tbox_Pasword.Clear();
            tbox_Fullname.Clear();
            tbox_City.Clear();
            tbox_Street.Clear();
            tbox_Search.Clear();
            tbox_Phone.Clear();
            DateOfBirth.Value = DateTime.Now;
            cb_Female.Checked = false;
            cb_Male.Checked = false;
            tbox_Email.Enabled = true;
            tbox_Pasword.Enabled = true;
            SetAddButtonOn();
            SetErrorMessageOff();
            orderInfo.Text = string.Empty;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SetErrorMessageOff();
            bool flag = true;
            if (!BFShopUtils.IsValidEmail(tbox_Email.Text))
            {
                flag = false;
                emailError.Visible = true;
            }
            if (!BFShopUtils.IsValidPassword(tbox_Pasword.Text))
            {
                flag = false;
                passwordError.Visible = true;
            }
            if (!BFShopUtils.IsValidFullName(tbox_Fullname.Text))
            {
                flag = false;
                nameError.Visible = true;
            }
            DateTime birthDay = DateTime.ParseExact(DateOfBirth.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy",
                CultureInfo.InvariantCulture);
            if (!BFShopUtils.isPhoneNum(tbox_Phone.Text))
            {
                flag = false;
                phoneError.Visible = true;
            }
            if (!BFShopUtils.NotIncludeSpecialCharacter(tbox_Street.Text))
            {
                flag = false;
                streetError.Visible = true;
            }
            if (!BFShopUtils.NotIncludeSpecialCharacter(tbox_City.Text))
            {
                flag = false;
                cityError.Visible = true;
            }
            if (cb_Female.Checked == false && cb_Male.Checked == false)
            {
                flag = false;
                genderError.Visible = true;
            }
            if (BFShopUtils.CalculateAge(birthDay) < 1)
            {
                flag = false;
                birthDayError.Visible = true;
            }

            if (flag)
            {
                string email = tbox_Email.Text.ToString();
                var account = _account.GetAccount(email);
                if (account is not null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
                else
                {
                    Account newAccount = new Account()
                    {
                        Email = email,
                        Password = PasswordHelper.ConvertToEncrypt(tbox_Pasword.Text),
                        RoleId = 4,
                        Fullname = tbox_Fullname.Text,
                        Street = tbox_Street.Text,
                        City = tbox_City.Text,
                        Phone = tbox_Phone.Text,
                        Birthday = birthDay
                    };

                    if (cb_Female.Checked)
                    {
                        newAccount.Gender = cb_Female.Text;
                    }
                    else
                    {
                        newAccount.Gender = cb_Male.Text;
                    }
                    bool isSuccess = _account.Create(newAccount);
                    if (isSuccess)
                    {
                        SetErrorMessageOff();
                        btn_Cancel_Click(sender, e);
                        btn_Search_Click(sender, e);
                        MessageBox.Show("Tạo mới khách hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra");
                    }
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string email = tbox_Email.Text.ToString();
            var account = _account.GetAccount(email);
            if (account is null)
            {
                MessageBox.Show("Không tìm thấy tài khoản");
            }
            else
            {
                bool isSuccess = _account.Delete(email);
                if (isSuccess)
                {
                    SetErrorMessageOff();
                    btn_Cancel_Click(sender, e);
                    btn_Search_Click(sender, e);
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                }
            }
        }
    }
}
