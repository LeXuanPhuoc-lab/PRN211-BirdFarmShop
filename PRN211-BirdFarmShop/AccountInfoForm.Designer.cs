namespace PRN211_BirdFarmShop
{
    partial class AccountInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            dt_birthday = new DateTimePicker();
            txtRole = new TextBox();
            txtPhone = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            bt_close = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            S = new Label();
            label4 = new Label();
            lable1 = new Label();
            panel13 = new Panel();
            radioMale = new RadioButton();
            radioFemale = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label11 = new Label();
            txtPassword = new Label();
            textBox1 = new TextBox();
            txtConfirm = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            txtUpdateAccount = new Button();
            label12 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // dt_birthday
            // 
            dt_birthday.CalendarMonthBackground = SystemColors.InactiveBorder;
            dt_birthday.CalendarTitleBackColor = SystemColors.InactiveBorder;
            dt_birthday.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dt_birthday.Format = DateTimePickerFormat.Short;
            dt_birthday.Location = new Point(190, 234);
            dt_birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.RightToLeft = RightToLeft.No;
            dt_birthday.Size = new Size(346, 31);
            dt_birthday.TabIndex = 44;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.ControlLight;
            txtRole.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(751, 312);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(346, 31);
            txtRole.TabIndex = 45;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.InactiveBorder;
            txtPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(751, 87);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(346, 31);
            txtPhone.TabIndex = 36;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = SystemColors.InactiveBorder;
            txtStreet.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.Location = new Point(751, 390);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(346, 104);
            txtStreet.TabIndex = 33;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.InactiveBorder;
            txtCity.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(751, 160);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(346, 31);
            txtCity.TabIndex = 34;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = SystemColors.InactiveBorder;
            txtFullname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(190, 158);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(346, 31);
            txtFullname.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(190, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(346, 31);
            txtEmail.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(bt_close);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 55);
            panel2.TabIndex = 46;
            // 
            // bt_close
            // 
            bt_close.Image = Properties.Resources.icons8_close_window_50;
            bt_close.Location = new Point(1122, 3);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(38, 35);
            bt_close.TabIndex = 23;
            bt_close.UseVisualStyleBackColor = true;
            bt_close.Click += bt_close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(729, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 48);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(446, 6);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 21;
            label2.Text = "Thông tin tài khoản";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.MediumBlue;
            label10.Location = new Point(629, 230);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 35;
            label10.Text = "Giới tính";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(636, 312);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 43;
            label9.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MediumBlue;
            label8.Location = new Point(47, 234);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 42;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(591, 88);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 41;
            label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(-161, 288);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 40;
            label6.Text = "Thành Phố";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            S.ForeColor = Color.Blue;
            S.Location = new Point(-129, 350);
            S.Name = "S";
            S.Size = new Size(67, 25);
            S.TabIndex = 39;
            S.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(-154, 234);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 38;
            label4.Text = "Họ và tên";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lable1.ForeColor = Color.Blue;
            lable1.Location = new Point(-118, 177);
            lable1.Name = "lable1";
            lable1.Size = new Size(56, 25);
            lable1.TabIndex = 37;
            lable1.Text = "Email";
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.InactiveBorder;
            panel13.Controls.Add(radioMale);
            panel13.Controls.Add(radioFemale);
            panel13.Location = new Point(751, 234);
            panel13.Name = "panel13";
            panel13.Size = new Size(346, 38);
            panel13.TabIndex = 47;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Checked = true;
            radioMale.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioMale.Location = new Point(19, 6);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(68, 29);
            radioMale.TabIndex = 5;
            radioMale.TabStop = true;
            radioMale.Text = "Nam";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioFemale.Location = new Point(159, 5);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(54, 29);
            radioFemale.TabIndex = 6;
            radioFemale.Text = "Nữ";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(610, 160);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 51;
            label1.Text = "Thành Phố";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(642, 390);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 50;
            label3.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(49, 160);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 49;
            label5.Text = "Họ và tên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.MediumBlue;
            label11.Location = new Point(80, 87);
            label11.Name = "label11";
            label11.Size = new Size(56, 25);
            label11.TabIndex = 48;
            label11.Text = "Email";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.MediumBlue;
            txtPassword.Location = new Point(47, 312);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(89, 25);
            txtPassword.TabIndex = 53;
            txtPassword.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(190, 304);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 31);
            textBox1.TabIndex = 52;
            // 
            // txtConfirm
            // 
            txtConfirm.AutoSize = true;
            txtConfirm.BackColor = Color.White;
            txtConfirm.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirm.ForeColor = Color.MediumBlue;
            txtConfirm.Location = new Point(18, 401);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(123, 25);
            txtConfirm.TabIndex = 55;
            txtConfirm.Text = "Xác nhận mật";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(190, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 31);
            textBox2.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.WhiteSmoke;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(12, 568);
            label13.Name = "label13";
            label13.Size = new Size(426, 19);
            label13.TabIndex = 57;
            label13.Text = "Bắt buộc phải nhập tất cả các thông tin trước khi câp nhật tài khoản";
            // 
            // txtUpdateAccount
            // 
            txtUpdateAccount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUpdateAccount.Image = (Image)resources.GetObject("txtUpdateAccount.Image");
            txtUpdateAccount.Location = new Point(533, 513);
            txtUpdateAccount.Name = "txtUpdateAccount";
            txtUpdateAccount.Size = new Size(140, 46);
            txtUpdateAccount.TabIndex = 58;
            txtUpdateAccount.Text = "Cập nhật";
            txtUpdateAccount.UseVisualStyleBackColor = true;
            txtUpdateAccount.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.MediumBlue;
            label12.Location = new Point(49, 426);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 59;
            label12.Text = "khẩu mới";
            // 
            // AccountInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1161, 596);
            ControlBox = false;
            Controls.Add(label12);
            Controls.Add(txtUpdateAccount);
            Controls.Add(label13);
            Controls.Add(txtConfirm);
            Controls.Add(textBox2);
            Controls.Add(txtPassword);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(dt_birthday);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(txtStreet);
            Controls.Add(txtCity);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(S);
            Controls.Add(label4);
            Controls.Add(lable1);
            Controls.Add(panel13);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountInfoForm";
            Load += AccountInfoForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dt_birthday;
        private TextBox txtRole;
        private TextBox txtPhone;
        private TextBox txtStreet;
        private TextBox txtCity;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private Panel panel2;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label S;
        private Label label4;
        private Label lable1;
        private Panel panel13;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label11;
        private Label txtPassword;
        private TextBox textBox1;
        private Label txtConfirm;
        private TextBox textBox2;
        private Label label13;
        private Button txtUpdateAccount;
        private PictureBox pictureBox1;
        private Button bt_close;
        private Label label12;
    }
}