using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlLTHSK
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form nhân viên
            QLNhanVien nv = new QLNhanVien();
            // hiển thị form
            nv.Show();
            
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form khách hàng
            QLKhachHang kh = new QLKhachHang();
            // hiển thị form
            kh.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form hóa đơn
            HoaDon hoaDon = new HoaDon();
            // hiển thị form
            hoaDon.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form Sản phẩm
            SanPham sanPham = new SanPham();
            // hiển thị form
            sanPham.Show();
        }

        private void hóaĐơnMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form Hóa đơn Nhập
            HDNhapHang hdn = new HDNhapHang(); 
            hdn.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khởi tạo form Nhà cung cấp
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.Show();
        }
    }
}
