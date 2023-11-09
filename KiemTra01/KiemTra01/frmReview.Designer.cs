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
            this.btnSearchReview = new System.Windows.Forms.Button();
            this.dtgvReview = new System.Windows.Forms.DataGridView();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnEditReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(22, 21);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(86, 18);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(162, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(347, 18);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(188, 20);
            this.txtSearchProduct.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(267, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Text";
            // 
            // btnSearchReview
            // 
            this.btnSearchReview.Location = new System.Drawing.Point(541, 18);
            this.btnSearchReview.Name = "btnSearchReview";
            this.btnSearchReview.Size = new System.Drawing.Size(117, 23);
            this.btnSearchReview.TabIndex = 4;
            this.btnSearchReview.Text = "Search";
            this.btnSearchReview.UseVisualStyleBackColor = true;
            this.btnSearchReview.Click += new System.EventHandler(this.btnSearchReview_Click);
            // 
            // dtgvReview
            // 
            this.dtgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReview.Location = new System.Drawing.Point(25, 47);
            this.dtgvReview.Name = "dtgvReview";
            this.dtgvReview.Size = new System.Drawing.Size(633, 285);
            this.dtgvReview.TabIndex = 5;
            this.dtgvReview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReview_CellContentClick);
            this.dtgvReview.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReview_RowEnter);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(25, 353);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(100, 23);
            this.btnAddReview.TabIndex = 6;
            this.btnAddReview.Text = "Thêm mới";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnEditReview
            // 
            this.btnEditReview.Location = new System.Drawing.Point(152, 353);
            this.btnEditReview.Name = "btnEditReview";
            this.btnEditReview.Size = new System.Drawing.Size(100, 23);
            this.btnEditReview.TabIndex = 7;
            this.btnEditReview.Text = "Sửa";
            this.btnEditReview.UseVisualStyleBackColor = true;
            this.btnEditReview.Click += new System.EventHandler(this.btnEditReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Location = new System.Drawing.Point(295, 353);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteReview.TabIndex = 8;
            this.btnDeleteReview.Text = "Xóa";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteReview);
            this.Controls.Add(this.btnEditReview);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.dtgvReview);
            this.Controls.Add(this.btnSearchReview);
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
        private System.Windows.Forms.Button btnSearchReview;
        private System.Windows.Forms.DataGridView dtgvReview;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnEditReview;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Windows.Forms.Button button1;
    }
}