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
    public partial class ChiTietNhap : Form
    {
        ErrorProvider error = new ErrorProvider();
        ChiTietNhapcs01 chitietPN = new ChiTietNhapcs01();
        double Soluong = 0;
        double Gia = 0;
        double MaPN = 0;
        double b=0;
        public double onechoice = 0;

        public ChiTietNhap()
        {
            InitializeComponent();
        }
        public void texts()
        {
            MessageBox.Show("ịui");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MHDNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()))
            {
                error.SetError(textBox_MaHDNhap, "!");
            }
            else
            {
                error.SetError(textBox_MaHDNhap, null);
                MaPN = double.Parse(textBox_MaHDNhap.Text);
            }
        }

        private void comboBox_maSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tblLapTop";
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
                            if (comboBox_maSP.Text == dataRow[0].ToString())
                            {
                                textBox_tenSP.Text = dataRow[1].ToString();
                            }
                       
                        }
                    }
                }
            }

        }
           

        private void textBox_tenSP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_tenSP.Text.Trim()))
            {
                error.SetError(textBox_tenSP, "Tên nhân viên không được để trống!");
            }
            else
            {
                error.SetError(textBox_tenSP, null);
            }
        }



        private void textBox_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()))
            {
                error.SetError(textBox_SoLuong, "Không được để trống !");
            }
            else
            {
                error.SetError(textBox_SoLuong, null);
                Soluong = double.Parse(textBox_SoLuong.Text);
            }
        }

        private void textBox_Gia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {
                error.SetError(textBox_Gia, "Không được để trống !");
            }
            else
            {
                error.SetError(textBox_Gia, null);
                Gia = double.Parse(textBox_Gia.Text.Replace(".", ""));
            }
        }

        private void comboBox_maSP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_maSP.Text.Trim()))
            {
                error.SetError(comboBox_maSP, "Không được để trống !");
            }
            else
            {
                error.SetError(comboBox_maSP, null);
            }
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
           
            CancelEventArgs luu = new CancelEventArgs();
            dataGridView_HDNhap.Rows.Clear();
            textBox_tenSP_Validating(sender, luu);
            comboBox_maSP_Validating(sender, luu);
            textBox_Gia_Validating(sender, luu);
            textBox_SoLuong_Validating(sender, luu);
            textBox_MHDNhap_Validating(sender, luu);

            bool them = chitietPN.them_ChiTiet_PhieuNhap(MaPN, comboBox_maSP.Text.ToString(),
                textBox_tenSP.Text.ToString(), Soluong, Gia);
            if (them)
            {

                MessageBox.Show("Thêm thành công");
                error.SetError(textBox_MaHDNhap, null);
                // đưa các ô nhập liệu về rỗng
                textBox_MaHDNhap.Text = string.Empty;
                comboBox_maSP.Text = string.Empty;
                textBox_tenSP.Text = string.Empty;
                textBox_Gia.Text = string.Empty;
                textBox_SoLuong.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Không thành công");
            }


            chon_hien_PhieuNhap(onechoice);
            upload_MaSP();
        }

        public void chon_hien_PhieuNhap(double chon)
        {
            if(chon == 0)
            { 
                chitietPN.hien_ChiTietPN(dataGridView_HDNhap, comboBox_maSP.Text.ToString(), textBox_tenSP.Text.ToString());
            }
            else  hien_ChiTietPN_theoMa(b);
        }


        //          ------Nút Sửa-----------
        private void button_Sua_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            textBox_tenSP_Validating(sender, luu);
            comboBox_maSP_Validating(sender, luu);
            textBox_Gia_Validating(sender, luu);
            textBox_SoLuong_Validating(sender, luu);
            textBox_MHDNhap_Validating(sender, luu);
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("đã sửa thành công");
            chitietPN.update_ChiTiet_PhieuNhap(MaPN, comboBox_maSP.Text.ToString(),
                textBox_tenSP.Text.ToString(), Soluong, Gia);

            textBox_MaHDNhap.Text = string.Empty;
            textBox_tenSP.Text = string.Empty;
            textBox_SoLuong.Text = string.Empty;
            comboBox_maSP.Text = string.Empty;
            textBox_Gia.Text = string.Empty;
            dataGridView_HDNhap.Rows.Clear();
            chon_hien_PhieuNhap(onechoice);
            upload_MaSP();

            }
            
           
        }

        private void ChiTietNhap_Load(object sender, EventArgs e)
        {
            dataGridView_HDNhap.Rows.Clear ();
            chon_hien_PhieuNhap(onechoice);
            upload_MaSP();
            
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) && !string.IsNullOrEmpty(comboBox_maSP.Text.Trim())
               && !string.IsNullOrEmpty(textBox_SoLuong.Text.Trim()) && !string.IsNullOrEmpty(textBox_Gia.Text.Trim()))
            {

                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Đã xóa thành công !");
                    chitietPN.xoa_ChiTiet_PhieuNHap(MaPN, comboBox_maSP.Text.ToString(), textBox_tenSP.Text.ToString()
                , Soluong, Gia);
                    // đưa các ô nhập liệu về rỗng
                    textBox_MaHDNhap.Text = string.Empty;
                    comboBox_maSP.Text = string.Empty;
                    textBox_SoLuong.Text = string.Empty;
                    textBox_Gia.Text = string.Empty;
                    textBox_tenSP.Text = string.Empty;
                    dataGridView_HDNhap.Rows.Clear();

                    chon_hien_PhieuNhap(onechoice);
                    upload_MaSP();
                }
                else
                {
                    // đóng
                }
            }
        }
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
      
        public void upload_MaSP()
        {
            comboBox_maSP.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblLapTop";
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
                                comboBox_maSP.Items.Add(dataRow[0]);                                                             
                               
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

        private void comboBox_maSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_HDNhap_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_HDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_HDNhap.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_HDNhap[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dataGridView_HDNhap.Rows[e.RowIndex];
                    textBox_MaHDNhap.Text = row.Cells[0].Value.ToString();
                    comboBox_maSP.Text = row.Cells[1].Value.ToString();
                    textBox_tenSP.Text = row.Cells[2].Value.ToString();
                    textBox_SoLuong.Text = row.Cells[3].Value.ToString();
                    textBox_Gia.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
        }

       
        private void pictureBox_Nut_quaylai_Click(object sender, EventArgs e)
        {

        }
        //chèn dữ liệu
        public void hien_ChiTietPN_theoMa(double MaHD)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tblChiTietHDNhapHang";
                        cmd.CommandType = System.Data.CommandType.Text;
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                           
                           
                            dataGridView_HDNhap.Rows.Clear();
                            foreach (DataRow dataRow in dataTable.Rows)
                            {    double a= double.Parse(dataRow[0].ToString());
                                b = MaHD;

                                if(a == MaHD) {
                                
                                   DataGridViewRow row = new DataGridViewRow();
                                   row.CreateCells(dataGridView_HDNhap);
                                   row.Cells[0].Value = dataRow[0].ToString();
                                   row.Cells[1].Value = dataRow[1].ToString();
                                   using (SqlCommand cmds = conn.CreateCommand())
                                   {

                                    cmds.CommandText = "lay_TenSP";
                                    cmds.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmds.Parameters.AddWithValue("@MaSP", row.Cells[1].Value.ToString());
                                    cmds.Parameters.Add("@isExisting", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;

                                    cmds.ExecuteNonQuery();
                                    string i = Convert.ToString(cmds.Parameters["@isExisting"].Value);

                                    row.Cells[2].Value = i;
                                   }
                                   row.Cells[3].Value = dataRow[2].ToString();
                                   row.Cells[4].Value = dataRow[3].ToString();
                                   dataGridView_HDNhap.Rows.Add(row);

                                }
                           
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
    }
}
