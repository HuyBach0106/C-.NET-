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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "SELECT        ShoppingCart.*, RecordID AS Expr1, CartID AS Expr2, Quantity AS Expr3, ProductID AS Expr4, DateCreated AS Expr5\r\nFROM            ShoppingCart";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "MyCart");
                //ds.WriteXml("ShoppingCarts.xml");
                rptCarts rpt = new rptCarts();
                rpt.SetDataSource(ds);
                this.crvView.ReportSource = rpt;
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void crvView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
