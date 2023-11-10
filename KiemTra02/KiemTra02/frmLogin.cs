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

namespace KiemTra02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strEmailAddress = this.txtEmail.Text;
            string strPassword = this.txtPassword.Text;
            if (CheckUserNamePassFromDB(strEmailAddress, strPassword))
            {
                FormMain mDIForm = new FormMain();
                mDIForm.Text = strEmailAddress + " - " + strPassword;
                this.Hide();
                mDIForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
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
