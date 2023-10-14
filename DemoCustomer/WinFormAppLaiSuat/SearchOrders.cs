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
    public partial class SearchOrders : Form
    {
        public SearchOrders()
        {
            InitializeComponent();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void SearchOrders_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer() 
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "select * from Customers";
            SqlConnection myConnection = new SqlConnection(strConnection);

            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);

            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cboxCustomerID.DataSource = dt;
            this.cboxCustomerID.ValueMember = "CustomerID";
            this.cboxCustomerID.DisplayMember = "FullName";
        }

        private void cboxCustomer_SelectIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
