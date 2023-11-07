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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }



        private static void LoadData()
        {
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "SELECT * FROM v_Order_Full";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // MessageBox.Show("Kết nối tới CSDL thành công !");
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                // Nhận dữ liệu về data set
                DataSet ds = new DataSet();
                da.Fill(ds, "MyCustomer");
                ds.WriteXml("Orders.xml");
                // Đưa dữ liệu lên GridView
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi" + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
