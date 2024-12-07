using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace btlLTHSK.Resources
{
    
    internal class ChiTietNhapcs01
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLLapTop_connectionString"].ConnectionString;
       public ChiTietNhapcs01()
        {

        }
      

        public bool them_ChiTiet_PhieuNhap(double MaPN, string MaSP, string TenSP, double soLuong, double TGia)
        {
         //   double text = a.trave_MaPN();
           // MessageBox.Show("a"+text);
            try
            {
                string insert_command = "INSERT INTO tblChiTietHDNhapHang " +
                                  "VALUES (" + MaPN + ", N'" + MaSP + "', " + soLuong + ", " + TGia +
                                   ")";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = insert_command;

                        connection.Open();
                        int i = cmd.ExecuteNonQuery();
                        connection.Close();

                        return i > 0;
                    }
                }
            }
            
            catch
            {
                return false;
            }
        }
        
        public void hien_ChiTietPN(DataGridView dataGridView ,string MaSP, string TenSP)
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
                            DataTable dataTable = new DataTable();
                            // Đổ dữ liệu từ csdl vào kho
                            adapter.Fill(dataTable);
                            foreach (DataRow dataRow in dataTable.Rows)
                            {                                                           
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView);                                                      
                                row.Cells[0].Value = dataRow[0].ToString();
                                row.Cells[1].Value = dataRow[1].ToString();  
                                using (SqlCommand cmds = conn.CreateCommand())
                                { 
                                    cmds.CommandText = "lay_TenSP";
                                    cmds.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmds.Parameters.AddWithValue("@MaSP",  row.Cells[1].Value.ToString());
                                    cmds.Parameters.Add("@isExisting", SqlDbType.NVarChar,50).Direction = ParameterDirection.Output;
                                  
                                    cmds.ExecuteNonQuery();
                                    string i = Convert.ToString(cmds.Parameters["@isExisting"].Value); 
                                
                                 row.Cells[2].Value = i;
                                 }                                     
                                row.Cells[3].Value = dataRow[2].ToString(); 
                                row.Cells[4].Value = dataRow[3].ToString();
                                dataGridView.Rows.Add(row);
                                                                                                                         
                              
                                
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
        public void update_ChiTiet_PhieuNhap(double MaChiTietPN , string MaSP ,string TenSP ,
            double Soluong, double TGiaNhap)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "update_ChiTiet_PhieuNhap";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@iCTHDNH", MaChiTietPN);
                    command.Parameters.AddWithValue("@sMaLaptop", MaSP);
                  //  command.Parameters.AddWithValue("@fSoLuon", TenSP);
                    command.Parameters.AddWithValue("@fSoLuongNhap", Soluong);
                    command.Parameters.AddWithValue("@fGiaNhap", TGiaNhap);
                    

                    command.ExecuteNonQuery();
                    conn.Close();
                    
                }
            } 

        }
        public void xoa_ChiTiet_PhieuNHap (double MaChiTietPN, string MaSP) 
       {
            //   try
            //    {          
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "xoa_ChiTietPhieuNhap";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@iCTHDNH", MaChiTietPN);
                    cmd.Parameters.AddWithValue("@sMaLaptop", MaSP);                
                    int i = cmd.ExecuteNonQuery();
                   
                    connection.Close();

                }
            }
           
        }
        
        

    }
}
