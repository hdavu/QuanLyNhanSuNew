﻿namespace QyanLyNhanSuNew
{
    partial class frmSuaXoa
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpAnh = new System.Windows.Forms.GroupBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.grpThongtin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.labMa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboTrinhdo = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboChuyenmon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTongiao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDantoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhsach = new System.Windows.Forms.DataGridView();
            this.quanLyNhanSuDataSet = new QyanLyNhanSuNew.QuanLyNhanSuDataSet();
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucvuTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter();
            this.quanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenmonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chuyenmonTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter();
            this.trinhdoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinhdoTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.grpAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.grpThongtin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpAnh);
            this.groupBox1.Controls.Add(this.grpThongtin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // grpAnh
            // 
            this.grpAnh.Controls.Add(this.btnAnh);
            this.grpAnh.Controls.Add(this.pbAnh);
            this.grpAnh.Location = new System.Drawing.Point(11, 17);
            this.grpAnh.Name = "grpAnh";
            this.grpAnh.Size = new System.Drawing.Size(200, 259);
            this.grpAnh.TabIndex = 14;
            this.grpAnh.TabStop = false;
            this.grpAnh.Text = "Ảnh";
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(56, 215);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 23);
            this.btnAnh.TabIndex = 1;
            this.btnAnh.Text = "Chọn ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(15, 19);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(168, 171);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            this.pbAnh.Click += new System.EventHandler(this.pbAnh_Click);
            // 
            // grpThongtin
            // 
            this.grpThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongtin.Controls.Add(this.btnXoa);
            this.grpThongtin.Controls.Add(this.txtMa);
            this.grpThongtin.Controls.Add(this.labMa);
            this.grpThongtin.Controls.Add(this.label1);
            this.grpThongtin.Controls.Add(this.cboGioitinh);
            this.grpThongtin.Controls.Add(this.btnSua);
            this.grpThongtin.Controls.Add(this.cboTrinhdo);
            this.grpThongtin.Controls.Add(this.btnThoat);
            this.grpThongtin.Controls.Add(this.cboChuyenmon);
            this.grpThongtin.Controls.Add(this.label6);
            this.grpThongtin.Controls.Add(this.cboChucvu);
            this.grpThongtin.Controls.Add(this.label2);
            this.grpThongtin.Controls.Add(this.cboPhongban);
            this.grpThongtin.Controls.Add(this.label7);
            this.grpThongtin.Controls.Add(this.dtpNgaysinh);
            this.grpThongtin.Controls.Add(this.label3);
            this.grpThongtin.Controls.Add(this.cboTongiao);
            this.grpThongtin.Controls.Add(this.label8);
            this.grpThongtin.Controls.Add(this.label11);
            this.grpThongtin.Controls.Add(this.label4);
            this.grpThongtin.Controls.Add(this.txtDantoc);
            this.grpThongtin.Controls.Add(this.label9);
            this.grpThongtin.Controls.Add(this.txtDiachi);
            this.grpThongtin.Controls.Add(this.label5);
            this.grpThongtin.Controls.Add(this.txtQuequan);
            this.grpThongtin.Controls.Add(this.label10);
            this.grpThongtin.Controls.Add(this.txtHoten);
            this.grpThongtin.Location = new System.Drawing.Point(217, 17);
            this.grpThongtin.Name = "grpThongtin";
            this.grpThongtin.Size = new System.Drawing.Size(615, 259);
            this.grpThongtin.TabIndex = 13;
            this.grpThongtin.TabStop = false;
            this.grpThongtin.Text = "Thông tin";
            this.grpThongtin.Enter += new System.EventHandler(this.grpThongtin_Enter);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(428, 228);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(80, 20);
            this.txtMa.TabIndex = 38;
            // 
            // labMa
            // 
            this.labMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labMa.Location = new System.Drawing.Point(334, 227);
            this.labMa.Name = "labMa";
            this.labMa.Size = new System.Drawing.Size(88, 24);
            this.labMa.TabIndex = 37;
            this.labMa.Text = "Mã";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ tên";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(106, 76);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(165, 21);
            this.cboGioitinh.TabIndex = 36;
            this.cboGioitinh.SelectedIndexChanged += new System.EventHandler(this.cboGioitinh_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(197, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTrinhdo
            // 
            this.cboTrinhdo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTrinhdo.DataSource = this.trinhdoBindingSource;
            this.cboTrinhdo.DisplayMember = "tentrinhdo";
            this.cboTrinhdo.FormattingEnabled = true;
            this.cboTrinhdo.Location = new System.Drawing.Point(428, 187);
            this.cboTrinhdo.Name = "cboTrinhdo";
            this.cboTrinhdo.Size = new System.Drawing.Size(170, 21);
            this.cboTrinhdo.TabIndex = 35;
            this.cboTrinhdo.ValueMember = "ma";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Location = new System.Drawing.Point(479, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboChuyenmon
            // 
            this.cboChuyenmon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChuyenmon.DataSource = this.chuyenmonBindingSource;
            this.cboChuyenmon.DisplayMember = "tenchuyenmon";
            this.cboChuyenmon.FormattingEnabled = true;
            this.cboChuyenmon.Location = new System.Drawing.Point(428, 143);
            this.cboChuyenmon.Name = "cboChuyenmon";
            this.cboChuyenmon.Size = new System.Drawing.Size(170, 21);
            this.cboChuyenmon.TabIndex = 34;
            this.cboChuyenmon.ValueMember = "ma";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(330, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quê quán";
            // 
            // cboChucvu
            // 
            this.cboChucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChucvu.DataSource = this.chucvuBindingSource;
            this.cboChucvu.DisplayMember = "ten";
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(428, 110);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(170, 21);
            this.cboChucvu.TabIndex = 33;
            this.cboChucvu.ValueMember = "ma";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Giới tính";
            // 
            // cboPhongban
            // 
            this.cboPhongban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboPhongban.DataSource = this.phongbanBindingSource;
            this.cboPhongban.DisplayMember = "ten";
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(428, 76);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(170, 21);
            this.cboPhongban.TabIndex = 32;
            this.cboPhongban.ValueMember = "ma";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(330, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phòng ban";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(105, 110);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(166, 20);
            this.dtpNgaysinh.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày sinh";
            // 
            // cboTongiao
            // 
            this.cboTongiao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTongiao.FormattingEnabled = true;
            this.cboTongiao.Items.AddRange(new object[] {
            "Không tôn giáo",
            "Phật giáo",
            "Công giáo",
            "Hào hảo",
            "Cao đài",
            "Tin lành",
            "Khác"});
            this.cboTongiao.Location = new System.Drawing.Point(104, 228);
            this.cboTongiao.Name = "cboTongiao";
            this.cboTongiao.Size = new System.Drawing.Size(167, 21);
            this.cboTongiao.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(330, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Chức vụ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(16, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tôn giáo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDantoc
            // 
            this.txtDantoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDantoc.Location = new System.Drawing.Point(105, 188);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.Size = new System.Drawing.Size(167, 20);
            this.txtDantoc.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(330, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "Chuyên môn";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachi.Location = new System.Drawing.Point(105, 144);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(167, 20);
            this.txtDiachi.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(16, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dân tộc";
            // 
            // txtQuequan
            // 
            this.txtQuequan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuequan.Location = new System.Drawing.Point(428, 43);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(170, 20);
            this.txtQuequan.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(330, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 33);
            this.label10.TabIndex = 23;
            this.label10.Text = "Trình độ";
            // 
            // txtHoten
            // 
            this.txtHoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoten.Location = new System.Drawing.Point(105, 43);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(167, 20);
            this.txtHoten.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhsach);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dgvDanhsach
            // 
            this.dgvDanhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsach.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhsach.Name = "dgvDanhsach";
            this.dgvDanhsach.Size = new System.Drawing.Size(837, 146);
            this.dgvDanhsach.TabIndex = 1;
            this.dgvDanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellClick);
            this.dgvDanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsach_CellContentClick);
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "phongban";
            this.phongbanBindingSource.DataSource = this.quanLyNhanSuDataSet;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            this.chucvuBindingSource.DataSource = this.quanLyNhanSuDataSet;
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyNhanSuDataSetBindingSource
            // 
            this.quanLyNhanSuDataSetBindingSource.DataSource = this.quanLyNhanSuDataSet;
            this.quanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // chuyenmonBindingSource
            // 
            this.chuyenmonBindingSource.DataMember = "chuyenmon";
            this.chuyenmonBindingSource.DataSource = this.quanLyNhanSuDataSet;
            // 
            // chuyenmonTableAdapter
            // 
            this.chuyenmonTableAdapter.ClearBeforeFill = true;
            // 
            // trinhdoBindingSource
            // 
            this.trinhdoBindingSource.DataMember = "trinhdo";
            this.trinhdoBindingSource.DataSource = this.quanLyNhanSuDataSet;
            // 
            // trinhdoTableAdapter
            // 
            this.trinhdoTableAdapter.ClearBeforeFill = true;
            // 
            // frmSuaXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSuaXoa";
            this.Text = "Sua Xoa";
            this.Load += new System.EventHandler(this.frmSuaXoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.grpThongtin.ResumeLayout(false);
            this.grpThongtin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpAnh;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.GroupBox grpThongtin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label labMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboTrinhdo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboChuyenmon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTongiao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDantoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhsach;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter phongbanTableAdapter;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSetBindingSource;
        private System.Windows.Forms.BindingSource chuyenmonBindingSource;
        private QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter chuyenmonTableAdapter;
        private System.Windows.Forms.BindingSource trinhdoBindingSource;
        private QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter trinhdoTableAdapter;
    }
}