using btlLTHSK.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class HDNhapHang : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
        ErrorProvider errorProvider=new ErrorProvider();
  
        XuatHDNhapall xuatHD=new XuatHDNhapall();
        HoadonNhapcs01 hoadons=new HoadonNhapcs01();
        double MaHDNhap;
        string NgayNhap;
        ChiTietNhap chiTiet=new ChiTietNhap();
        double luu=2;
        public HDNhapHang()
            
        {
            InitializeComponent();
        }
        public double chuyen_MaHD()
        {
            return luu = MaHDNhap;
        }
      
        private void textBox_MaHDNhap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()))
            {
                errorProvider.SetError(textBox_MaHDNhap, "!");
            }
            else
            {
                errorProvider.SetError(textBox_MaHDNhap, null);
                MaHDNhap = double.Parse(textBox_MaHDNhap.Text);
            }
        }

        
        private void comboBox_MaNV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_MaNV.Text.Trim()))
            {
                errorProvider.SetError(comboBox_MaNV, "!");
            }
            else
            {
                errorProvider.SetError(comboBox_MaNV, null);              
            }
        }
      
        private void comboBox_NhaCC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {
                errorProvider.SetError(comboBox_NhaCC, "!");
            }
            else
            {
                errorProvider.SetError(comboBox_NhaCC, null);
                
            }
        }

       
        private void HDNhapHang_Load(object sender, EventArgs e)
        {
            hoadons.hien_HoaDonPN(dataGridView_HoaDonPN);
            uploadMaNV();
         

        } 
        
        private void button_Them_Click(object sender, EventArgs e)
        {           
            CancelEventArgs luu = new CancelEventArgs();
            dataGridView_HoaDonPN.Rows.Clear();
            comboBox_NhaCC_Validating(sender, luu);
            comboBox_MaNV_Validating(sender, luu);
            textBox_MaHDNhap_Validating(sender, luu);
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) && !string.IsNullOrEmpty(comboBox_MaNV.Text.Trim())
                && !string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {      // string NgayNhap = dateTime.ToString("yyyy/MM/dd");
                bool them = hoadons.them_HoaDon_PhieuNhap(MaHDNhap, comboBox_MaNV.Text.ToString(), comboBox_NhaCC.Text.ToString(), NgayNhap);
                if (them)
                {
                    MessageBox.Show("Thêm thành công");
                    errorProvider.SetError(textBox_MaHDNhap, null);
                    // đưa các ô nhập liệu về rỗng
                    refech_HD_Nhap();                   

                }
                else
                {
                    MessageBox.Show("Không thành công");
                }                        
            }           
            hoadons.hien_HoaDonPN(dataGridView_HoaDonPN);
        }

        private void comboBox_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        public void uploadMaNV()
        {
            comboBox_MaNV.Items.Clear();
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
                                comboBox_MaNV.Items.Add(dataRow[0]);

                            }
                        }
                        cmd.CommandText = "select * from tblDoiTac";
                        cmd.CommandType = System.Data.CommandType.Text;
                        using (SqlDataAdapter adapters = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapters.Fill(dataTable);
                            // Ngắt kết nối
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                string data = dataRow[0].ToString();
                                data = data.Substring(0, 3);                                
                                if ( data== "NCC")
                                {                                    
                                    comboBox_NhaCC.Items.Add(dataRow[0]);

                                }                             
                            }
                            conn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
        }

        private void button_Xua_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            dataGridView_HoaDonPN.Rows.Clear();
            comboBox_NhaCC_Validating(sender, luu);
            comboBox_MaNV_Validating(sender, luu);
            textBox_MaHDNhap_Validating(sender, luu);
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) && !string.IsNullOrEmpty(comboBox_MaNV.Text.Trim())
               && !string.IsNullOrEmpty(comboBox_NhaCC.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {            
                    hoadons.update_HoaDon_PhieuNhap(MaHDNhap, comboBox_MaNV.Text.ToString(), comboBox_NhaCC.Text.ToString(), NgayNhap);
                    refech_HD_Nhap();
                }

            }    
               
            hoadons.hien_HoaDonPN(dataGridView_HoaDonPN);
        }

        private void dateTimePicker_NgayNhap_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTime = Convert.ToDateTime(dateTimePicker_NgayNhap.Text);
            NgayNhap = dateTime.ToString("yyyy/MM/dd");
        }

        private void dataGridView_HoaDonPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_HoaDonPN.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex<=3)
            {
                DataGridViewCell dataGridViewCell = dataGridView_HoaDonPN[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dataGridView_HoaDonPN.Rows[e.RowIndex];
                    textBox_MaHDNhap.Text = row.Cells[0].Value.ToString();
                    comboBox_MaNV.Text = row.Cells[1].Value.ToString();
                    comboBox_NhaCC.Text = row.Cells[2].Value.ToString();
                    dateTimePicker_NgayNhap.Text = row.Cells[3].Value.ToString();
                  
                }                              
            }
            else
                {
                DataGridViewRow row = dataGridView_HoaDonPN.Rows[e.RowIndex];
                double we = double.Parse(row.Cells[0].Value.ToString());
                chiTiet.onechoice = 1;
                chiTiet.hien_ChiTietPN_theoMa(we);
                chiTiet.ShowDialog();
                }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            CancelEventArgs luu = new CancelEventArgs();
            textBox_MaHDNhap_Validating(sender, luu);
            if (!string.IsNullOrEmpty(textBox_MaHDNhap.Text.Trim()) &&!string.IsNullOrEmpty(comboBox_MaNV.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    hoadons.xoa_HD_PhieuNhap(MaHDNhap);
                    refech_HD_Nhap();                                  
                }
            } 
            dataGridView_HoaDonPN.Rows.Clear();     
            hoadons.hien_HoaDonPN(dataGridView_HoaDonPN);         
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            chiTiet.onechoice = 0;
            chiTiet.ShowDialog();
           
                              
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            refech_HD_Nhap();
        }
        private void refech_HD_Nhap() { 
            textBox_MaHDNhap.Text = string.Empty;
            comboBox_NhaCC.Text = string.Empty;
            dateTimePicker_NgayNhap.Text = string.Empty;
            comboBox_MaNV.Text = string.Empty;
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string texbox_tk = comboBox_Chon_Timkiem.Items[comboBox_Chon_Timkiem.SelectedIndex].ToString();
            if (texbox_tk == "Mã nhân viên")
            {
              
                hoadons.search_HD_Nhap_duavaoMaNV(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
            else if (texbox_tk == "Mã nhà cung cấp")
            {
                hoadons.search_HD_Nhap_duavaoMaNCC(textBox_TimKiem.Text, dataGridView_HoaDonPN);
            }
            else if (texbox_tk == "Địa Chỉ")
            {
                
            }
        }

        private void textBox_MaHDNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_MaHDNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép ký tự không phải là số
            }
            else { e.Handled = false; }
        }

        private void button_InHD_HDNhap_Click(object sender, EventArgs e)
        {
            xuatHD.ShowDialog();

        }
    }
}
