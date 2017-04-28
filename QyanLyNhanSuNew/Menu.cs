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




        frmHuongDan frmhuongdan = new frmHuongDan();
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
            frmhuongdan.ShowDialog();
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
        DataSet ds = new DataSet();




        public void KetNoiCSDL()
        {

            string sql = " SELECT nv.ma, nv.ten, nv.ngaysinh, nv.quequan, nv.tongiao,nv.diachi, (CASE nv.gioitinh WHEN 'true' THEN N'Nam' WHEN 'false' THEN N'Nữ' END) as gioitinh , phongban.ten , trinhdo.tentrinhdo, chuyenmon.tenchuyenmon, chucvu.ten , nv.anh"
                           + " FROM nhanvien nv"
                           + " INNER JOIN phongban  ON nv.phongbanma = phongban.ma"
                           + " INNER JOIN trinhdo   ON nv.trinhdoma = trinhdo.ma"
                           + " INNER JOIN chuyenmon ON nv.chuyenmonma = chuyenmon.ma"
                           + " INNER JOIN  chucvu   ON nv.chucvuma = chucvu.ma";



            con.Open();
            {
                SqlCommand com = new SqlCommand(sql, con);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);
            }
            con.Close();

            danh_sachdataGridView1.DataSource = ds.Tables[0].DefaultView;
            danh_sachdataGridView1.Columns["ten1"].HeaderText = "Phòng ban";
            danh_sachdataGridView1.Columns["tentrinhdo"].HeaderText = "Trình độ";
            danh_sachdataGridView1.Columns["tenchuyenmon"].HeaderText = "Chuyên môn";
            danh_sachdataGridView1.Columns["ten2"].HeaderText = "Chức vụ";
            danh_sachdataGridView1.Columns["anh"].Visible = false;
            danh_sachdataGridView1.Columns["ma"].Visible = false;

        }

           


        private void LoadData() //hien hti du lieu len cac o textbox
        {

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

            KetNoiCSDL();
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
    }
}
