using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QyanLyNhanSuNew
{
    public partial class Menu : Form
    {




        frmSuaXoa frmsuaxoa = new frmSuaXoa();
        frmThem frmthem = new frmThem();
        frmThongKeChuyenMon frmtkcm = new frmThongKeChuyenMon();
        frmThongKeThuNhap frmtktn = new frmThongKeThuNhap();
        frmThongTin frmtt = new frmThongTin();



        public Menu()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmthem.ShowDialog();
        }

        private void sửaXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsuaxoa.ShowDialog();
        }

      

        private void thuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtktn.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine("G:\\QuanLyNhanSuNew\\huongdan.htm"));
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtt.ShowDialog();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkcm.ShowDialog();
        }
        /////////////

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");

        private void LoadData() //hien hti du lieu len cac o textbox
        {



            SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            danh_sachdataGridView1.DataSource = dt;

            //xoa trang cac o textbox
            txtHoTen.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();
            txtChuyenMon.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtPhongBan.DataBindings.Clear();
            txtQueQuan.DataBindings.Clear();
            txtTonGiao.DataBindings.Clear();
            txtTrinhDo.DataBindings.Clear();
            txtGioiTinh.DataBindings.Clear();
            mtxtNgaySinh.DataBindings.Clear();
            pbAnh.DataBindings.Clear();

            //hine thi du lieu len
            txtDiaChi.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "diachi");
            txtHoTen.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten");
            txtPhongBan.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten1");
            txtQueQuan.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "quequan");
            txtTonGiao.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tongiao");
            txtTrinhDo.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tentrinhdo");

            txtChuyenMon.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "tenchuyenmon");
            txtChucVu.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ten2");
            txtGioiTinh.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "gioitinh");

            //maskedtextbox
            
            mtxtNgaySinh.Mask = "00/00/0000";
            mtxtNgaySinh.DataBindings.Add("Text", danh_sachdataGridView1.DataSource, "ngaysinh");

            //picturebox
            pbAnh.DataBindings.Add(new Binding("Image", danh_sachdataGridView1.DataSource, "anh", true));

        }



             
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

            
            LoadData();
        }

        private void cboTimKiem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cboTimKiem.Text == "Tìm theo tên")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }
            else if (cboTimKiem.Text == "Tìm theo địa chỉ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.diachi LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;

                LoadData();
            }
            else if (cboTimKiem.Text == "Tìm theo phòng ban")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE phongban.ten LIKE %N'" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

            else if (cboTimKiem.Text == "Tìm theo chức vụ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE chucvu.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (cboTimKiem.Text == "Tìm theo tên")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;

                LoadData();
            }
            else if (cboTimKiem.Text == "Tìm theo địa chỉ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE nv.diachi LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }
            else if (cboTimKiem.Text == "Tìm theo phòng ban")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE phongban.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

            else if (cboTimKiem.Text == "Tìm theo chức vụ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh FROM nhanvien nv INNER JOIN phongban  ON nv.phongbanma = phongban.ma INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma WHERE chucvu.ten LIKE N'%" + txtTimKiem.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                danh_sachdataGridView1.DataSource = dt;
                LoadData();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
