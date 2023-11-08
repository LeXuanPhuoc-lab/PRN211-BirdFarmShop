namespace PRN211_BirdFarmShop
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txt_MaHoaDon = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label13 = new Label();
            txt_TongTien = new TextBox();
            label12 = new Label();
            dtg_OrderDetailList = new DataGridView();
            ProductId = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btn_LuuHoaDon = new Button();
            btn_ThemSanPham = new Button();
            btn_ThemHoaDon = new Button();
            panel2 = new Panel();
            txt_SoLuong = new TextBox();
            txt_DonGia = new TextBox();
            txt_ThanhTien = new TextBox();
            label10 = new Label();
            cbx_MaHang = new ComboBox();
            label6 = new Label();
            label11 = new Label();
            txt_TenHang = new TextBox();
            txt_GiamGia = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_OrderDetailList).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(260, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 1);
            splitContainer1.Margin = new Padding(2, 2, 2, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(750, 421);
            splitContainer1.SplitterDistance = 149;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txt_MaHoaDon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 34);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(743, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            groupBox1.ChangeUICues += OrderForm_Load;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 68);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 92);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(150, 44);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txt_MaHoaDon
            // 
            txt_MaHoaDon.Location = new Point(150, 20);
            txt_MaHoaDon.Margin = new Padding(2, 2, 2, 2);
            txt_MaHoaDon.Name = "txt_MaHoaDon";
            txt_MaHoaDon.ReadOnly = true;
            txt_MaHoaDon.Size = new Size(187, 23);
            txt_MaHoaDon.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(27, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 5;
            label3.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(27, 46);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 4;
            label5.Text = "Ngày bán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(27, 71);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(27, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Mã hoá đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txt_TongTien);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dtg_OrderDetailList);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(750, 270);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(9, 215);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(148, 13);
            label13.TabIndex = 29;
            label13.Text = "Nháy đúp một dòng để xoá";
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(598, 211);
            txt_TongTien.Margin = new Padding(2, 2, 2, 2);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.ReadOnly = true;
            txt_TongTien.Size = new Size(150, 23);
            txt_TongTien.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 117, 214);
            label12.Location = new Point(512, 213);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 26;
            label12.Text = "Tổng tiền:";
            // 
            // dtg_OrderDetailList
            // 
            dtg_OrderDetailList.BackgroundColor = Color.White;
            dtg_OrderDetailList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtg_OrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_OrderDetailList.Columns.AddRange(new DataGridViewColumn[] { ProductId, Column2, Column3, Column4, Column5, Column6 });
            dtg_OrderDetailList.GridColor = SystemColors.ControlLight;
            dtg_OrderDetailList.Location = new Point(4, 88);
            dtg_OrderDetailList.Margin = new Padding(2, 2, 2, 2);
            dtg_OrderDetailList.Name = "dtg_OrderDetailList";
            dtg_OrderDetailList.RowHeadersWidth = 62;
            dtg_OrderDetailList.RowTemplate.Height = 33;
            dtg_OrderDetailList.Size = new Size(746, 120);
            dtg_OrderDetailList.TabIndex = 28;
            dtg_OrderDetailList.CellDoubleClick += dtg_OrderDetailList_CellDoubleClick;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "Mã hàng";
            ProductId.MinimumWidth = 8;
            ProductId.Name = "ProductId";
            ProductId.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "Tên hàng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Quantity";
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Price";
            Column4.HeaderText = "Đơn giá";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Discount";
            Column5.HeaderText = "Giảm giá";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Total";
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_LuuHoaDon);
            panel1.Controls.Add(btn_ThemSanPham);
            panel1.Controls.Add(btn_ThemHoaDon);
            panel1.Location = new Point(6, 233);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 35);
            panel1.TabIndex = 26;
            // 
            // btn_LuuHoaDon
            // 
            btn_LuuHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LuuHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_LuuHoaDon.Image = (Image)resources.GetObject("btn_LuuHoaDon.Image");
            btn_LuuHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_LuuHoaDon.Location = new Point(287, 3);
            btn_LuuHoaDon.Margin = new Padding(2, 2, 2, 2);
            btn_LuuHoaDon.Name = "btn_LuuHoaDon";
            btn_LuuHoaDon.Size = new Size(133, 29);
            btn_LuuHoaDon.TabIndex = 3;
            btn_LuuHoaDon.Text = "Lưu hoá đơn";
            btn_LuuHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btn_LuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_ThemSanPham
            // 
            btn_ThemSanPham.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThemSanPham.ForeColor = Color.FromArgb(0, 117, 214);
            btn_ThemSanPham.Image = (Image)resources.GetObject("btn_ThemSanPham.Image");
            btn_ThemSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemSanPham.Location = new Point(144, 3);
            btn_ThemSanPham.Margin = new Padding(2, 2, 2, 2);
            btn_ThemSanPham.Name = "btn_ThemSanPham";
            btn_ThemSanPham.Size = new Size(139, 29);
            btn_ThemSanPham.TabIndex = 2;
            btn_ThemSanPham.Text = "Thêm sản phẩm";
            btn_ThemSanPham.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemSanPham.UseVisualStyleBackColor = true;
            btn_ThemSanPham.Click += btn_ThemSanPham_Click;
            // 
            // btn_ThemHoaDon
            // 
            btn_ThemHoaDon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThemHoaDon.ForeColor = Color.FromArgb(0, 117, 214);
            btn_ThemHoaDon.Image = (Image)resources.GetObject("btn_ThemHoaDon.Image");
            btn_ThemHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemHoaDon.Location = new Point(4, 3);
            btn_ThemHoaDon.Margin = new Padding(2, 2, 2, 2);
            btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            btn_ThemHoaDon.Size = new Size(136, 29);
            btn_ThemHoaDon.TabIndex = 0;
            btn_ThemHoaDon.Text = "Thêm hoá đơn";
            btn_ThemHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemHoaDon.UseVisualStyleBackColor = true;
            btn_ThemHoaDon.Click += btn_ThemHoaDon_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_SoLuong);
            panel2.Controls.Add(txt_DonGia);
            panel2.Controls.Add(txt_ThanhTien);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbx_MaHang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txt_TenHang);
            panel2.Controls.Add(txt_GiamGia);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(6, 18);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 66);
            panel2.TabIndex = 27;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(94, 40);
            txt_SoLuong.Margin = new Padding(2, 2, 2, 2);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(150, 23);
            txt_SoLuong.TabIndex = 21;
            txt_SoLuong.TextChanged += txt_SoLuong_TextChanged;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(592, 13);
            txt_DonGia.Margin = new Padding(2, 2, 2, 2);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.ReadOnly = true;
            txt_DonGia.Size = new Size(150, 23);
            txt_DonGia.TabIndex = 24;
            // 
            // txt_ThanhTien
            // 
            txt_ThanhTien.Location = new Point(592, 38);
            txt_ThanhTien.Margin = new Padding(2, 2, 2, 2);
            txt_ThanhTien.Name = "txt_ThanhTien";
            txt_ThanhTien.ReadOnly = true;
            txt_ThanhTien.Size = new Size(150, 23);
            txt_ThanhTien.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 117, 214);
            label10.Location = new Point(507, 13);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 17;
            label10.Text = "Đơn giá:";
            // 
            // cbx_MaHang
            // 
            cbx_MaHang.FormattingEnabled = true;
            cbx_MaHang.Location = new Point(94, 10);
            cbx_MaHang.Margin = new Padding(2, 2, 2, 2);
            cbx_MaHang.Name = "cbx_MaHang";
            cbx_MaHang.Size = new Size(150, 23);
            cbx_MaHang.TabIndex = 10;
            cbx_MaHang.SelectedValueChanged += cbx_MaHang_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(21, 13);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 2;
            label6.Text = "Mã hàng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 117, 214);
            label11.Location = new Point(507, 40);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(79, 19);
            label11.TabIndex = 18;
            label11.Text = "Thành tiền:";
            // 
            // txt_TenHang
            // 
            txt_TenHang.Location = new Point(345, 11);
            txt_TenHang.Margin = new Padding(2, 2, 2, 2);
            txt_TenHang.Name = "txt_TenHang";
            txt_TenHang.ReadOnly = true;
            txt_TenHang.Size = new Size(150, 23);
            txt_TenHang.TabIndex = 22;
            // 
            // txt_GiamGia
            // 
            txt_GiamGia.Location = new Point(345, 38);
            txt_GiamGia.Margin = new Padding(2, 2, 2, 2);
            txt_GiamGia.Name = "txt_GiamGia";
            txt_GiamGia.Size = new Size(150, 23);
            txt_GiamGia.TabIndex = 23;
            txt_GiamGia.TextChanged += txt_GiamGia_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 117, 214);
            label7.Location = new Point(21, 40);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 11;
            label7.Text = "Số lượng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 117, 214);
            label9.Location = new Point(259, 40);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 14;
            label9.Text = "Giảm giá %:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 117, 214);
            label8.Location = new Point(259, 13);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 19);
            label8.TabIndex = 13;
            label8.Text = "Tên hàng:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 425);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(415, 427);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(56, 15);
            label14.TabIndex = 3;
            label14.Text = "Tìm kiếm";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 448);
            Controls.Add(label14);
            Controls.Add(textBox1);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrderForm";
            Text = "OrderForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_OrderDetailList).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_MaHoaDon;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private ComboBox cbx_MaHang;
        private Label label6;
        private TextBox txt_SoLuong;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txt_ThanhTien;
        private TextBox txt_DonGia;
        private TextBox txt_GiamGia;
        private TextBox txt_TenHang;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtg_OrderDetailList;
        private TextBox txt_TongTien;
        private Label label12;
        private Button btn_ThemHoaDon;
        private Button btn_LuuHoaDon;
        private Button btn_ThemSanPham;
        private Label label13;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox1;
        private Label label14;
    }
}