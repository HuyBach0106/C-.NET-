namespace KiemTra02
{
    partial class frmShoppingCart
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtFromQuantity = new System.Windows.Forms.TextBox();
            this.txtToQuantity = new System.Windows.Forms.TextBox();
            this.dtgvShoppingCart = new System.Windows.Forms.DataGridView();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnEditCart = new System.Windows.Forms.Button();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.lblFromTo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShoppingCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(37, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(98, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(152, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.Text = "355";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(289, 30);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtFromQuantity
            // 
            this.txtFromQuantity.Location = new System.Drawing.Point(341, 27);
            this.txtFromQuantity.Name = "txtFromQuantity";
            this.txtFromQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtFromQuantity.TabIndex = 3;
            this.txtFromQuantity.Text = "1";
            // 
            // txtToQuantity
            // 
            this.txtToQuantity.Location = new System.Drawing.Point(506, 27);
            this.txtToQuantity.Name = "txtToQuantity";
            this.txtToQuantity.Size = new System.Drawing.Size(105, 20);
            this.txtToQuantity.TabIndex = 4;
            this.txtToQuantity.Text = "100";
            // 
            // dtgvShoppingCart
            // 
            this.dtgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShoppingCart.Location = new System.Drawing.Point(22, 72);
            this.dtgvShoppingCart.Name = "dtgvShoppingCart";
            this.dtgvShoppingCart.Size = new System.Drawing.Size(652, 248);
            this.dtgvShoppingCart.TabIndex = 5;
            this.dtgvShoppingCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShoppingCart_CellContentClick);
            this.dtgvShoppingCart.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvShoppingCart_RowEnter);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(22, 342);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(95, 23);
            this.btnAddCart.TabIndex = 6;
            this.btnAddCart.Text = "Add";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnEditCart
            // 
            this.btnEditCart.Location = new System.Drawing.Point(155, 342);
            this.btnEditCart.Name = "btnEditCart";
            this.btnEditCart.Size = new System.Drawing.Size(95, 23);
            this.btnEditCart.TabIndex = 7;
            this.btnEditCart.Text = "Edit";
            this.btnEditCart.UseVisualStyleBackColor = true;
            this.btnEditCart.Click += new System.EventHandler(this.btnEditCart_Click);
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Location = new System.Drawing.Point(292, 342);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteCart.TabIndex = 8;
            this.btnDeleteCart.Text = "Delete";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // lblFromTo
            // 
            this.lblFromTo.AutoSize = true;
            this.lblFromTo.Location = new System.Drawing.Point(461, 30);
            this.lblFromTo.Name = "lblFromTo";
            this.lblFromTo.Size = new System.Drawing.Size(20, 13);
            this.lblFromTo.TabIndex = 9;
            this.lblFromTo.Text = "To";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 342);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFromTo);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.btnEditCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.dtgvShoppingCart);
            this.Controls.Add(this.txtToQuantity);
            this.Controls.Add(this.txtFromQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "frmShoppingCart";
            this.Text = "frmShoppingCart";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShoppingCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtFromQuantity;
        private System.Windows.Forms.TextBox txtToQuantity;
        private System.Windows.Forms.DataGridView dtgvShoppingCart;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnEditCart;
        private System.Windows.Forms.Button btnDeleteCart;
        private System.Windows.Forms.Label lblFromTo;
        private System.Windows.Forms.Button btnSearch;
    }
}