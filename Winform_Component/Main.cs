using System.Collections.Generic;
using System.Windows.Forms;

namespace Winform_Component
{
    public partial class Main : Form
    {
        AppDbContext context = new AppDbContext();
        List<Sanpham> sp;
        // List<cpn_SanPham> listSP = new List<cpn_SanPham>();
        public Main()
        {
            sp = context.Sanphams.ToList();
            InitializeComponent();
            timer_Time.Interval = 1000;
            timer_Time.Start();
        }


        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadProductToPanel(1);
        }
        public void LoadProductToPanel(int page)
        {
            if (page * 4 - 4 < sp.Count)
            {
                Panel s1 = CreateComponent(sp[page * 4 - 4]);
                tlpn_data.Controls.Add(s1, 0, 0);
            }
            if (page * 4 - 3 < sp.Count)
            {
                Panel s2 = CreateComponent(sp[page * 4 - 3]);
                tlpn_data.Controls.Add(s2, 0, 1);
            }
            if (page * 4 - 2 < sp.Count)
            {
                Panel s3 = CreateComponent(sp[page * 4 - 2]);
                tlpn_data.Controls.Add(s3, 1, 0);
            }
            if (page * 4 - 1 < sp.Count)
            {
                Panel s4 = CreateComponent(sp[page * 4 - 1]);
                tlpn_data.Controls.Add(s4, 1, 1);
            }
            //Panel s1 = CreateComponent(sp[page * 4 - 4]);
            //tlpn_data.Controls.Add(s1, 0, 0);
            //Panel s2 = CreateComponent(sp[page * 4 - 3]);
            //tlpn_data.Controls.Add(s2, 0, 1);
            //Panel s3 = CreateComponent(sp[page * 4 - 2]);
            //tlpn_data.Controls.Add(s3, 1, 0);
            //Panel s4 = CreateComponent(sp[page * 4 - 1]);
            //tlpn_data.Controls.Add(s4, 1, 1);

        }

        private void tlpn_data_Paint(object sender, PaintEventArgs e)
        {

        }

        //public void CreatePanel
        public Panel CreateComponent(Sanpham sp)
        {
            Panel p = new Panel();
            p.Name = sp.Ma.ToString();
            p.Size = new Size(382, 253);
            PictureBox ptb = new PictureBox();
            ptb.Image = Image.FromFile(sp.ImgURL);
            ptb.Size = new Size(247, 240);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Controls.Add(ptb);
            Label name = new Label(); name.Text = "Tên sản phẩm";
            name.Location = new Point(262, 5); // set vị trí trên panel
            p.Controls.Add(name);
            Label nameData = new Label(); nameData.Text = sp.Ten;
            nameData.Location = new Point(262, 24); // set vị trí trên panel
            p.Controls.Add(nameData); nameData.Font = new Font("Arial", 11, FontStyle.Bold);
            Label price = new Label(); price.Text = "Giá sản phẩm";
            price.Location = new Point(262, 45); // set vị trí trên panel
            p.Controls.Add(price);
            Label priceData = new Label(); priceData.Text = sp.Gia + "";
            priceData.Location = new Point(262, 67); // set vị trí trên panel
            p.Controls.Add(priceData); priceData.Font = new Font("Arial", 11, FontStyle.Bold);
            Label amount = new Label(); amount.Text = "Số lượng";
            amount.Name = "amount";
            amount.Location = new Point(262, 90); // set vị trí trên panel
            p.Controls.Add(amount);
            Label amountData = new Label(); amountData.Text = sp.Soluong + "";
            amountData.Name = "amountData";
            amountData.Location = new Point(262, 115); // set vị trí trên panel
            p.Controls.Add(amountData); amountData.Font = new Font("Arial", 11, FontStyle.Bold);
            Label amountBuy = new Label(); amountBuy.Text = "Số lượng mua";
            amountBuy.Location = new Point(262, 140); // set vị trí trên panel
            p.Controls.Add(amountBuy);
            TextBox amountBuyData = new TextBox();
            amountBuyData.Name = "amountBuyData";
            amountBuyData.Location = new Point(262, 170);
            p.Controls.Add(amountBuyData);
            Button buy = new Button();
            buy.Location = new Point(262, 203);
            buy.Text = "Mua";
            buy.Font = new Font("Arial", 16, FontStyle.Bold);
            p.Controls.Add(buy);
            buy.Size = new Size(100, 45);
            buy.Click += P_Click;
            return p;
        }

        private void P_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button;
            Control x = b.Parent;
            TextBox l = x.Controls["amountBuyData"] as TextBox;
            MessageBox.Show("Bạn vừa chọn mua sản phẩm có mã là: " + x.Name + " với số lượng là: " + l.Text);
            // Muốn lấy được 1 control cụ thể ta sử dụng thuộc tính Controls["x"] với x là name
            // của Control mà bạn muốn lấy.
            // Thuộc tính Parent là Control chứa control mà bạn cần

        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) >= 2)
            {
                tlpn_data.Controls.Clear();
                lb_page.Text = Convert.ToInt32(lb_page.Text) - 1 + "";
                LoadProductToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void lb_next_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_page.Text) <= sp.Count / 4)
            {
                tlpn_data.Controls.Clear();
                lb_page.Text = Convert.ToInt32(lb_page.Text) + 1 + "";
                LoadProductToPanel(Convert.ToInt32(lb_page.Text));
            }
        }

        private void timer_Time_Tick(object sender, EventArgs e)
        {
            timer_Time.Interval = 1000;
            lb_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_time.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        
    }
}