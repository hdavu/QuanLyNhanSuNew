namespace QyanLyNhanSuNew
{
    partial class frmThongKeChuyenMon
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChucvu = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet = new QyanLyNhanSuNew.QuanLyNhanSuDataSet();
            this.chuyenmonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChuyenmon = new System.Windows.Forms.ComboBox();
            this.chuyenmonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboPhongban = new System.Windows.Forms.ComboBox();
            this.phongbanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinhdoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTrinhdo = new System.Windows.Forms.ComboBox();
            this.trinhdoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboThongke = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongbanTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter();
            this.chuyenmonTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter();
            this.trinhdoTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter();
            this.chucvuTableAdapter = new QyanLyNhanSuNew.QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(55, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            // 
            // cboChucvu
            // 
            this.cboChucvu.DataSource = this.chucvuBindingSource1;
            this.cboChucvu.DisplayMember = "ten";
            this.cboChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucvu.Enabled = false;
            this.cboChucvu.FormattingEnabled = true;
            this.cboChucvu.Location = new System.Drawing.Point(364, 318);
            this.cboChucvu.Name = "cboChucvu";
            this.cboChucvu.Size = new System.Drawing.Size(181, 21);
            this.cboChucvu.TabIndex = 8;
            this.cboChucvu.ValueMember = "ma";
            this.cboChucvu.SelectedIndexChanged += new System.EventHandler(this.cboChucvu_SelectedIndexChanged);
            // 
            // chucvuBindingSource1
            // 
            this.chucvuBindingSource1.DataMember = "chucvu";
            this.chucvuBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenmonBindingSource
            // 
            this.chuyenmonBindingSource.DataMember = "chuyenmon";
            // 
            // cboChuyenmon
            // 
            this.cboChuyenmon.DataSource = this.chuyenmonBindingSource1;
            this.cboChuyenmon.DisplayMember = "tenchuyenmon";
            this.cboChuyenmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenmon.Enabled = false;
            this.cboChuyenmon.FormattingEnabled = true;
            this.cboChuyenmon.Location = new System.Drawing.Point(364, 264);
            this.cboChuyenmon.Name = "cboChuyenmon";
            this.cboChuyenmon.Size = new System.Drawing.Size(181, 21);
            this.cboChuyenmon.TabIndex = 9;
            this.cboChuyenmon.ValueMember = "ma";
            this.cboChuyenmon.SelectedIndexChanged += new System.EventHandler(this.cboChuyenmon_SelectedIndexChanged);
            // 
            // chuyenmonBindingSource1
            // 
            this.chuyenmonBindingSource1.DataMember = "chuyenmon";
            this.chuyenmonBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // cboPhongban
            // 
            this.cboPhongban.DataSource = this.phongbanBindingSource1;
            this.cboPhongban.DisplayMember = "ten";
            this.cboPhongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongban.Enabled = false;
            this.cboPhongban.FormattingEnabled = true;
            this.cboPhongban.Location = new System.Drawing.Point(364, 237);
            this.cboPhongban.Name = "cboPhongban";
            this.cboPhongban.Size = new System.Drawing.Size(181, 21);
            this.cboPhongban.TabIndex = 10;
            this.cboPhongban.ValueMember = "ma";
            this.cboPhongban.SelectedIndexChanged += new System.EventHandler(this.cboPhongban_SelectedIndexChanged);
            // 
            // phongbanBindingSource1
            // 
            this.phongbanBindingSource1.DataMember = "phongban";
            this.phongbanBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // phongbanBindingSource
            // 
            this.phongbanBindingSource.DataMember = "phongban";
            // 
            // trinhdoBindingSource
            // 
            this.trinhdoBindingSource.DataMember = "trinhdo";
            // 
            // cboTrinhdo
            // 
            this.cboTrinhdo.DataSource = this.trinhdoBindingSource1;
            this.cboTrinhdo.DisplayMember = "tentrinhdo";
            this.cboTrinhdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrinhdo.Enabled = false;
            this.cboTrinhdo.Location = new System.Drawing.Point(364, 291);
            this.cboTrinhdo.Name = "cboTrinhdo";
            this.cboTrinhdo.Size = new System.Drawing.Size(181, 21);
            this.cboTrinhdo.TabIndex = 11;
            this.cboTrinhdo.ValueMember = "ma";
            this.cboTrinhdo.SelectedIndexChanged += new System.EventHandler(this.cboTrinhdo_SelectedIndexChanged);
            // 
            // trinhdoBindingSource1
            // 
            this.trinhdoBindingSource1.DataMember = "trinhdo";
            this.trinhdoBindingSource1.DataSource = this.quanLyNhanSuDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống kê theo:";
            // 
            // cboThongke
            // 
            this.cboThongke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongke.Items.AddRange(new object[] {
            "Phòng ban",
            "Chuyên môn",
            "Trình độ",
            "Chức vụ"});
            this.cboThongke.Location = new System.Drawing.Point(138, 237);
            this.cboThongke.Name = "cboThongke";
            this.cboThongke.Size = new System.Drawing.Size(168, 21);
            this.cboThongke.TabIndex = 6;
            this.cboThongke.SelectedIndexChanged += new System.EventHandler(this.cboThongke_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 203);
            this.dataGridView1.TabIndex = 5;
            // 
            // quanLyNhanSuDataSetBindingSource
            // 
            this.quanLyNhanSuDataSetBindingSource.DataSource = this.quanLyNhanSuDataSet;
            this.quanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // phongbanTableAdapter
            // 
            this.phongbanTableAdapter.ClearBeforeFill = true;
            // 
            // chuyenmonTableAdapter
            // 
            this.chuyenmonTableAdapter.ClearBeforeFill = true;
            // 
            // trinhdoTableAdapter
            // 
            this.trinhdoTableAdapter.ClearBeforeFill = true;
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboChucvu);
            this.Controls.Add(this.cboChuyenmon);
            this.Controls.Add(this.cboPhongban);
            this.Controls.Add(this.cboTrinhdo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboThongke);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThongKeChuyenMon";
            this.Text = "Thong Ke Chuyen Mon";
            this.Load += new System.EventHandler(this.frmThongKeChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenmonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongbanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhdoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private System.Windows.Forms.ComboBox cboChucvu;
        private System.Windows.Forms.BindingSource chuyenmonBindingSource;
        private System.Windows.Forms.ComboBox cboChuyenmon;
        private System.Windows.Forms.ComboBox cboPhongban;
        private System.Windows.Forms.BindingSource phongbanBindingSource;
        private System.Windows.Forms.BindingSource trinhdoBindingSource;
        private System.Windows.Forms.ComboBox cboTrinhdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThongke;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSetBindingSource;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private System.Windows.Forms.BindingSource phongbanBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.phongbanTableAdapter phongbanTableAdapter;
        private System.Windows.Forms.BindingSource chuyenmonBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.chuyenmonTableAdapter chuyenmonTableAdapter;
        private System.Windows.Forms.BindingSource trinhdoBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.trinhdoTableAdapter trinhdoTableAdapter;
        private System.Windows.Forms.BindingSource chucvuBindingSource1;
        private QuanLyNhanSuDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
    }
}