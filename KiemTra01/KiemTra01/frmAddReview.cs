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
    public partial class frmAddReview : Form
    {
        Review currentReviews;
        bool bAddNew = false;

        public frmAddReview(bool status, Review objReview)
        {
            InitializeComponent();
            this.bAddNew = status;
            currentReviews = new Review();
            currentReviews.ProductID = objReview.ProductID;
            currentReviews.CustomerName = objReview.CustomerName;   
            currentReviews.CustomerEmail = objReview.CustomerEmail;
            currentReviews.Rating = objReview.Rating;
            currentReviews.Comments = objReview.Comments;   
        }

        public frmAddReview(bool status)
        {
            InitializeComponent();
            this.bAddNew = status;
        }

        public frmAddReview()
        {
            InitializeComponent();
        }

        private void ResetTextControl()
        {

        }

        private void LoadCustomer()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "SELECT CustomerEmail, CustomerName from Customers";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Chèn dữ liệu vào combobox
            this.cbbCustomerName.DataSource = dt;
            this.cbbCustomerName.ValueMember = "CustomerName";
            this.cbbCustomerName.DisplayMember = "CustomerName";
            this.cbbCustomerEmail.DataSource = dt;
            this.cbbCustomerEmail.ValueMember = "CustomerEmail";
            this.cbbCustomerEmail.DisplayMember = "CustomerEmail";
        }

        private void LoadProduct()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "SELECT ProductID, ModelName from Products";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Chèn dữ liệu vào combobox
            this.cbbProductID.DataSource = dt;
            this.cbbProductID.ValueMember = "ProductID";
            this.cbbProductID.DisplayMember = "ModelName";
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
                myCommand.Parameters.AddWithValue("@ProductID", this.cbbProductID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@CustomerName", this.cbbCustomerName.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@CustomerEmail", this.cbbCustomerEmail.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@Rating", this.txtRating.Text.ToString());
                myCommand.Parameters.AddWithValue("@Comments", this.txtComment.Text.ToString());
                myCommand.Parameters["ReviewID"].Direction = ParameterDirection.Output;
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
                myCommand.Parameters.AddWithValue("@ProductID", this.cbbProductID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@CustomerName", this.cbbCustomerName.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@CustomerEmail", this.cbbCustomerEmail.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@Rating", this.txtRating.Text.ToString());
                myCommand.Parameters.AddWithValue("@Comments", this.txtComment.Text.ToString());
                myCommand.Parameters.AddWithValue("@ReviewID", this.txtReviewID.Text.ToString()); 
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

        private void frmAddReview_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadProduct();
            // ID Review là tự tăng
            this.txtReviewID.Enabled = false;
            // Hiện tên Title theo trạng thái Add New/Edit
            if (this.bAddNew)
            {
                this.lblTitleReview.Text = "Add new Review";
            }
            else
            {
                this.lblTitleReview.Text = "Edit Review";
                this.cbbCustomerName.SelectedValue = this.currentReviews.CustomerID;
                this.cbbProductID.SelectedValue = this.currentReviews.ProductID;
                this.txtReviewID.SelectedText = this.currentReviews.ReviewID.ToString();
                this.txtRating.Text = this.currentReviews.Rating.ToString();
                this.txtComment.Text = this.currentReviews.Comments.ToString();
                // Load Reviews
            }
        }
    }
}
