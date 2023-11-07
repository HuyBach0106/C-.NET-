namespace KiemTra01
{
    partial class frmReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.dtgvReview = new System.Windows.Forms.DataGridView();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnEditReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(12, 61);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(76, 58);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(162, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(361, 56);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(188, 20);
            this.txtSearchProduct.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(290, 59);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Text";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(585, 58);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(117, 23);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // dtgvReview
            // 
            this.dtgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReview.Location = new System.Drawing.Point(12, 84);
            this.dtgvReview.Name = "dtgvReview";
            this.dtgvReview.Size = new System.Drawing.Size(622, 285);
            this.dtgvReview.TabIndex = 5;
            this.dtgvReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReview_CellContentClick);
            this.dtgvReview.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReview_RowEnter);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(61, 395);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(100, 23);
            this.btnAddReview.TabIndex = 6;
            this.btnAddReview.Text = "Thêm mới";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnEditReview
            // 
            this.btnEditReview.Location = new System.Drawing.Point(185, 395);
            this.btnEditReview.Name = "btnEditReview";
            this.btnEditReview.Size = new System.Drawing.Size(106, 23);
            this.btnEditReview.TabIndex = 7;
            this.btnEditReview.Text = "Sửa";
            this.btnEditReview.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(322, 395);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteReview.TabIndex = 8;
            this.btnDeleteReview.Text = "Xóa";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnEditReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.dtgvReview);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "frmReview";
            this.Text = "frmReview";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.DataGridView dtgvReview;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnEditReview;
        private System.Windows.Forms.Button btnDeleteReview;
    }
}