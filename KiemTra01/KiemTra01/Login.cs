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

namespace KiemTra01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = this.txtEmail.Text;
            string strPassword = this.txtPassword.Text;
            string strMessage = String.Format("Bạn đã nhập email {0}, " +
                "password {1}", strUsername, strPassword);
            DialogResult dr = MessageBox.Show(strMessage + "\n Bạn có muốn kiểm tra trong CSDL không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Bạn bấm yes");
                CheckUserNamePassFromDB(strUsername, strPassword);
                //frmReview frmReview = new frmReview();
                MDIForm mDIForm = new MDIForm();
                this.Hide();
                mDIForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn bấm NO");
            }
        }

        private bool CheckUserNamePassFromDB(string username, string password)
        {
            try
            {
                string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = String.Format("Select * from Customers " + "where EmailAddress = N'{0}' " +
                                                    "and [Password] = N'{1}'", username, password);
                SqlConnection sqlconnection = new SqlConnection(strConnect);
                SqlCommand myCommand = new SqlCommand(strCommand, sqlconnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "ABC");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Có dữ liệu");
                    MessageBox.Show("Đăng nhập thành công");
                    return true;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", ex.Message);
                return false;
            }
        }
    }
}
