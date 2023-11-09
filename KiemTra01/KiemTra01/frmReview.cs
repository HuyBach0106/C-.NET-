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

        private void btnSearchReview_Click(object sender, EventArgs e)
        {
            string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string searchValue = this.txtSearchProduct.Text.Trim();

            string strQuery = "CustomerName LIKE N'%" + searchValue + "%' OR CustomerEmail LIKE N'%" + searchValue + "%' OR Comments LIKE N'%" + searchValue + "%'";

            // Kiểm tra xem có chọn khách hàng cụ thể không
            if (!string.IsNullOrEmpty(this.txtProductID.Text) && this.txtProductID.Text != "0")
            {
                strQuery += " AND ProductID = " + this.txtProductID.Text;
            }

            string strCommand = "SELECT * FROM Reviews";
            if (strQuery.Length > 0)
            {
                strCommand += " WHERE " + strQuery;
            }

            using (SqlConnection myConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand myCommand = new SqlCommand(strCommand, myConnection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(myCommand))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        this.dtgvReview.DataSource = dt;
                    }
                }
            }
        }

        private void GridView(DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = this.dtgvReview.Rows[e.RowIndex];
            //this.Text = dr.Cells["ReviewID"].Value.ToString();
            //selectedReview = new Review();
            //selectedReview.ReviewID = int.Parse(dr.Cells["ReviewID"].Value.ToString());
            //selectedReview.ProductID = int.Parse(dr.Cells["ProductID"].Value.ToString());
            //selectedReview.CustomerName = dr.Cells["CustomerName"].Value.ToString();
            //selectedReview.CustomerEmail = dr.Cells["CustomerEmail"].Value.ToString();
            //selectedReview.Rating = int.Parse(dr.Cells["Rating"].Value.ToString());
            //selectedReview.Comments = dr.Cells["Comments"].Value.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow dr = this.dtgvReview.Rows[e.RowIndex];
                // Cập nhật tiêu đề
                this.Text = "Review Details - " + dr.Cells["ReviewID"].Value.ToString() + dr.Cells["CustomerName"].Value.ToString()
                + dr.Cells["CustomerEmail"].Value.ToString() + dr.Cells["Rating"].Value.ToString();

                // Lưu dòng hiện thời vào đối tượng selectedReview
                selectedReview = new Review();
                selectedReview.ReviewID = 0;
                if (dr.Cells["ReviewID"].Value != null)
                {
                    int reviewID;
                    if (int.TryParse(dr.Cells["ReviewID"].Value.ToString(), out reviewID))
                    {
                        selectedReview.ReviewID = reviewID;
                    }
                }

                // Tương tự, cập nhật các thông tin khác
                selectedReview.ProductID = 0;
                if (dr.Cells["ProductID"].Value != null)
                {
                    int productID;
                    if (int.TryParse(dr.Cells["ProductID"].Value.ToString(), out productID))
                    {
                        //selectedReview.ProductID = productID;
                        txtProductID.Text = productID.ToString();
                    }
                }

                // Cập nhật các ô text trên form
                txtSearchProduct.Text = dr.Cells["CustomerName"].Value.ToString();
            }
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
            frmAddReview frm = new frmAddReview(true);
            // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
            frm.ShowDialog();
            this.btnSearchReview_Click(sender, e);
        }

        private void btnEditReview_Click(object sender, EventArgs e)
        {
            if (selectedReview != null)
            {
                // Gọi form với trạng thái Edit và truyền vào bản ghi hiện thời
                frmAddReview frm = new frmAddReview(false, selectedReview);
                // ShowDialog là trạng thái mà form gọi sẽ không tương tác được
                frm.ShowDialog();
                // Gọi lại hàm search
                this.btnSearchReview_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Bạn cần phải chọn bản ghi để sửa !", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
                if (selectedReview != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string strConnection = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();

                        // Tạo câu lệnh SQL để xóa bản ghi dựa trên ReviewID
                        string strCommand = "DELETE FROM Reviews WHERE ReviewID = @ReviewID";

                        using (SqlConnection myConnection = new SqlConnection(strConnection))
                        {
                            using (SqlCommand myCommand = new SqlCommand(strCommand, myConnection))
                            {
                                myCommand.Parameters.AddWithValue("@ReviewID", selectedReview.ReviewID);

                                myConnection.Open();
                                int rowsAffected = myCommand.ExecuteNonQuery();
                                myConnection.Close();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Bản ghi đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    selectedReview = null; // Đặt selectedReview về null sau khi xóa
                                    this.btnSearchReview_Click(sender, e); // Tải lại danh sách review sau khi xóa
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }
    }
}
