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
    public partial class SearchOrders : Form
    {
        ClsOrders selectedOrders;
        public SearchOrders()
        {
            InitializeComponent();
        }

        private void SearchOrders_Load(object sender, EventArgs e)
        {
            LoadCustomer_v2();
        }

        private void LoadCustomers()
        {
            // 1. Connection String
            // 2. Command Text
            // 3. Open Connection
            // 4. Execute a command
            // 5. Fill Data to Dataset
            // 6. Set Data Source for ComboBox

            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "SELECT * FROM Customers";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            // Fill Data
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cbbCustomer.DataSource = dt;
            this.cbbCustomer.ValueMember = "CustomerID";
            this.cbbCustomer.DisplayMember = "FullName";
        }

        private void LoadCustomer_v1()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "Select CustomerID, FullName " + "from Customers Union Select 0, 'All'";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cbbCustomer.DataSource = dt;
            this.cbbCustomer.ValueMember = "CustomerID";
            this.cbbCustomer.DisplayMember = "FullName";
        }

        private void LoadCustomer_v2()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = "Select CustomerID, FullName from v_Customer_All";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cbbCustomer.DataSource = dt;
            this.cbbCustomer.ValueMember = "CustomerID";
            this.cbbCustomer.DisplayMember = "FullName";
        }

        public void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            //string strQuery = "";
            //if (this.txtFullname.Text.Length > 0)
            //{
            //    strQuery = "FullName like N'%" + this.txtFullname.Text + "%'";
            //}

            //// Có chọn khách hàng cụ thể
            //if (this.cbbCustomer.SelectedValue.ToString() != "0")
            //{
            //    if(strQuery != "")
            //    {
            //        strQuery = " AND CustomerID =" + this.cbbCustomer.SelectedValue.ToString();
            //    } else
            //    {
            //        strQuery = " CustomerID =" + this.cbbCustomer.SelectedValue.ToString();
            //    }
            //}

            //string strCommand = "SELECT * FROM v_Orders";
            //if (strQuery.Length > 0)
            //{
            //    strCommand += " WHERE " + strQuery;
            //}
            string strCommand = "OrdersList";
            SqlConnection myConnection = new SqlConnection(strConnection);
            SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@CustomerID", this.cbbCustomer.SelectedValue.ToString());
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            // Fill Data
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dtgvOrders.DataSource = dt;
        }

        private void RetrieveCurrentRow(DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = this.dtgvOrders.Rows[e.RowIndex];
            // Lấy thử ra
            this.Text = dr.Cells["OrderID"].Value.ToString();
            // Lưu dòng hiện thời vào 1 đối tượng của lớp ClsOrders
            selectedOrders = new ClsOrders();
            selectedOrders.OrderID = int.Parse(dr.Cells["OrderID"].Value.ToString());
            selectedOrders.CustomerID = int.Parse(dr.Cells["CustomerID"].Value.ToString());
            selectedOrders.OrderDate = DateTime.Parse(dr.Cells["OrderDate"].Value.ToString());
            selectedOrders.ShipDate = DateTime.Parse(dr.Cells["ShipDate"].Value.ToString());
        }

        private void dtgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveCurrentRow(e);
        }

        private void dtgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveCurrentRow(e);
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            // gọi form với trạng thái Add New
            frmOrders frm = new frmOrders(true);
            // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
            frm.ShowDialog();
            this.btnSearchCustomer_Click(sender, e);
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (selectedOrders != null)
            {
                // Gọi form với trạng thái Edit và truyền vào bản ghi hiện thời
                frmOrders frm = new frmOrders(false, selectedOrders);
                // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
                frm.ShowDialog();
                // Gọi lại hàm search
                this.btnSearchCustomer_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn cần phải chọn bản ghi để sửa !", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
