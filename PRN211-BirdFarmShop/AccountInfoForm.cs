using BFShopBussinessObjects;
using BFShopBussinessObjects.Entities;
using BFShopService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PRN211_BirdFarmShop
{
    public partial class AccountInfoForm : Form
    {
        private IAccountService accountService;
        public Account CurrentAccount;
        public AccountInfoForm()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = CurrentAccount.Email.ToString();
            txtFullname.Text = CurrentAccount.Fullname.ToString();
            txtCity.Text = CurrentAccount.City.ToString();
            txtStreet.Text = CurrentAccount.Street.ToString();
            txtPhone.Text = CurrentAccount.Phone.ToString();
            dt_birthday.Text = CurrentAccount.Birthday.ToString();

            if (CurrentAccount.Birthday.ToString().ToLower() == "nam")
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
        }

        public bool chkForm()
        {
            if (txtEmail.Text.Trim().Length == 0 ||
                txtFullname.Text.Trim().Length == 0 ||
                    txtCity.Text.Trim().Length == 0 ||
                txtStreet.Text.Trim().Length == 0 ||
                txtPhone.Text.Trim().Length == 0 ||
                dt_birthday.Text.Trim().Length == 0 ||
                (!radioMale.Checked && !radioFemale.Checked))
            {
                return false;
            }
            return true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text.Trim().Equals(txtConfirm.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng, vui lòng kiểm tra lại");
                    return;
                }
                if (chkForm())
                {
                    MessageBox.Show("Vui lòng nhập tất cả thông tin");
                    return;
                }
                var Email = txtEmail.Text.Trim();
                var fullname = txtFullname.Text.Trim();

                // get Email by id
                var existEmail = accountService.GetAccount(Email);
                if (existEmail is null)
                {
                    MessageBox.Show("Không tìm thấy email nhân viên này");
                    return;
                }

                /// validation
                if (String.IsNullOrEmpty(fullname))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên");
                    return;
                }
                var isValidFullName = BFShopUtils.IsValidFullName(fullname);
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên không chứa số");
                    return;
                }

                // address
                var isValidAddess = BFShopUtils.IsValidFullName(txtCity.Text.Trim());
                if (!isValidFullName)
                {
                    MessageBox.Show("Tên thành phố không chưa số và kí tự đặt biệt");
                    return;
                }
                // birthday
                var isValidAge = BFShopUtils.CalculateAge(DateTime.Parse(dt_birthday.Text));
                if (isValidAge < 18)
                {
                    MessageBox.Show("Tuổi không thể dưới 18 tuổi");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn cập nhật tài khoản này!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {


                    existEmail.Email = txtEmail.Text;
                    existEmail.Fullname = txtFullname.Text;
                    existEmail.City = txtCity.Text;
                    existEmail.Street = txtStreet.Text;
                    //existEmail.RoleId = 2; // lấy theo role của accoutn hiện tại
                    existEmail.Password = txtPassword.Text;
                    existEmail.Birthday = DateTime.Parse(dt_birthday.Text);
                    existEmail.Phone = txtPhone.Text;
                    if (radioFemale.Checked)
                    {
                        existEmail.Gender = radioFemale.Text;
                    }
                    if (!radioFemale.Checked)
                    {
                        existEmail.Gender = radioMale.Text;
                    }
                    // create new category
                    bool isSucess = accountService.Update(Email, existEmail);

                    if (isSucess)
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công\n");

                        // load form data
                        AccountInfoForm_Load(sender, e);
                        return;
                    }
                }

                MessageBox.Show("Cập nhật thông tin tài khoản thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi sảy ra " + ex.ToString());
            }
        }


    }
}
