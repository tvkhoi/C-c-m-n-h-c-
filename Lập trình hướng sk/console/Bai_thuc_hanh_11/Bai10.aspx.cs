using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai_thuc_hanh_11
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("fjfjfjf");
        }

        protected void submit_ServerClick(object sender, EventArgs e)
        {

            if (txtFile.PostedFile != null && txtFile.PostedFile.ContentLength > 0)
            {
                string fileName = Path.GetFileName(txtFile.PostedFile.FileName);
                string extension = Path.GetExtension(fileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                string folderPath = Server.MapPath("~/NewFolder1/");

                // Kiểm tra xem tệp đã tồn tại chưa
                int fileCount = 1;
                string newFileName = fileName;
                while (File.Exists(Path.Combine(folderPath, newFileName)))
                {
                    newFileName = $"{fileNameWithoutExtension}_{fileCount}{extension}";
                    fileCount++;
                }

                string filePath = Path.Combine(folderPath, newFileName);

                // Lưu tệp vào thư mục với tên mới đã thêm số
                txtFile.PostedFile.SaveAs(filePath);

                // Lưu nội dung từ txtNoiDung vào file mới tạo
                File.WriteAllText(filePath, txtNoiDung.Value);

                txtKetqua.InnerText = $"Đã tải lên tệp {newFileName} và lưu nội dung thành công : "+txtNoiDung.Value;
            }
            else
            {
                Response.Write("<script>alert('Chưa chọn hoặc không có tệp để tải lên!')</script>");
            }

        }
    }
}