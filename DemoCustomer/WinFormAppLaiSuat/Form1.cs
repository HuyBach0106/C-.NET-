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

namespace WinFormAppLaiSuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = this.txtUsername.Text;
            string strPassword = this.txtPassword.Text;
            string strMessage = String.Format("username {0}, password {1}", strUsername, strPassword);

            DialogResult dr = MessageBox.Show(strMessage + "\n Kiểm tra trong database ?" , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Bấm Yes");
                CheckUsernamePassFormDB(strUsername, strPassword);
            }
            else 
            { 
                MessageBox.Show("Bấm No"); 
            }
        }

        private bool CheckUsernamePassFormDB(string strUsername, string strPassword)
        {
            try
            {

                // Dùng để kết nối CSDL
                string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                // Dùng để chạy câu lệnh
                string strCommand = String.Format("Select * from Customers where FullName = N'{0}' and [Password] = N'{1}'", strUsername, strPassword);
                SqlConnection cnn = new SqlConnection(strConnect);
                SqlCommand myCommand = new SqlCommand(strCommand, cnn);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "ABC");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Exist!");
                    return true;
                }
                else
                { MessageBox.Show("Not exist!");
                  return false;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error!!!",ex.Message);
                return false;
            }
        }
    }
}
