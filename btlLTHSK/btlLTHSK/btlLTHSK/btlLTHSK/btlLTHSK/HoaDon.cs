using btlLTHSK.Resources;
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

namespace btlLTHSK
{
    public partial class HoaDon : Form
    {
        ErrorProvider ErrorProvider = new ErrorProvider();
        QLHoaDon hoa_don = new QLHoaDon();
        double MaHD;
        string dNgayBan;
        string sMaNV;
        string sMaKH;
        double luu = 2;
        ChiTietHD chiTiet1 = new ChiTietHD();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            hoa_don.hien_HoaDon(dgv_HoaDon);
            upload_MaNV_Ban();
            upload_MaKH_Ban();
        }
        public double chuyen_MaHD()
        {
            return luu = MaHD;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Sua_HDMua_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            dgv_HoaDon.Rows.Clear();
            txt_MaHD_Validating(sender, luu);
            cb_MaNV_Validating(sender, luu);
            dateTimePicker1_NgayBan_Validating(sender, luu);
            DateTime dateTime_ngayvaolam = Convert.ToDateTime(dateTimePicker1_NgayBan.Text);
            string tgianBan = dateTime_ngayvaolam.ToString("yyyy/MM/dd");
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                hoa_don.update_HoaDon(MaHD, cb_MaNV.Text.ToString(), cb_MaKH.Text.ToString(), tgianBan);
                txt_MaHD.Text = string.Empty;
                cb_MaNV.Text = string.Empty;
                cb_MaKH.Text = string.Empty;
                dateTimePicker1_NgayBan.Text = string.Empty;
            }
            hoa_don.hien_HoaDon(dgv_HoaDon);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dgv_HoaDon.ClearSelection();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 3)
            {
                DataGridViewCell dataGridViewCell = dgv_HoaDon[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
                    txt_MaHD.Text = row.Cells[0].Value.ToString();
                    cb_MaNV.Text = row.Cells[1].Value.ToString();
                    cb_MaKH.Text = row.Cells[2].Value.ToString();                   
                    dateTimePicker1_NgayBan.Text = row.Cells[3].Value.ToString();
                }
            }
            else
            {
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];
                double we = double.Parse(row.Cells[0].Value.ToString());
                chiTiet1.onechoice = 1;
                chiTiet1.chi_tietHD_Mua_hien_theoMaHD(we);
                chiTiet1.ShowDialog();

            }
            dgv_HoaDon.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()))
            {
                ErrorProvider.SetError(cb_MaNV, "!");
            }
            else
            {
                ErrorProvider.SetError(cb_MaNV, null);
                // sMaNV = string.Parse(comboBox1_MaNV.Text); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
            {
                ErrorProvider.SetError(txt_MaHD, "!");
            }
            else
            {
                ErrorProvider.SetError(txt_MaHD, null);
                MaHD = double.Parse(txt_MaHD.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTime = Convert.ToDateTime(dateTimePicker1_NgayBan.Text);
            dNgayBan = dateTime.ToString("dd/MM/yyyy");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_MaKH.Text.Trim()))
            {
                ErrorProvider.SetError(cb_MaKH, "!");
            }
            else
            {
                ErrorProvider.SetError(cb_MaKH, null);
            }
        }

        private void button_ThemHD_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            dgv_HoaDon.Rows.Clear();
            //  textBox1_TextChanged(sender, luu);
            txt_MaHD_Validating(sender, luu);
            cb_MaNV_Validating(sender, luu);
            //  comboBox1_SelectedIndexChanged(sender, luu);
            comboBox2_SelectedIndexChanged(sender, luu);
            DateTime tgian= Convert.ToDateTime(dateTimePicker1_NgayBan.Text);
            string tgianBan = tgian.ToString("yyyy/MM/dd");
            bool them = hoa_don.ThemHoaDon(MaHD, cb_MaNV.Text.ToString(), cb_MaKH.Text.ToString(), tgianBan);
            if (them)
            {

                MessageBox.Show("Thêm thành công");
                // ErrorProvider.SetError(txt_MaHD, null);
                // đưa các ô nhập liệu về rỗng
                txt_MaHD.Text = string.Empty;
                cb_MaNV.Text = string.Empty;
                cb_MaKH.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

            hoa_don.hien_HoaDon(dgv_HoaDon);
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietHD chitietHD = new ChiTietHD();
            chitietHD.Show();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaHD.ResetText();
            cb_MaNV.ResetText();
            cb_MaKH.ResetText();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        public void upload_MaNV_Ban()
        {
            //comboBox1_MaNV.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblNhanVien";
                        cmd.CommandType = System.Data.CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                cb_MaNV.Items.Add(dataRow[0]);

                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }
        public void upload_MaKH_Ban()
        {
            //comboBox1_MaSP.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblDoiTac";
                        cmd.CommandType = System.Data.CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                cb_MaKH.Items.Add(dataRow[0]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            textBox1_TextChanged(sender, luu);

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                hoa_don.xoa_HoaDon(MaHD, sMaNV, sMaKH, dNgayBan);
                //h.xoa_HoaDon(MaHD, sMaKH, sMaNV,dNgayBan);
                txt_MaHD.Text = string.Empty;
                cb_MaNV.Text = string.Empty;
                dateTimePicker1_NgayBan.Text = string.Empty;
                hoa_don.ToString();
                dgv_HoaDon.Rows.Clear();
            }
            else
            { dgv_HoaDon.Rows.Clear(); }
            hoa_don.hien_HoaDon(dgv_HoaDon);
        }

        private void txt_MaHD_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
            {
                ErrorProvider.SetError(txt_MaHD, "!");
            }
            else
            {
                ErrorProvider.SetError(txt_MaHD, null);
                MaHD = double.Parse(txt_MaHD.Text);
            }
        }

        private void cb_MaNV_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()))
            {
                ErrorProvider.SetError(cb_MaNV, "!");
            }
            else
            {
                ErrorProvider.SetError(cb_MaNV, null);
            }
        }

        private void dateTimePicker1_NgayBan_Validating(object sender, CancelEventArgs e)
        {

            DateTime dateTime = Convert.ToDateTime(dateTimePicker1_NgayBan.Text);
            dNgayBan = dateTime.ToString("dd/MM/yyyy");
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Parse(dateTimePicker1_NgayBan.Text);
           
        }
        public double chuyen_MaHDMua()
        {
            return luu = MaHD;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chiTiet1.onechoice = 0;
            chiTiet1.ShowDialog();
        }
    }
}

