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
    public partial class frmShoppingCart : Form
    {
        ShoppingCart selectedCart;

        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                // Tạo câu lệnh SQL với điều kiện tìm kiếm
                string sql = "SELECT * FROM ShoppingCart WHERE ProductID = @ProductID AND Quantity BETWEEN @FromQuantity AND @ToQuantity";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", txtProductID.Text.ToString());
                    command.Parameters.AddWithValue("@FromQuantity", txtFromQuantity.Text.ToString());
                    command.Parameters.AddWithValue("@ToQuantity", txtToQuantity.Text.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    // Hiển thị kết quả lên GridView
                    dtgvShoppingCart.DataSource = dataTable;
                }
            }
        }

        private void GridView(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ dòng đã chọn
                int recordID = Convert.ToInt32(dtgvShoppingCart.Rows[e.RowIndex].Cells["RecordID"].Value);
                int cartID = Convert.ToInt32(dtgvShoppingCart.Rows[e.RowIndex].Cells["CartID"].Value);
                int quantity = Convert.ToInt32(dtgvShoppingCart.Rows[e.RowIndex].Cells["Quantity"].Value);
                int productID = Convert.ToInt32(dtgvShoppingCart.Rows[e.RowIndex].Cells["ProductID"].Value);
                DateTime dateCreated = Convert.ToDateTime(dtgvShoppingCart.Rows[e.RowIndex].Cells["DateCreated"].Value);

                // Tạo đối tượng ShoppingCart và gán giá trị
                selectedCart = new ShoppingCart
                {
                    RecordID = recordID,
                    CartID = cartID,
                    Quantity = quantity,
                    ProductID = productID,
                    DateCreated = dateCreated
                };

                // Hiển thị thông tin lên các ô text tương ứng
                txtProductID.Text = selectedCart.ProductID.ToString();
                // Hoặc có thể hiển thị thông tin lên tiêu đề form
                this.Text = $"Thông tin ShoppingCart - RecordID: {recordID} - CartID: {cartID} - Quantity: {quantity} " +
                    $"- ProductID: {productID}";
            }
        }

        private void dtgvShoppingCart_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GridView(e);
        }

        private void dtgvShoppingCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridView(e);
        }

        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            if (selectedCart != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();

                    string strCommand = "DELETE FROM ShoppingCart WHERE RecordID = @RecordID";

                    using (SqlConnection myConnection = new SqlConnection(strConnection))
                    {
                        using (SqlCommand myCommand = new SqlCommand(strCommand, myConnection))
                        {
                            myCommand.Parameters.AddWithValue("@RecordID", selectedCart.RecordID);

                            myConnection.Open();
                            int rowsAffected = myCommand.ExecuteNonQuery();
                            myConnection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Bản ghi đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                selectedCart = null; 
                                this.btnSearch_Click(sender, e); 
                            }
                            else
                            {
                                MessageBox.Show("Xóa bản ghi thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần phải chọn bản ghi để xóa!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            frmAddEditCart frm = new frmAddEditCart(true);
            // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
            frm.ShowDialog();
            this.btnSearch_Click(sender, e);
        }

        private void btnEditCart_Click(object sender, EventArgs e)
        {
            if (selectedCart != null)
            {
                // Gọi form với trạng thái Edit và truyền vào bản ghi hiện thời
                frmAddEditCart frm = new frmAddEditCart(false, selectedCart);
                // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
                frm.ShowDialog();
                // Gọi lại hàm search
                this.btnSearch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn cần phải chọn bản ghi để sửa !", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadData()
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();

                // Tạo câu lệnh SQL với điều kiện tìm kiếm
                string sql = "SELECT * FROM ShoppingCart WHERE ProductID = @ProductID AND Quantity BETWEEN @FromQuantity AND @ToQuantity";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", txtProductID.Text.ToString());
                    command.Parameters.AddWithValue("@FromQuantity", txtFromQuantity.Text.ToString());
                    command.Parameters.AddWithValue("@ToQuantity", txtToQuantity.Text.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    // Hiển thị kết quả lên GridView
                    dtgvShoppingCart.DataSource = dataTable;
                }
            }
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
