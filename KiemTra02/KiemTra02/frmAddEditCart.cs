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
    public partial class frmAddEditCart : Form
    {
        ShoppingCart currentCarts;
        bool bAddNew = false;

        public frmAddEditCart(bool status, ShoppingCart objCart)
        {
            InitializeComponent();
            this.bAddNew = status;
            currentCarts.RecordID = objCart.RecordID;
            currentCarts.CartID = objCart.CartID;
            currentCarts.Quantity = objCart.Quantity;
            currentCarts.ProductID = objCart.ProductID;
            currentCarts.DateCreated = objCart.DateCreated;
            LoadProduct();
        }

        public frmAddEditCart(bool status)
        {
            InitializeComponent();
            this.bAddNew = status;
        }

        public frmAddEditCart()
        {
            InitializeComponent();
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

        private bool AddNewCart()
        {
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "INSERT INTO ShoppingCart (CartID, Quantity, ProductID, DateCreated) " + "values (@CartID, @Quantity, @ProductID," +
                    "@DateCreated)";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Select
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@CartID", this.txtCartID.Text.ToString());
                myCommand.Parameters.AddWithValue("@Quantity", this.txtQuantity.Text.ToString());
                myCommand.Parameters.AddWithValue("@ProductID", this.cbbProductID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@DateCreated", this.dtpCreatedDate.Value.ToString());
                // Thực thi câu lệnh
                myCommand.ExecuteNonQuery();
                // Lấy ra ID mới nhất của bản ghi vừa được thêm vào
                myConnection.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool UpdateCart()
        {
            // 1. ConnectString 2. Command Text 3. Open Connection 4. Execute a command
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "UPDATE ShoppingCart SET CartID = @CartID, Quantity = @Quantity, ProductID = @ProductID, " +
                    "DateCreated = @DateCreated" + " WHERE RecordID = @RecordID";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Update
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@CartID", this.txtCartID.Text.ToString());
                myCommand.Parameters.AddWithValue("@Quantity", this.txtQuantity.Text.ToString());
                myCommand.Parameters.AddWithValue("@ProductID", this.cbbProductID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@DateCreated", this.dtpCreatedDate.Value.ToString());
                myCommand.Parameters.AddWithValue("@RecordID", this.txtRecordID.Text.ToString());
                // Thực thi câu lệnh
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

        private void ResetTextControl()
        {
            dtpCreatedDate.Value = DateTime.Now;
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            if (this.bAddNew == true)
            {
                if (AddNewCart() == true)
               {
                    string strmessage = string.Format("Bạn có muốn thêm nữa không ?");
                   DialogResult dr = MessageBox.Show(strmessage, "xác nhận thêm nữa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (dr == DialogResult.Yes)
                   {
                        ResetTextControl();
                   }
               }
            }
            else
            {
               if(UpdateCart())
               {
                  MessageBox.Show("cập nhật thành công !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
                }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string strMessage = String.Format("Bạn có chắc chắn muốn đóng form không ?");
            DialogResult dr = MessageBox.Show(strMessage, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAddEditCart_Load(object sender, EventArgs e)
        {
            LoadProduct();
            // ID Review là tự tăng
            this.txtRecordID.Enabled = false;
            // Hiện tên Title theo trạng thái Add New/Edit
            if (this.bAddNew)
            {
                this.lblTitle.Text = "Add new cart";
            }
            else
            {
                this.lblTitle.Text = "Edit cart";
                this.txtRecordID.Text = this.currentCarts.RecordID.ToString();
                this.txtCartID.Text = this.currentCarts.CartID.ToString();
                this.cbbProductID.SelectedValue = this.currentCarts.ProductID;
                this.txtQuantity.Text = this.currentCarts.Quantity.ToString();
                this.dtpCreatedDate.Value = this.currentCarts.DateCreated;
                // Load Carts
            }
        }
    }
}
