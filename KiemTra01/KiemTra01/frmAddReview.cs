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
    public partial class frmAddReview : Form
    {
        public frmAddReview()
        {
            InitializeComponent();
        }

        private void ResetTextControl()
        {

        }

        private int AddNewReview()
        {
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "INSERT INTO Reviews (ProductID, CustomerName, CustomerEmail, Rating, Comments) " + "values (@ProductID, @CustomerName, @CustomerEmail," +
                    "@Rating, @Comments)";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Select
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@ProductID", this.txtProductID.ToString());
                myCommand.Parameters.AddWithValue("@CustomerName", this.txtCustomerName.ToString());
                myCommand.Parameters.AddWithValue("@CustomerEmail", this.txtCustomerEmail.ToString());
                myCommand.Parameters.AddWithValue("@Rating", this.txtRating.ToString());
                myCommand.Parameters.AddWithValue("@Comments", this.txtComment.ToString());
                myCommand.Parameters["OrderID"].Direction = ParameterDirection.Output;
                // Thực thi câu lệnh
                myCommand.ExecuteNonQuery();
                int ID = int.Parse(myCommand.Parameters["@ReviewID"].Value.ToString());
                myConnection.Close();
                return ID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private bool UpdateReview()
        {
            // 1. ConnectString 2. Command Text 3. Open Connection 4. Execute a command
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "UPDATE Reviews SET ProductID = @ProductID, CustomerName = @CustomerName, CustomerEmail = @CustomerEmail, Rating = @Rating, Comments = @Comments WHERE ReviewID = @ReviewID";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Update
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@ProductID", this.txtProductID.ToString());
                myCommand.Parameters.AddWithValue("@CustomerName", this.txtCustomerName.ToString());
                myCommand.Parameters.AddWithValue("@CustomerEmail", this.txtCustomerEmail.ToString());
                myCommand.Parameters.AddWithValue("@Rating", this.txtRating.ToString());
                myCommand.Parameters.AddWithValue("@Comments", this.txtComment.ToString());
                myCommand.Parameters.AddWithValue("@OrderID", this.cbbReview.Text.ToString()); 
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSaveReview_Click(object sender, EventArgs e)
        {   
            int NewID = AddNewReview();
            if (NewID > 0)
            {
                string strMessage = String.Format("Bạn đã thêm thành công " + NewID.ToString() + "\n Bạn đang thêm nữa không?");
                DialogResult dr = MessageBox.Show(strMessage, "Xác nhận thêm nữa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ResetTextControl();
                }
            }
            else
            {
                if (UpdateReview())
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCloseReview_Click(object sender, EventArgs e)
        {
            string strMessage = String.Format("Bạn có chắc chắn muốn đóng form không ?");
            DialogResult dr = MessageBox.Show(strMessage, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
