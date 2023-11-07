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
using KiemTra01.Class;

namespace KiemTra01
{
    public partial class frmReview : Form
    {
        Review selectedReview;

        public frmReview()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strQuery = "";
            if (this.txtSearchProduct.ToString().Length > 0) { }
            {
                strQuery = "CustomerName like N'%" + this.txtSearchProduct.Text + "%'";
            }

            //Có chọn khách hàng cụ thể
            if (this.txtProductID.ToString() != "0")
            {
                if (strQuery != "")
                {
                    strQuery = " AND ProductID =" + this.txtProductID.ToString();
                }
                else
                {
                    strQuery = " ProductID =" + this.txtProductID.ToString();
                }
            }

            string strCommand = "SELECT * FROM Product";
            if (strQuery.Length > 0)
            {
                strCommand += " WHERE " + strQuery;
            }
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dtgvReview.DataSource = dt;
            this.txtProductID.Text = "ProductID";
            this.txtSearchProduct.Text = "CustomerName";
        }

        private void GridView(DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dtgvReview.Rows[e.RowIndex];
            this.Text = dr.Cells["ReviewID"].Value.ToString();
            // Lưu dòng hiện thời vào 1 đối tượng của lớp Review
            selectedReview = new Review();
            selectedReview.ReviewID = int.Parse(dr.Cells["ReviewID"].Value.ToString());
            selectedReview.ProductID = int.Parse(dr.Cells["ProductID"].Value.ToString());
            selectedReview.CustomerName = dr.Cells["ProductID"].Value.ToString();
            selectedReview.Rating = int.Parse(dr.Cells["Rating"].Value.ToString());
            selectedReview.Comments = dr.Cells["Comments"].Value.ToString();
        }

        private void dtgvReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridView(e);

        }

        private void dtgvReview_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridView(e);
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {

        }
    }
}
