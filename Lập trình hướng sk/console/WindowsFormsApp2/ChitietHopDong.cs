using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChitietHopDong : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["hsk_thuc_hanh"].ConnectionString;
        private XuLyDuLieu_form_1 xuLyDuLieu_Form;
        public ChitietHopDong(thammyvien_TVK xuLyDu)
        {
           InitializeComponent();
           this.xuLyDuLieu_Form = xuLyDu;
         
           
        }
        public ChitietHopDong(string maBn)
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void ChitietHopDong_Load(object sender, EventArgs e)
        {
           // label1_ketqua_form2.Text = xuLyDuLieu_Form.layMa();
            hien_dataGirdview();
        }
        public void hien_dataGirdview()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd =  connection.CreateCommand())
                    {
                       
                        cmd.CommandText = "Select * from tblHopDong ORDER BY Ngay ASC";
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                       
                       
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Tạo một kho dữ liệu ảo
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            // Ngắt kết nối
                            connection.Close();


                            
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView_formchitiet_TVK);
                                if (dataRow[1].ToString() == xuLyDuLieu_Form.layMa())
                                {
                                    row.Cells[0].Value = dataRow[0].ToString();
                                    row.Cells[1].Value = dataRow[1].ToString();
                                    row.Cells[2].Value = dataRow[2].ToString();

                                    dataGridView_formchitiet_TVK.Rows.Add(row);
                                }
                                // Cách khác 
                                //  DataGridViewRow row = new DataGridViewRow();
                                //  // Đổ dữ liệu từ bảng ảo vào datagridView
                                //  row.CreateCells(dataGridView);
                                //  row.SetValues(dataRow.ItemArray);
                                //  dataGridView.Rows.Add(row);

                            }
                        }
                    }
                }
            }
            catch
            {


            }
        }

        private void dataGridView_formchitiet_TVK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) // Nếu click vào header row
            {
                // Không cho phép chọn nếu click vào header row
                dataGridView_formchitiet_TVK.ClearSelection();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell dataGridViewCell = dataGridView_formchitiet_TVK[e.ColumnIndex, e.RowIndex];
                if (dataGridViewCell.Value != null)
                {
                   
                    //  error.SetError(textBox_maNV, null);
                    DataGridViewRow row = dataGridView_formchitiet_TVK.Rows[e.RowIndex];
                    string b = (row.Cells[0].Value.ToString()).Substring(0, 2);
                    string c = (row.Cells[0].Value.ToString()).Substring(3, 2);
                    string d = (row.Cells[0].Value.ToString()).Substring(6, 4);
                    xuLyDuLieu_Form.xulydulieu(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(),b,c,d);
                    this.Close();
                }
                else
                {
                    // Xử lý khi giá trị của ô là null
                }

            }
        }
    }
}
