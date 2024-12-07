using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private ErrorProvider error = new ErrorProvider();
        public Form3()
        {
            InitializeComponent();
            button_themmoi.Enabled = false;
           
        }

        private void label_diachi_Click(object sender, EventArgs e)
        {

        }

        private void button_chinhsua_Click(object sender, EventArgs e)
        {

        }

        private void textBox_maSV_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_hovaten.Text.Trim()) == false && string.IsNullOrEmpty(textBox_maSV.Text.Trim()) == false
                && string.IsNullOrEmpty(textBox_sdt.Text.Trim()) == false)
            {
                button_themmoi.Enabled = true;
            }
            else
            {
                button_themmoi.Enabled=false;
           
            }
        }
        private void textBox_maSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_maSV.Text))
            {
                error.SetError(textBox_maSV, "Họ và tên sinh viên không được để trống");
            }
            else
            {
                //button_themmoi.Enabled = true;
                e.Cancel = false;
                error.SetError(textBox_maSV, null);
            }
        }

        private void textBox_hovaten_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_hovaten.Text.Trim()) == false &&string.IsNullOrEmpty(textBox_maSV.Text.Trim()) == false
                && string.IsNullOrEmpty(textBox_sdt.Text.Trim()) == false)
            {
                button_themmoi.Enabled = true;
            }
            else
            {
                button_themmoi.Enabled = false;
            }
        }

        private void textBox_hovaten_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_hovaten.Text)) {
                

                error.SetError(textBox_hovaten, "Họ và tên sinh viên không được để trống");
            }
            else
            {
                //button_themmoi.Enabled = true;
                e.Cancel = false;
                error.SetError(textBox_hovaten, null);
               
            }
        }
        // kiểm tra ký tự trong 1 chuỗi
        private bool IsNumber(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
           
            return true;
        }

        private void textBox_sdt_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(textBox_sdt.Text)==false || string.IsNullOrEmpty(textBox_sdt.Text)==true
                &&(string.IsNullOrEmpty(textBox_hovaten.Text)==false || string.IsNullOrEmpty(textBox_maSV.Text)))
            {
                button_themmoi.Enabled=false;
                error.SetError(textBox_sdt, "Vui lòng kiểm tra lại số điện thoại.");
            }
            else
            {
                error.SetError(textBox_sdt,null);
                button_themmoi.Enabled= true;
            }
        }

        private void button_them_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_diachi.Text) && string.IsNullOrEmpty(textBox_hovaten.Text))
            {
                button_themmoi.Enabled = false;
            }
            else
            {
                button_themmoi.Enabled = true;
            }
        }

        private void button_themmoi_Click(object sender, EventArgs e)
        {
            /* 
            String connection = "Data Source=LAPTOP-I9P04673\\SQLEXPRESS;Initial Catalog=hsk;Integrated Security=True;Encrypt=False";
            using(SqlConnection conection = new SqlConnection(connection))
            {
                conection.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select * from tblSINHVIEN";
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        table.Clear();
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(table);
                        dataGridView1.DataSource = table;
                        conection.Close();
                    }
                }
                
            }
            */
            string [] mang = new string[6];
            mang[0] = textBox_maSV.Text;
            mang[1] = textBox_hovaten.Text;
            mang[2] = textBox_sdt.Text;
            mang[3] = textBox_diachi.Text;
            mang[4] = maskedTextBox_ngaysinh.Text;
            if(radioButton_Nam.Checked==true&&radioButton_Nu.Checked==false)
            {
                mang[5] = "Nam";
            } 
            else
            {
                mang[5] = "Nữ";
            }

            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < mang.Length; i++)
            {
                // Tạo cell mới và thêm giá trị cho cell đó
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = mang[i];
                // Thêm cell vào hàng
                row.Cells.Add(cell);
            }
            dataGridView1.Rows.Add(row);
            textBox_diachi.Text = "";
            textBox_maSV.Text = "";
            textBox_hovaten.Text = "";
            textBox_sdt.ResetText();
            maskedTextBox_ngaysinh.Text = "";
        }

        private void textBox_maSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter) { 
                // ngăn chặn không nhập phím enter vào chuỗi
                 e.Handled = true;
                 this.ActiveControl = null;
            }
        }

        private void textBox_hovaten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // ngăn chặn không nhập phím enter vào chuỗi
                e.Handled = true;
                this.ActiveControl = null;
            }
        }

        private void textBox_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // ngăn chặn không nhập phím enter vào chuỗi
                e.Handled = true;
                this.ActiveControl = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox_maSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox_hovaten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_sdt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox_diachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            maskedTextBox_ngaysinh.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

            if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                radioButton_Nam.Checked = true;
            } 
            else
            {
                radioButton_Nu.Checked = true;
            }
            
        }

        
    }
}
