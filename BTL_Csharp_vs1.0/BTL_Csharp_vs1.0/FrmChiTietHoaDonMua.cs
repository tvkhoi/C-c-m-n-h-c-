using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Csharp_vs1._0
{
    public partial class FrmChiTietHoaDonMua : Form
    {
        public FrmChiTietHoaDonMua()
        {
            InitializeComponent();
        }
        public FrmChiTietHoaDonMua(string data)
        {
            InitializeComponent();
            txtCodeHD.Text = data;
        }

        private void FrmChiTietHoaDonMua_Load(object sender, EventArgs e)
        {
            hienChiTiet();
            LayDsSP();
            LaySize();
            LayColor();
        }
        private bool ktra()
        {
            if (txtCodeSP.Text == "" || txtTenSP.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("bạn phải nhập dữ liệu để thực hiện");
                return false;
            }
            else
            {
                if (int.Parse(txtSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Số Lượng Phải Lớn Hơn Hoặc Bằng 0");
                    return false;
                }
                else
                {
                    if (double.Parse(txtDonGia.Text) <= 0)
                    {
                        MessageBox.Show("Đơn Gía Lượng Phải Lớn Hơn Hoặc Bằng 0");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        private string LayMaTTSP(string maSP, string mau, string size)
        {
            string maTTSP = "";
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetMaTTSPFromMaSPMauSize", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@Mau", mau);
                    cmd.Parameters.AddWithValue("@Size", size);

                    conn.Open();
                    maTTSP = cmd.ExecuteScalar()?.ToString(); // Lấy sMaTTSP
                }
            }
            return maTTSP;
        }

        private void LaySize()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_Size ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        size.DataSource = tb;
                        size.DisplayMember = "sSize";


                    }
                }
            }

        }
        private void LayColor()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_Color ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        color.DataSource = tb;
                        color.DisplayMember = "sMau";


                    }
                }
            }

        }
        public void hienChiTiet()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_HienChiTietHDMuaTheoMa", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahd", txtCodeHD.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;


                    }
                }
            }
        }

        private void LayDsSP()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select TblSanPham.sMaSP from TblSanPham left join TblTTSP on TblSanPham.sMaSP = TblTTSP.sMaSP group by TblSanPham.sMaSP", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        txtCodeSP.DataSource = tb;
                        txtCodeSP.DisplayMember = "sMaSP";
                        txtCodeSP.ValueMember = "sMaSP";



                    }
                }
            }
        }
        private string LayTenSanPham(string MaSP)
        {
            string TenSP = "";
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sTenSP FROM TblSanPham WHERE sMaSP = @MaSP ", conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", MaSP);
                    conn.Open();
                    TenSP = cmd.ExecuteScalar()?.ToString(); // Lấy tên sản phẩm
                }
            }
            return TenSP;
        }

        private void txtCodeSP_TextChanged(object sender, EventArgs e)
        {
            string MaSP = txtCodeSP.Text;
            string TenSP = LayTenSanPham(MaSP);
            txtTenSP.Text = TenSP;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodeSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTenSP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            color.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            size.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodeSP.Text = row.Cells[1].Value.ToString();
                txtTenSP.Text = row.Cells[2].Value.ToString();
                color.Text = row.Cells[3].Value.ToString();
                size.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                txtDonGia.Text = row.Cells[6].Value.ToString();
            }
        }
        public void insertCTHoaDonNhap()
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ThemChiTietHDMua", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (txtCodeSP.Text == "" || txtTenSP.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
                        {
                            MessageBox.Show("Bạn phải nhập dữ liệu để thực hiện");
                            return;
                        }

                        string maTTSP = LayMaTTSP(txtCodeSP.Text, color.Text, size.Text);
                        if (string.IsNullOrEmpty(maTTSP))
                        {
                            MessageBox.Show("Không tìm thấy mã TTSP tương ứng");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@MaHDMua", txtCodeHD.Text);
                        cmd.Parameters.AddWithValue("@MaTTSp", maTTSP);
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                        cmd.Parameters.AddWithValue("@DonGiaBan", double.Parse(txtDonGia.Text));

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm Hóa Đơn thành công");
                            hienChiTiet();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Hóa Đơn thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // kiểm tra khóa

        public static bool kiemtra2Key(string Key1, string Key2, string TableName, string NameColumnKey1, string NameColumnKey2)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            string KiemTraPK = "SELECT * FROM " + TableName + " WHERE " + NameColumnKey1 + "= '" + Key1 + "' and " + NameColumnKey2 + "= '" + Key2 + "'";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(KiemTraPK, conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
        }



        public void xoaCTHDNhap()
        {
            string maHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string maTTSP = LayMaTTSP(txtCodeSP.Text, color.Text, size.Text);
            bool i = kiemtra2Key(Key1: txtCodeHD.Text, Key2: maTTSP, TableName: "TblChiTietHdNhap", NameColumnKey1: "iMaHDNhap", NameColumnKey2: "sMaTTSP");
            if (i == true)
            {
                MessageBox.Show("Mã Hóa Đơn Bạn Muốn Xóa Không Tồn Tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Hóa Đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
                try
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_XoaChiTietHDMua", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaHD", txtCodeHD.Text);
                            cmd.Parameters.AddWithValue("@MaTTSP", maTTSP);


                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa Hóa Đơn Nhập thành công");
                                hienChiTiet();
                            }
                            else
                            {
                                MessageBox.Show("Xóa Hóa Đơn Nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // sửa
        private void suaHDNhap(string maHDNhap, string maTTSPMoi, string maTTSPCu, string soLuong, string donGia)
        {
            string constr = ConfigurationManager.ConnectionStrings["DataBase_BTL_CSharp_1"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaChiTietHDNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaHDMua", maHDNhap);
                        cmd.Parameters.AddWithValue("@MaTTSpMoi", maTTSPMoi);
                        cmd.Parameters.AddWithValue("@MaTTSpCu", maTTSPCu);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DonGiaBan", donGia);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật CT Hóa Đơn Nhập thành công");
                            hienChiTiet();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật CT Hóa Đơn Nhập thất bại");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdat_Click(object sender, EventArgs e)
        {
            bool isValid = ktra();
            if (isValid)
            {
                string MaSPCu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string MauCu = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string SizeCu = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                string maTTSPCu = LayMaTTSP(MaSPCu, MauCu, SizeCu);

                string MaSPMoi = txtCodeSP.Text;
                string mauMoi = color.Text;
                string kichthuocMoi = size.Text;

                string maTTSPMoi = LayMaTTSP(MaSPMoi, mauMoi, kichthuocMoi);

                string soLuong = txtSoLuong.Text;
                string donGia = txtDonGia.Text;

                bool i = kiemtra2Key(Key1: txtCodeHD.Text, Key2: maTTSPMoi, TableName: "TblChiTietHdNhap", NameColumnKey1: "iMaHDNhap", NameColumnKey2: "sMaTTSP");
                if (i == false)
                {

                    MessageBox.Show("Sản Phẩm này đã tồn tại trong Hóa đơn");
                    return;
                }

                suaHDNhap(txtCodeHD.Text, maTTSPMoi, maTTSPCu, soLuong, donGia);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            insertCTHoaDonNhap();
            FrmChiTietHoaDonMua frmHoaDonNhap = new FrmChiTietHoaDonMua();
            frmHoaDonNhap.hienChiTiet();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            xoaCTHDNhap();
        }
    }
}
