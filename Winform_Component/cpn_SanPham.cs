using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Component
{
    public partial class cpn_SanPham : Form
    {
        Guid ma;
        string ten;
        int gia;
        int soluong;
        string imgURL;
        public cpn_SanPham(Guid ma, string ten, int gia, int soluong, string imgURL)
        {
            this.ma = ma; this.ten = ten; this.gia = gia; this.soluong = soluong; this.imgURL = imgURL;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpn_SanPham_Load(object sender, EventArgs e)
        {
            ptb_Image.Image = Image.FromFile(imgURL);
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_name.Text = ten;
            lb_price.Text = gia +"";
            lb_amount.Text = soluong + "";
        }
    }
}
