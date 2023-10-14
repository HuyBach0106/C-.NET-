using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAppLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhLaiSuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm nút này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            // Để nhận được kết quả --> DialogBox Result
            DialogResult dr = MessageBox.Show("Bạn có muốn tiếp tục không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa bấm nút Yes !");
            }
            else
            {
                MessageBox.Show("Bạn vừa bấm nút No");
            }

            // muclaisuat = TinhLaiSuat(sotien, sonam);
            // nhận về giá trị mức lãi suất

        }

        private void lblMucLaisuat(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa bám nút Yes");
            // Lấy giá trị số năm và thời gian từ 2 ô text
            int sonam = int.Parse(txtSoTien.Text);
            int sotien = int.Parse(txtSoNam.Text);
            // Gọi hàm tính lãi suất
            float muclaisuat = 0.0f;

        }


        private float TinhMucLaiSuat(int SoTienVay)
        {
            float MucLaiSuat = 0;
            if (SoTienVay < 5000)
            {
                // Console.WriteLine("Không cho vay");
                MucLaiSuat = 0;
            }
            else if (SoTienVay < 100000)
            {
                MucLaiSuat = 10.5F;
            }
            else if (SoTienVay < 250000)
            {
                MucLaiSuat = 10;
            }
            else if (SoTienVay < 500000)
            {
                MucLaiSuat = 9.5F;
            }
            else
            {
                MucLaiSuat = 9;
            }
            return MucLaiSuat;
        }

        private float TinhLaiSuat(int sotien, int sonam)
        {
            float muclaisuat = TinhMucLaiSuat(sotien);
            return muclaisuat * sonam * sotien / 100;
        }

        private void btnTinhLaiSuatTuLibrary_Click(object sender, EventArgs e)
        {
            int sotienvay = int.Parse(this.txtSoTien.Text);
            double muclaisuat = MyLibrary.clsLaiSuat.TinhLaiSuat(sotienvay);
            this.lblMucLaiSuat.Text = muclaisuat.ToString();

        }

        private void txtSoNam_TextChanged(object sender, EventArgs e)
        {

        }

    }
}