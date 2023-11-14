namespace PRN211_BirdFarmShop
{
    partial class StaffManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagerForm));
            groupBox1 = new GroupBox();
            dtg_staffList = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            bt_delete = new Button();
            bt_Save = new Button();
            bt_add = new Button();
            dt_birthday = new DateTimePicker();
            txtRole = new TextBox();
            txtPhone = new TextBox();
            txtStreet = new TextBox();
            txtCity = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btClear = new Button();
            panel5 = new Panel();
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
            bt_close = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            Fullname = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            RoleDesc = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_staffList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel13.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_staffList);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 264);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dtg_staffList
            // 
            dtg_staffList.BackgroundColor = SystemColors.GradientActiveCaption;
            dtg_staffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_staffList.Columns.AddRange(new DataGridViewColumn[] { Fullname, Email, City, Street, Birthday, Gender, Phone, RoleDesc });
            dtg_staffList.Dock = DockStyle.Fill;
            dtg_staffList.GridColor = Color.White;
            dtg_staffList.Location = new Point(3, 19);
            dtg_staffList.Name = "dtg_staffList";
            dtg_staffList.RowTemplate.Height = 25;
            dtg_staffList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_staffList.Size = new Size(1048, 242);
            dtg_staffList.TabIndex = 0;
            dtg_staffList.CellClick += dtg_staffList_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dt_birthday);
            groupBox2.Controls.Add(txtRole);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(txtFullname);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(btClear);
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(S);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lable1);
            groupBox2.Controls.Add(panel13);
            groupBox2.ImeMode = ImeMode.NoControl;
            groupBox2.Location = new Point(12, 354);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1054, 435);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_delete);
            groupBox3.Controls.Add(bt_Save);
            groupBox3.Controls.Add(bt_add);
            groupBox3.Location = new Point(16, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1021, 74);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = Color.MistyRose;
            bt_delete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_delete.Image = (Image)resources.GetObject("bt_delete.Image");
            bt_delete.Location = new Point(381, 22);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(134, 40);
            bt_delete.TabIndex = 1;
            bt_delete.Text = "Xoá nhân viên";
            bt_delete.TextAlign = ContentAlignment.MiddleLeft;
            bt_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_Save
            // 
            bt_Save.BackColor = Color.LightYellow;
            bt_Save.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Save.Image = (Image)resources.GetObject("bt_Save.Image");
            bt_Save.Location = new Point(215, 22);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(139, 40);
            bt_Save.TabIndex = 2;
            bt_Save.Text = "Lưu thông tin";
            bt_Save.TextAlign = ContentAlignment.MiddleLeft;
            bt_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_Save.UseVisualStyleBackColor = false;
            bt_Save.Click += bt_Save_Click;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.LightYellow;
            bt_add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_add.Image = (Image)resources.GetObject("bt_add.Image");
            bt_add.Location = new Point(51, 22);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(135, 40);
            bt_add.TabIndex = 0;
            bt_add.Text = "Tạo nhân viên";
            bt_add.TextAlign = ContentAlignment.MiddleLeft;
            bt_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // dt_birthday
            // 
            dt_birthday.CalendarMonthBackground = SystemColors.InactiveBorder;
            dt_birthday.CalendarTitleBackColor = SystemColors.InactiveBorder;
            dt_birthday.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dt_birthday.Format = DateTimePickerFormat.Short;
            dt_birthday.Location = new Point(651, 130);
            dt_birthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.RightToLeft = RightToLeft.No;
            dt_birthday.Size = new Size(260, 31);
            dt_birthday.TabIndex = 18;
            // 
            // txtRole
            // 
            txtRole.BackColor = SystemColors.GradientActiveCaption;
            txtRole.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(651, 252);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(260, 31);
            txtRole.TabIndex = 22;
            txtRole.Text = "Nhân Viên";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.InactiveBorder;
            txtPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(651, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(260, 31);
            txtPhone.TabIndex = 5;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = SystemColors.InactiveBorder;
            txtStreet.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreet.Location = new Point(160, 248);
            txtStreet.Multiline = true;
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(270, 104);
            txtStreet.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.InactiveBorder;
            txtCity.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(160, 187);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(270, 31);
            txtCity.TabIndex = 4;
            // 
            // txtFullname
            // 
            txtFullname.BackColor = SystemColors.InactiveBorder;
            txtFullname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullname.Location = new Point(160, 130);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(270, 31);
            txtFullname.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(160, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 31);
            txtEmail.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 37);
            panel2.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_profile_2_50;
            pictureBox2.Location = new Point(215, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 5);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 21;
            label2.Text = "Thông tin nhân viên";
            // 
            // btClear
            // 
            btClear.BackColor = Color.Linen;
            btClear.Image = Properties.Resources.icons8_clear_19;
            btClear.Location = new Point(967, 14);
            btClear.Name = "btClear";
            btClear.Size = new Size(70, 32);
            btClear.TabIndex = 0;
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Linen;
            panel5.Location = new Point(1043, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(11, 425);
            panel5.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(547, 190);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 5;
            label10.Text = "Giới tính";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(544, 252);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 17;
            label9.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(537, 136);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 16;
            label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(576, 77);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 15;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(42, 190);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 14;
            label6.Text = "Thành Phố";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            S.ForeColor = Color.Blue;
            S.Location = new Point(74, 252);
            S.Name = "S";
            S.Size = new Size(67, 25);
            S.TabIndex = 13;
            S.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(49, 136);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 12;
            label4.Text = "Họ và tên";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lable1.ForeColor = Color.Blue;
            lable1.Location = new Point(85, 79);
            lable1.Name = "lable1";
            lable1.Size = new Size(56, 25);
            lable1.TabIndex = 10;
            lable1.Text = "Email";
            lable1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.InactiveBorder;
            panel13.Controls.Add(radioMale);
            panel13.Controls.Add(radioFemale);
            panel13.Location = new Point(651, 190);
            panel13.Name = "panel13";
            panel13.Size = new Size(260, 38);
            panel13.TabIndex = 30;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Checked = true;
            radioMale.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioMale.Location = new Point(19, 2);
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
            radioFemale.Location = new Point(161, 3);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(54, 29);
            radioFemale.TabIndex = 6;
            radioFemale.Text = "Nữ";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // bt_close
            // 
            bt_close.Image = Properties.Resources.icons8_close_window_50;
            bt_close.Location = new Point(1055, 0);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(38, 35);
            bt_close.TabIndex = 3;
            bt_close.UseVisualStyleBackColor = true;
            bt_close.Click += bt_close_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.Hand;
            txtSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(12, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm nhân viên . . .";
            txtSearch.Size = new Size(430, 32);
            txtSearch.TabIndex = 3;
            txtSearch.Tag = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(470, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 35);
            label1.TabIndex = 1;
            label1.Text = "Quản lí nhân viên";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(bt_close);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Cyan;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 57);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(0, 817);
            panel3.Name = "panel3";
            panel3.Size = new Size(1186, 28);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons_search_19;
            pictureBox1.Location = new Point(401, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Linen;
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(12, 363);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 426);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1004, 10);
            panel6.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(934, 63);
            button1.Name = "button1";
            button1.Size = new Size(132, 53);
            button1.TabIndex = 9;
            button1.Text = "Cá nhân";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Fullname
            // 
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Fullname.DataPropertyName = "Fullname";
            Fullname.FillWeight = 170F;
            Fullname.HeaderText = "Họ và tên";
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            Fullname.Width = 170;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.FillWeight = 190F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 190;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.FillWeight = 110F;
            City.HeaderText = "Thành Phố";
            City.Name = "City";
            City.ReadOnly = true;
            City.Width = 110;
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.FillWeight = 140F;
            Street.HeaderText = "Địa chỉ";
            Street.Name = "Street";
            Street.ReadOnly = true;
            Street.Width = 140;
            // 
            // Birthday
            // 
            Birthday.DataPropertyName = "Birthday";
            Birthday.FillWeight = 110F;
            Birthday.HeaderText = "Ngày Sinh";
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            Birthday.Width = 110;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.FillWeight = 80F;
            Gender.HeaderText = "Giới tính";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 80;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.FillWeight = 120F;
            Phone.HeaderText = "SĐT";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 120;
            // 
            // RoleDesc
            // 
            RoleDesc.DataPropertyName = "RoleDesc";
            RoleDesc.HeaderText = "Chức vụ";
            RoleDesc.Name = "RoleDesc";
            RoleDesc.ReadOnly = true;
            // 
            // StaffManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 843);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffManagerForm";
            Load += StaffManagerForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_staffList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtStreet;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button bt_close;
        private Button bt_Save;
        private Button bt_delete;
        private Button bt_add;
        private TextBox txtSearch;
        private Button btClear;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label S;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dt_birthday;
        private DataGridView dtg_staffList;
        private Label label2;
        private TextBox txtRole;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton radioFemale;
        private Label label10;
        private RadioButton radioMale;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label lable1;
        private Panel panel13;
        private TextBox txtFullname;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn RoleDesc;
    }
}