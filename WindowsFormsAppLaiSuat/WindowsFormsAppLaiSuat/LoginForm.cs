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

namespace WindowsFormsAppLaiSuat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = this.txtUsername.Text;
            string strPassword = this.txtPassword.Text;
            string strMessage = String.Format("Bạn đã nhập username {0}, " +
                "password {1}", strUsername, strPassword);
            DialogResult dr = MessageBox.Show(strMessage + "\n Bạn có muốn kiểm tra trong CSDL không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Bạn bấm yes");
                CheckUserNamePassFromDB(strUsername, strPassword);
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
                // Dùng để kết nối tới cơ sở dữ liệu
                // string strConnect = "Data Source=.;Initial Catalog=store;Persist Security Info=True;User ID=sa;Password=123";
                // Gọi chuỗi kết nối từ file App.Config
                string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                // Dùng để chạy câu lệnh
                string strCommand = String.Format("Select * from Customers " + "where Fullname = N'{0}' " +
                                                    "and [Password] = N'{1}'", username, password);
                SqlConnection sqlconnection = new SqlConnection(strConnect);
                SqlCommand myCommand = new SqlCommand(strCommand, sqlconnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "ABC");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Có dữ liệu");
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
