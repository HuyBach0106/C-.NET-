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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "SELECT Reviews.*, ReviewID AS Expr1, ProductID AS Expr2, CustomerName AS Expr3, " +
                    "CustomerEmail AS Expr4, Rating AS Expr5, Comments AS Expr6\r\nFROM Reviews";
                SqlConnection myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds, "MyReview");
                //ds.WriteXml("Reviews.xml");
                // Đưa dữ liệu vào Report và view
                rptReviews rptReviews = new rptReviews();
                rptReviews.SetDataSource(ds);
                this.crystalReportViewer1.ReportSource = rptReviews;
                myConnection.Close();
            } catch (Exception ex) {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }
    }
}
