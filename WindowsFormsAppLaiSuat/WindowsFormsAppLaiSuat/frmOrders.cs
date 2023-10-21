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
using WindowsFormsAppLaiSuat.NewFolder;

namespace WindowsFormsAppLaiSuat
{
    public partial class frmOrders : Form
    {
        ClsOrders currentOrders;
        bool bAddNew = false;

        public frmOrders(bool status, ClsOrders objOrders)
        {
            InitializeComponent();
            this.bAddNew = status;
            currentOrders = new ClsOrders();
            // 4 dòng này có thể viết thành 1 hàm copy trong lớp Orders
            currentOrders.OrderID = objOrders.OrderID;
            currentOrders.CustomerID = objOrders.CustomerID;
            currentOrders.OrderDate = objOrders.OrderDate;
            currentOrders.ShipDate = objOrders.ShipDate;
            LoadCustomer();
        }

        public frmOrders(bool status)
        {
            InitializeComponent();
            this.bAddNew = status;
        }

        public frmOrders()
        {
            InitializeComponent();
        }

        private void LoadCustomer()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "SELECT CustomerID, FullName from Customers";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Chèn dữ liệu vào combobox
            this.cbbCustomerID.DataSource = dt;
            this.cbbCustomerID.ValueMember = "CustomerID";
            this.cbbCustomerID.DisplayMember = "FullName";
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            // ID ORDER là tự tăng
            this.txtOrderID.Enabled = false;
            // Hiện tên Title theo trạng thái Add New/Edit
            if (this.bAddNew)
            {
                this.lblTitle.Text = "Add new Order";
            }
            else
            {
                this.lblTitle.Text = "Edit Order";
                this.cbbCustomerID.SelectedValue = this.currentOrders.CustomerID;
                this.txtOrderID.SelectedText = this.currentOrders.OrderID.ToString();
                this.dtpOrderDate.Text = this.currentOrders.OrderDate.ToString();
                this.dtpShipDate.Text = this.currentOrders.ShipDate.ToString();
                // Load Orders
            }
        }

        private void ResetTextControl()
        {
            this.dtpOrderDate.Value = DateTime.Now;
            this.dtpShipDate.Value = DateTime.Now;
        }

        private bool AddNewOrder()
        {
            // 1. ConnectString 2. Command Text 3. Open Connection 4. Execute a command
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "INSERT INTO Orders (CustomerID, OrderDate, ShipDate) " + "values (@CustomerID, @OrderDate, @ShipDate)";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Select
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@CustomerID", this.cbbCustomerID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@OrderDate", this.dtpOrderDate.Value.ToString());
                myCommand.Parameters.AddWithValue("@ShipDate", this.dtpShipDate.Value.ToString());
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

        private bool UpdateOrder()
        {
            // 1. ConnectString 2. Command Text 3. Open Connection 4. Execute a command
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "UPDATE Orders SET CustomerID = @CustomerID, OrderDate = @OrderDate, ShipDate = @ShipDate WHERE OrderID = @OrderID";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Update
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@CustomerID", this.cbbCustomerID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@OrderDate", this.dtpOrderDate.Value.ToString());
                myCommand.Parameters.AddWithValue("@ShipDate", this.dtpShipDate.Value.ToString());
                // Thêm tham số cho điều kiện WHERE (giả sử bạn cần cập nhật dựa trên OrderID)
                myCommand.Parameters.AddWithValue("@OrderID", this.txtOrderID.Text.ToString()); // Thay yourOrderIDValue bằng giá trị OrderID cần cập nhật.
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



        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            //if (this.bAddNew == true)
            //{
            //    if (AddNewOrder() == true)
            //    {
            //        string strMessage = String.Format("Bạn có muốn thêm nữa không ?");
            //        DialogResult dr = MessageBox.Show(strMessage, "Xác nhận thêm nữa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (dr == DialogResult.Yes)
            //        {
            //            ResetTextControl();
            //        }
            //    }
            //}
            //else
            //{
            //    if(UpdateOrder())
            //    {
            //        MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            int NewID = AddNewOrder_v2();
            if (NewID > 0)
            {
                string strMessage = String.Format("Bạn đã thêm thành công " + NewID.ToString() + "\n Bạn đang thêm nữa không?");
                DialogResult dr = MessageBox.Show(strMessage, "Xác nhận thêm nữa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ResetTextControl();
                }
            } else
            {
                if (UpdateOrder())
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int AddNewOrder_v2()
        {
            try
            {
                string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                string strCommand = "INSERT INTO Orders (CustomerID, OrderDate, ShipDate) " + "values (@CustomerID, @OrderDate, @ShipDate)";
                SqlConnection myConnection = new SqlConnection(strConnection);
                myConnection.Open();
                // Command Select
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                // Truyền tham số
                myCommand.Parameters.AddWithValue("@CustomerID", this.cbbCustomerID.SelectedValue.ToString());
                myCommand.Parameters.AddWithValue("@OrderDate", this.dtpOrderDate.Value.ToString());
                myCommand.Parameters.AddWithValue("@ShipDate", this.dtpShipDate.Value.ToString());
                myCommand.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                myCommand.Parameters["OrderID"].Direction = ParameterDirection.Output;
                // Thực thi câu lệnh
                myCommand.ExecuteNonQuery();
                int ID = int.Parse(myCommand.Parameters["@OrderID"].Value.ToString());
                myConnection.Close();
                return ID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
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
