using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_lthsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conectionString = "Data Source = LAPTOP-I9P04673\\SQLEXPRESS;Initial Catalog= hsk;Integrated Security=True;";
            int chon = 1;
            while (chon !=0)
            {
                chon =  menu(conectionString);
              
            }
            
            
        }
        private static int menu(string conectionString)
        {
            string input;
            int luachon;
            Console.WriteLine("Them du lieu vao bang Sinh Vien : 1");
            Console.WriteLine("Hien thu danh sach bang Sinh Vien theo SqlDataReader : 2");
            Console.WriteLine("Hien thu danh sach bang Sinh Vien theo DataAdapter,DataSet : 3");
            Console.WriteLine("Dong : 0");
            Console.Write("Lua chon: ");
            input = Console.ReadLine();
            luachon = int.Parse(input);
            switch (luachon)
            {
                case 1:
                    nhapdulieu(conectionString);
                    break;
                case 2:
                    hienthidsSV1(conectionString);
                    break;
                case 3:
                    hienthidsSV2(conectionString);
                    break;
                case 0:
                    return 0;
                    break;
            }
            return 1;

        }
        private static void nhapdulieu(string conectionString)
        {
            string sMaSV, sHoVaTen, sDiaChi, dNgaySinh, sSDT, input;
            int gioiTinh;

            Console.Write("Nhap ma Sv: ");
            input = Console.ReadLine();
            sMaSV = input;
            if (Kiemtra(conectionString, sMaSV) == true)
            {
                return;
            }
            Console.Write("Nhap ho va ten: ");
            input = Console.ReadLine();
            sHoVaTen = input;
            Console.Write("Nhap dia chi: ");
            input = Console.ReadLine();
            sDiaChi = input;
            Console.Write("Nhap ngay sinh: ");
            DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            dNgaySinh = dateTime.ToString("yyyy/MM/dd");
            Console.Write("Nhap so dien thoai: ");
            input = Console.ReadLine();
            sSDT = input;
            Console.Write("Nhap gioi tinh (nam | nu): ");
            input = Console.ReadLine();
            if (input.Equals("nam"))
            {
                gioiTinh = 1;
            }
            else
            {
                gioiTinh = 0;
            }
            Console.WriteLine(sMaSV + sHoVaTen + sDiaChi + dNgaySinh + sSDT + gioiTinh);
            //themdulieu(conectionString, sMaSV, sHoVaTen, sDiaChi, dNgaySinh, sSDT, gioiTinh);
            themSinhVienNgatKetNoi(conectionString, sMaSV, sHoVaTen, sDiaChi, dNgaySinh, sSDT, gioiTinh);
        }
        private static void themdulieu(string connectionString,string sMaSV
            , string sHoVaTen, string sDiaChi, string dNgaySinh, string sSDT,int gioitinh)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    // chỉ định tên proc
                    sqlCommand.CommandText = "nhap_du_lieu_tblSinhVien";
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConnection;
                    // khai báo thông tin và tham số truyền vào
                    sqlCommand.Parameters.Add("@iMaSV", SqlDbType.VarChar, 10).Value = sMaSV;
                    sqlCommand.Parameters.Add("@sHoTen", SqlDbType.NVarChar, 50).Value = sHoVaTen;
                    sqlCommand.Parameters.Add("@dNgaySinh", SqlDbType.Date).Value = dNgaySinh;
                    sqlCommand.Parameters.Add("@sDiaChi", SqlDbType.VarChar, 255).Value = sDiaChi;
                    sqlCommand.Parameters.Add("@sSoDienThoai", SqlDbType.VarChar, 30).Value = sSDT;
                    sqlCommand.Parameters.Add("@bGioiTinh", SqlDbType.Bit).Value = gioitinh;
                    //mở chuỗi kết nối
                    sqlConnection.Open();
                    //sử dụng ExecuteNonQuery để thực thi
                    sqlCommand.ExecuteNonQuery();
                    //đóng chuỗi kết nối.
                    sqlConnection.Close();
                   
                }
            }
        }
       private static bool Kiemtra(string connectionString, string sMaSV)
      {
            string checkID_proc = "checkID_proc";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    //sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = checkID_proc;
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    // khởi tạo đối tượng parameter
                    sqlCommand.Parameters.AddWithValue("@sMaSV", sMaSV);
                    sqlConnection.Open();
                    bool i = (sqlCommand.ExecuteScalar() != null);  //true -> ma sv da ton tại
                    sqlConnection.Close();        
                    if (i == true)
                    {
                        throw new Exception("Ma sinh vien: " + sMaSV + "da ton tai!"); 
                        return true;
                    }

                }
            }
            return false;
        }
        private static void hienthidsSV1(string connectionString)

        {
            string query = "hienthids_SV";
            using(SqlConnection sqlConnection = new SqlConnection( connectionString ))
            {
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = query;
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();
                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        // kiểm tra xem trong bảng sinh viên có dữ liệu hay không
                        if(reader.HasRows)
                        {
                            // Đọc từng dòng dữ liệu trong bảng
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",reader["iMaSV"] , reader["sHoTen"], reader["dNgaySinh"], reader["sDiaChi"], reader["sSoDienThoai"], reader["bGioiTinh"]);
                            }
                        }
                        
                    }
                    sqlConnection.Close() ;
                   
                }
            }
        }
        private static void hienthidsSV2(string connectionString)
        {
            string query = "hienthids_SV";
            using ( SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = query;
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand.CommandText, connectionString); 
                    DataTable dataTable = new DataTable();
                    // sử dụng phương thức fill để  điền dữ liệu vào bảng
                    adapter.Fill(dataTable);
                    // hiện thị dữ liệu ra màn hình
                    foreach(DataRow dataRow in dataTable.Rows)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", dataRow["iMaSV"],
                            dataRow["sHoTen"], dataRow["dNgaySinh"],
                            dataRow["sDiaChi"], dataRow["sSoDienThoai"],
                            dataRow["bGioiTinh"]);
                    }

                }
            }  
        }
        private static void themSinhVienNgatKetNoi(string connectionString, string sMaSV
            , string sHoVaTen, string sDiaChi, string dNgaySinh, string sSDT, int gioitinh)
        {
                    string insert_port = "nhap_du_lieu_tblSinhVien";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM tblSINHVIEN", connectionString))
                {
                    // tạo bảng
                    DataTable dataTable = new DataTable("tblSINHVIEN");
                    // đẩy dữ liệu vào bảng
                    dataAdapter.Fill(dataTable);
                    // thêm bảng vào dataSet
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dataTable);
                    // thêm dòng dữ liệu mới cho bảng
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["iMaSV"] = sMaSV;
                    dataRow["sHoTen"] = sHoVaTen;
                    dataRow["dNgaySinh"] = dNgaySinh;
                    dataRow["sDiaChi"] = sDiaChi;
                    dataRow["sSoDienThoai"] = sSDT;
                    dataRow["bGioiTinh"] = gioitinh;
                    // thêm dòng vào
                    dataTable.Rows.Add(dataRow);
                    



                    // đồng bộ hóa dữ liệu
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        // chỉ định tên proc
                        sqlCommand.CommandText = insert_port;
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        // khai báo thông tin và tham số truyền vào
                        sqlCommand.Parameters.Add("@iMaSV", SqlDbType.VarChar, 10).Value = sMaSV;
                        sqlCommand.Parameters.Add("@sHoTen", SqlDbType.NVarChar, 50).Value = sHoVaTen;
                        sqlCommand.Parameters.Add("@dNgaySinh", SqlDbType.Date).Value = dNgaySinh;
                        sqlCommand.Parameters.Add("@sDiaChi", SqlDbType.VarChar, 255).Value = sDiaChi;
                        sqlCommand.Parameters.Add("@sSoDienThoai", SqlDbType.VarChar, 30).Value = sSDT;
                        sqlCommand.Parameters.Add("@bGioiTinh", SqlDbType.Bit).Value = gioitinh;

                        dataAdapter.InsertCommand = sqlCommand;
                        int a = dataAdapter.Update(ds, "tblSINHVIEN");

                    }
                }
            }
        }
        private static bool kiemTraKhoaChinh_SV(string connectionString)
        {
            return true;
        }
    }
}
