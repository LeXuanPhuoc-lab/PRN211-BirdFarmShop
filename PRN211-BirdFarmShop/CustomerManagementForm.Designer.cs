namespace PRN211_BirdFarmShop
{
    partial class CustomerManagementForm
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
            groupBox2 = new GroupBox();
            orderInfo = new RichTextBox();
            tbox_Search = new TextBox();
            btn_Cancel = new Button();
            btn_Search = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Add = new Button();
            dtg_CusAcc = new DataGridView();
            groupBox1 = new GroupBox();
            phoneError = new Label();
            birthDayError = new Label();
            genderError = new Label();
            nameError = new Label();
            cityError = new Label();
            passwordError = new Label();
            streetError = new Label();
            emailError = new Label();
            DateOfBirth = new DateTimePicker();
            cb_Female = new CheckBox();
            cb_Male = new CheckBox();
            label7 = new Label();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            tbox_City = new TextBox();
            label2 = new Label();
            tbox_Street = new TextBox();
            tbox_Phone = new TextBox();
            tbox_Fullname = new TextBox();
            tbox_Pasword = new TextBox();
            tbox_Email = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_CusAcc).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(orderInfo);
            groupBox2.Location = new Point(779, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 215);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detailed Order";
            // 
            // orderInfo
            // 
            orderInfo.Location = new Point(6, 43);
            orderInfo.Name = "orderInfo";
            orderInfo.Size = new Size(238, 180);
            orderInfo.TabIndex = 0;
            orderInfo.Text = "";
            // 
            // tbox_Search
            // 
            tbox_Search.Location = new Point(21, 298);
            tbox_Search.Name = "tbox_Search";
            tbox_Search.Size = new Size(399, 27);
            tbox_Search.TabIndex = 13;
            // 
            // btn_Cancel
            // 
            btn_Cancel.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Cancel.Location = new Point(609, 525);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Hủy";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Search
            // 
            btn_Search.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Search.Location = new Point(539, 296);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 9;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Update
            // 
            btn_Update.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Update.Location = new Point(426, 525);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 10;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Delete.Location = new Point(189, 525);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.ForeColor = Color.FromArgb(0, 117, 214);
            btn_Add.Location = new Point(21, 525);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 12;
            btn_Add.Text = "Tạo";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dtg_CusAcc
            // 
            dtg_CusAcc.BackgroundColor = SystemColors.GradientActiveCaption;
            dtg_CusAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_CusAcc.Location = new Point(21, 331);
            dtg_CusAcc.Name = "dtg_CusAcc";
            dtg_CusAcc.RowHeadersWidth = 51;
            dtg_CusAcc.RowTemplate.Height = 29;
            dtg_CusAcc.Size = new Size(682, 188);
            dtg_CusAcc.TabIndex = 5;
            dtg_CusAcc.CellClick += dtg_CusAcc_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(phoneError);
            groupBox1.Controls.Add(birthDayError);
            groupBox1.Controls.Add(genderError);
            groupBox1.Controls.Add(nameError);
            groupBox1.Controls.Add(cityError);
            groupBox1.Controls.Add(passwordError);
            groupBox1.Controls.Add(streetError);
            groupBox1.Controls.Add(emailError);
            groupBox1.Controls.Add(DateOfBirth);
            groupBox1.Controls.Add(cb_Female);
            groupBox1.Controls.Add(cb_Male);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbox_City);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbox_Street);
            groupBox1.Controls.Add(tbox_Phone);
            groupBox1.Controls.Add(tbox_Fullname);
            groupBox1.Controls.Add(tbox_Pasword);
            groupBox1.Controls.Add(tbox_Email);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1011, 218);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản";
            // 
            // phoneError
            // 
            phoneError.AutoSize = true;
            phoneError.ForeColor = Color.Red;
            phoneError.Location = new Point(421, 171);
            phoneError.Name = "phoneError";
            phoneError.Size = new Size(260, 20);
            phoneError.TabIndex = 4;
            phoneError.Text = "Số điện thoại dài 9-10 chữ số, 0 ở đầu";
            // 
            // birthDayError
            // 
            birthDayError.AutoSize = true;
            birthDayError.ForeColor = Color.Red;
            birthDayError.Location = new Point(753, 58);
            birthDayError.Name = "birthDayError";
            birthDayError.Size = new Size(210, 20);
            birthDayError.TabIndex = 4;
            birthDayError.Text = "Khách hàng yêu cầu >=18 tuổi";
            // 
            // genderError
            // 
            genderError.AutoSize = true;
            genderError.ForeColor = Color.Red;
            genderError.Location = new Point(753, 156);
            genderError.Name = "genderError";
            genderError.Size = new Size(154, 20);
            genderError.TabIndex = 4;
            genderError.Text = "Yêu cầu chọn giới tính";
            // 
            // nameError
            // 
            nameError.AutoSize = true;
            nameError.ForeColor = Color.Red;
            nameError.Location = new Point(38, 177);
            nameError.Name = "nameError";
            nameError.Size = new Size(245, 20);
            nameError.TabIndex = 4;
            nameError.Text = "Tên không được chưa ký tự đặc biệt";
            // 
            // cityError
            // 
            cityError.AutoSize = true;
            cityError.ForeColor = Color.Red;
            cityError.Location = new Point(421, 114);
            cityError.Name = "cityError";
            cityError.Size = new Size(316, 20);
            cityError.TabIndex = 4;
            cityError.Text = "Tên thành phố không được chưa ký tự đặc biệt";
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(38, 114);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(360, 20);
            passwordError.TabIndex = 4;
            passwordError.Text = "Mật khẩu cần 1 ký tự đặc biệt, một số và 1 chứ in hoa";
            // 
            // streetError
            // 
            streetError.AutoSize = true;
            streetError.ForeColor = Color.Red;
            streetError.Location = new Point(421, 52);
            streetError.Name = "streetError";
            streetError.Size = new Size(293, 20);
            streetError.TabIndex = 4;
            streetError.Text = "Tên đường không được chưa ký tự đặc biệt";
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.ForeColor = Color.Red;
            emailError.Location = new Point(38, 58);
            emailError.Name = "emailError";
            emailError.Size = new Size(213, 20);
            emailError.TabIndex = 4;
            emailError.Text = "Vui lòng nhập đúng mẫu email";
            // 
            // DateOfBirth
            // 
            DateOfBirth.Format = DateTimePickerFormat.Custom;
            DateOfBirth.Location = new Point(825, 16);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(148, 27);
            DateOfBirth.TabIndex = 3;
            // 
            // cb_Female
            // 
            cb_Female.AutoSize = true;
            cb_Female.Location = new Point(894, 115);
            cb_Female.Name = "cb_Female";
            cb_Female.Size = new Size(79, 24);
            cb_Female.TabIndex = 2;
            cb_Female.Text = "Female";
            cb_Female.UseVisualStyleBackColor = true;
            // 
            // cb_Male
            // 
            cb_Male.AutoSize = true;
            cb_Male.Location = new Point(825, 115);
            cb_Male.Name = "cb_Male";
            cb_Male.Size = new Size(64, 24);
            cb_Male.TabIndex = 2;
            cb_Male.Text = "Male";
            cb_Male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(753, 116);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 1;
            label7.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 85);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 1;
            label5.Text = "City";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(421, 141);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 1;
            label9.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 150);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 1;
            label8.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 87);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(753, 21);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 1;
            label6.Text = "BirthDay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 17);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 1;
            label4.Text = "Street";
            // 
            // tbox_City
            // 
            tbox_City.Location = new Point(488, 78);
            tbox_City.Name = "tbox_City";
            tbox_City.Size = new Size(125, 27);
            tbox_City.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 26);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // tbox_Street
            // 
            tbox_Street.Location = new Point(488, 14);
            tbox_Street.Name = "tbox_Street";
            tbox_Street.Size = new Size(125, 27);
            tbox_Street.TabIndex = 0;
            // 
            // tbox_Phone
            // 
            tbox_Phone.Location = new Point(488, 138);
            tbox_Phone.Name = "tbox_Phone";
            tbox_Phone.Size = new Size(125, 27);
            tbox_Phone.TabIndex = 0;
            // 
            // tbox_Fullname
            // 
            tbox_Fullname.Location = new Point(116, 147);
            tbox_Fullname.Name = "tbox_Fullname";
            tbox_Fullname.Size = new Size(162, 27);
            tbox_Fullname.TabIndex = 0;
            // 
            // tbox_Pasword
            // 
            tbox_Pasword.Location = new Point(116, 84);
            tbox_Pasword.Name = "tbox_Pasword";
            tbox_Pasword.Size = new Size(162, 27);
            tbox_Pasword.TabIndex = 0;
            // 
            // tbox_Email
            // 
            tbox_Email.Location = new Point(116, 23);
            tbox_Email.Name = "tbox_Email";
            tbox_Email.Size = new Size(162, 27);
            tbox_Email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 6;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 600);
            Controls.Add(groupBox2);
            Controls.Add(tbox_Search);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Search);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(dtg_CusAcc);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CustomerManagementForm";
            Text = "CustomerManagementForm";
            Load += CustomerManagementForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_CusAcc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private RichTextBox orderInfo;
        private TextBox tbox_Search;
        private Button btn_Cancel;
        private Button btn_Search;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Add;
        private DataGridView dtg_CusAcc;
        private GroupBox groupBox1;
        private DateTimePicker DateOfBirth;
        private CheckBox cb_Female;
        private CheckBox cb_Male;
        private Label label7;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox tbox_City;
        private Label label2;
        private TextBox tbox_Street;
        private TextBox tbox_Phone;
        private TextBox tbox_Fullname;
        private TextBox tbox_Pasword;
        private TextBox tbox_Email;
        private Label label1;
        private Label nameError;
        private Label passwordError;
        private Label emailError;
        private Label genderError;
        private Label cityError;
        private Label streetError;
        private Label phoneError;
        private Label birthDayError;
    }
}