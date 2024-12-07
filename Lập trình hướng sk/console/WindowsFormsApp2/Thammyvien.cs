using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class thammyvien_TVK : Form , XuLyDuLieu_form_1
    {
        ErrorProvider error = new ErrorProvider();

        string connectionString = ConfigurationManager.ConnectionStrings["hsk_thuc_hanh"].ConnectionString;
        public thammyvien_TVK()
        {
           
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            button_tieptuc_TVK.Enabled = false;
            button_chon_TVK.Enabled = false;
            chon_combox_mabn();
            chon_combox_dv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void chon_combox_mabn()
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select * from tblBenhNhan";
                    command.CommandType = CommandType.Text;
                    using(SqlDataReader reader = command.ExecuteReader()) { 
                    while (reader.Read())
                    {
                        comboBox_maBN_TVK.Items.Add(reader["MaBN"].ToString());
                    }

                    reader.Close();
                    }
                }
            }
        }
        public bool kiemtra_maNV(int mabn)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_chinh_mabn";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@maNV", mabn);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại
                                                                                         // Console.WriteLine("Mã sinh viên đã tồn tại" + i);
                        conn.Close();
                        if (i)
                        {

                            // error.SetError(textBox_maNV, "Mã nhân viên đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            // error.SetError(textBox_maNV, null);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
            public void chon_combox_dv()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "Select * from tblDichVu";
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox_chondichvu_TVK.Items.Add(reader["TenDV"].ToString());
                        }

                        reader.Close();
                    }
                }
            }
        }
        public void luu_bn(DateTimePicker ngay,int MaBn, string dichvu)
        {
            try
            {
             
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "them_hopdong";
                        cmd.Parameters.AddWithValue("@ngay", ngay.Value);
                        cmd.Parameters.AddWithValue("@mabn", MaBn);
                        cmd.Parameters.AddWithValue("@dichvu", dichvu);
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();

                        
                    }
                }
            }
            catch
            {
                

            }
        }
        public void chon_ten(int mabn)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "chon_bn";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaBN", mabn);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {



                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    textBox_tenbenhnhan_TVK.Text = reader["TenBN"].ToString();

                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
                            }


                            reader.Close();
                        }
                    }
                }
            } catch (Exception ex)
            {

            }
            
        }
        private void comboBox_chondichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chondichvu = comboBox_chondichvu_TVK.Text;
            
            listBox_dsdichvu_TVK.Items.Add(chondichvu);
        }
        public void them_bn(int mabn,string tenBn)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string insert_command = "INSERT INTO tblBenhNhan " +
                                 "VALUES ('" + mabn + "', N'" + tenBn + "')";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = insert_command;
                      
                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Thêm thành công");

                    }
                }
            }
            catch
            {


            }
        }
        private void button_chon_Click(object sender, EventArgs e)
        {
            listBox_ketqua_TVK.Text = string.Empty;
            string itemData="";
                foreach (var item in listBox_dsdichvu_TVK.Items)
                {
                    itemData = item.ToString() + ", " + itemData;
                
                }
            if (!string.IsNullOrEmpty(comboBox_maBN_TVK.Text)&&!string.IsNullOrEmpty(textBox_ngay_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_thang_TVK.Text.Trim())
                && !string.IsNullOrEmpty(textBox_nam_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_tenbenhnhan_TVK.Text.Trim())
                && !string.IsNullOrEmpty(itemData.Trim()))
            {
                if(kiemtra_maNV(int.Parse(comboBox_maBN_TVK.Text.Trim()))==false)
                {
                    them_bn(int.Parse(comboBox_maBN_TVK.Text), textBox_tenbenhnhan_TVK.Text);
                }
                DateTimePicker dateTimePicker = new DateTimePicker();
                DateTime dateTimeToSet = new DateTime(int.Parse(textBox_nam_TVK.Text), int.Parse(textBox_thang_TVK.Text),int.Parse(textBox_ngay_TVK.Text) ); // Ngày, tháng, năm bạn muốn đặt
                dateTimePicker.Value = dateTimeToSet;
                luu_bn(dateTimePicker, int.Parse(comboBox_maBN_TVK.Text), itemData);
               
                listBox_ketqua_TVK.Items.Add("Tên bệnh nhân: "+textBox_tenbenhnhan_TVK.Text);
                listBox_ketqua_TVK.Items.Add("Ngày khám: "+textBox_ngay_TVK.Text+"/"+textBox_thang_TVK.Text+"/"+textBox_nam_TVK.Text);
                
            
                listBox_ketqua_TVK.Items.Add("Dịch vụ khám: "+itemData);

            }    

            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox_tenbenhnhan_TVK.Text.Trim()))
            {
               // e.Cancel = true;
                error.SetError(textBox_tenbenhnhan_TVK, "Tên bệnh nhân không được để trống");
              
            }
            else
            {
                error.SetError(textBox_tenbenhnhan_TVK, null);
            
            }
            dieukien_chon();
        }

        private void textBox_ngay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_thang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nam_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tenbenhnhan_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void textBox_ngay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ngay_TVK.Text.Trim()))
            {
               // e.Cancel = true;
                error.SetError(textBox_ngay_TVK, " không được để trống");
               

            }
            else
            {
                e.Cancel = false;
                error.SetError(textBox_ngay_TVK, null);
             
            }
            dieukien_chon();
        }

        private void textBox_thang_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_thang_TVK.Text.Trim()))
            {
              //  e.Cancel = true;
                error.SetError(textBox_thang_TVK, "không được để trống");
               

            }
            else
            {
                e.Cancel = false;
                error.SetError(textBox_thang_TVK, null);
                
            }
            dieukien_chon();
        }

        private void textBox_nam_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nam_TVK.Text.Trim()))
            {
               // e.Cancel = true;
                error.SetError(textBox_nam_TVK, "không được để trống");
               
            }
            else
            {
                e.Cancel = false;
                error.SetError(textBox_nam_TVK,null);
                
            }
            dieukien_chon();
        }

        private void textBox_ngay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_thang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_nam_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void dieukien_chon ()
        {
            string itemData = "";
            foreach (var item in listBox_dsdichvu_TVK.Items)
            {
                itemData = item.ToString() + ", " + itemData;

            }
            if (!string.IsNullOrEmpty(textBox_ngay_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_thang_TVK.Text.Trim())
                && !string.IsNullOrEmpty(textBox_nam_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_tenbenhnhan_TVK.Text.Trim())
                && !string.IsNullOrEmpty(itemData.Trim()) && !string.IsNullOrEmpty(comboBox_chondichvu_TVK.Text))
            {
                button_chon_TVK.Enabled = true;
            }
            else
            {
                button_chon_TVK.Enabled = false;
            }
        }
        private void button_tieptuc_Click(object sender, EventArgs e)
        {
        //    string itemData = "";
        //    foreach (var item in listBox_dsdichvu.Items)
        //    {
        //        itemData = item.ToString() + ", " + itemData;

        //    }

         //   if (!string.IsNullOrEmpty(textBox_ngay.Text.Trim()) && !string.IsNullOrEmpty(textBox_thang.Text.Trim())
         //      && !string.IsNullOrEmpty(textBox_nam.Text.Trim()) && !string.IsNullOrEmpty(textBox_tenbenhnhan.Text.Trim()) && !string.IsNullOrEmpty(itemData.Trim()))

         //   {
                textBox_nam_TVK.Text = "";

                textBox_tenbenhnhan_TVK.Text = "";
                textBox_thang_TVK.Text = "";
                textBox_ngay_TVK.Text = "";
                listBox_dsdichvu_TVK.Text = string.Empty;
                listBox_ketqua_TVK.Text = string.Empty; 
                
          //  }
            
            


        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
             
        }

        private void button_tieptuc_Validating(object sender, CancelEventArgs e)
        {
          //  if(!string.IsNullOrEmpty(textBox_ngay.Text.Trim())) { 
          //      button_tieptuc.Enabled = true;
          //  }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox_dsdichvu_Validating(object sender, CancelEventArgs e)
        {
            dieukien_chon();
        }

        private void comboBox_chondichvu_Validating(object sender, CancelEventArgs e)
        {
            dieukien_chon();
        }

       

        private void textBox_ngay_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void comboBox_maBN_TVK_SelectedIndexChanged(object sender, EventArgs e)
        {
            chon_ten(int.Parse(comboBox_maBN_TVK.Text));
        }

        private void comboBox_maBN_TVK_Validating(object sender, CancelEventArgs e)
        {
            dieukien_chon();

        }

        public bool kiemtra_maChitiet(int mabn)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "kiemtr_khoa_chinh_chitiet";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@mabn", mabn);
                        cmd.Parameters.Add("@isExisting", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        bool i = Convert.ToBoolean(cmd.Parameters["@isExisting"].Value); // true nếu mã nv tồn tại
                                                                                         // Console.WriteLine("Mã sinh viên đã tồn tại" + i);
                        conn.Close();
                        if (i)
                        {

                            // error.SetError(textBox_maNV, "Mã nhân viên đã tồn tại!");

                            return true;
                        }
                        else
                        {
                            // error.SetError(textBox_maNV, null);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void button_chuyenform_TVK_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(comboBox_maBN_TVK.Text))
            {
                if(kiemtra_maChitiet(int.Parse(comboBox_maBN_TVK.Text))==true)
                {
                ChitietHopDong chi_Tiết = new ChitietHopDong(this);
                chi_Tiết.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại bản ghi");
                }
            }
           
        }

        public string layMa()
        {
            return comboBox_maBN_TVK.Text.ToString();
        }

        void XuLyDuLieu_form_1.xulydulieu(string mabn,string dichvu,string ngay, string thang,string nam)
        {
            listBox_dsdichvu_TVK.Items.Clear(); 
            comboBox_maBN_TVK.Text = mabn;
            if (mabn.Length > 0)
            {
                chon_ten(int.Parse(mabn));
                listBox_dsdichvu_TVK.Items.Add(dichvu);
                textBox_ngay_TVK.Text = ngay;
                textBox_thang_TVK.Text = thang;
                textBox_nam_TVK.Text = nam;
               // comboBox_chondichvu_TVK.Text = "Cắt môi trái tim ";
            }
            listBox_ketqua_TVK.Text = string.Empty;
            string itemData = "";
            foreach (var item in listBox_dsdichvu_TVK.Items)
            {
                itemData = item.ToString() + ", " + itemData;

            }
            if (!string.IsNullOrEmpty(comboBox_maBN_TVK.Text) && !string.IsNullOrEmpty(textBox_ngay_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_thang_TVK.Text.Trim())
                && !string.IsNullOrEmpty(textBox_nam_TVK.Text.Trim()) && !string.IsNullOrEmpty(textBox_tenbenhnhan_TVK.Text.Trim())
                && !string.IsNullOrEmpty(itemData.Trim()))
            {
                if (kiemtra_maNV(int.Parse(comboBox_maBN_TVK.Text.Trim())) == false)
                {
                    them_bn(int.Parse(comboBox_maBN_TVK.Text), textBox_tenbenhnhan_TVK.Text);
                }
                DateTimePicker dateTimePicker = new DateTimePicker();
                DateTime dateTimeToSet = new DateTime(int.Parse(textBox_nam_TVK.Text), int.Parse(textBox_thang_TVK.Text), int.Parse(textBox_ngay_TVK.Text)); // Ngày, tháng, năm bạn muốn đặt
                dateTimePicker.Value = dateTimeToSet;
               // luu_bn(dateTimePicker, int.Parse(comboBox_maBN_TVK.Text), itemData);

                listBox_ketqua_TVK.Items.Add("Tên bệnh nhân: " + textBox_tenbenhnhan_TVK.Text);
                listBox_ketqua_TVK.Items.Add("Ngày khám: " + textBox_ngay_TVK.Text + "/" + textBox_thang_TVK.Text + "/" + textBox_nam_TVK.Text);


                listBox_ketqua_TVK.Items.Add("Dịch vụ khám: " + itemData);

            }

        }

        private void button_sokhambenh_Click(object sender, EventArgs e)
        {
            if (comboBox_maBN_TVK.Text != "")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["hsk_thuc_hanh"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "khambenh";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@mabn", comboBox_maBN_TVK.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            SoKhamBenh cry = new SoKhamBenh();
                            cry.SetDataSource(dt);
                            Baocao baocao = new Baocao();
                            baocao.crystalReportViewer_baocao.ReportSource = cry;
                            baocao.Show();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["hsk_thuc_hanh"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select_DSKBTTG";
                    command.CommandType = CommandType.StoredProcedure;
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        danhsachkham cry = new danhsachkham();
                        cry.SetDataSource(dt);
                        Baocao baocao = new Baocao();
                        baocao.crystalReportViewer_baocao.ReportSource = cry;
                        baocao.Show();
                    }
                }
            }
        }
    }
}
