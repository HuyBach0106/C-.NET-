namespace KiemTra02
{
    partial class frmAddEditCart
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
            this.lblRecordID = new System.Windows.Forms.Label();
            this.lblCartID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.txtCartID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbbProductID = new System.Windows.Forms.ComboBox();
            this.btnSaveCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Location = new System.Drawing.Point(56, 56);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(53, 13);
            this.lblRecordID.TabIndex = 0;
            this.lblRecordID.Text = "RecordID";
            this.lblRecordID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCartID
            // 
            this.lblCartID.AutoSize = true;
            this.lblCartID.Location = new System.Drawing.Point(56, 83);
            this.lblCartID.Name = "lblCartID";
            this.lblCartID.Size = new System.Drawing.Size(37, 13);
            this.lblCartID.TabIndex = 1;
            this.lblCartID.Text = "CartID";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(56, 113);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(58, 144);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(55, 13);
            this.lblProductID.TabIndex = 3;
            this.lblProductID.Text = "ProductID";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(58, 179);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(70, 13);
            this.lblDateCreated.TabIndex = 4;
            this.lblDateCreated.Text = "Date Created";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Location = new System.Drawing.Point(145, 179);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreatedDate.TabIndex = 5;
            // 
            // txtRecordID
            // 
            this.txtRecordID.Location = new System.Drawing.Point(145, 53);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(200, 20);
            this.txtRecordID.TabIndex = 6;
            // 
            // txtCartID
            // 
            this.txtCartID.Location = new System.Drawing.Point(145, 80);
            this.txtCartID.Name = "txtCartID";
            this.txtCartID.Size = new System.Drawing.Size(200, 20);
            this.txtCartID.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(145, 113);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // cbbProductID
            // 
            this.cbbProductID.FormattingEnabled = true;
            this.cbbProductID.Location = new System.Drawing.Point(145, 141);
            this.cbbProductID.Name = "cbbProductID";
            this.cbbProductID.Size = new System.Drawing.Size(200, 21);
            this.cbbProductID.TabIndex = 9;
            // 
            // btnSaveCart
            // 
            this.btnSaveCart.Location = new System.Drawing.Point(145, 240);
            this.btnSaveCart.Name = "btnSaveCart";
            this.btnSaveCart.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCart.TabIndex = 10;
            this.btnSaveCart.Text = "Save";
            this.btnSaveCart.UseVisualStyleBackColor = true;
            this.btnSaveCart.Click += new System.EventHandler(this.btnSaveCart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(270, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Shopping Cart";
            // 
            // frmAddEditCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 316);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveCart);
            this.Controls.Add(this.cbbProductID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCartID);
            this.Controls.Add(this.txtRecordID);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCartID);
            this.Controls.Add(this.lblRecordID);
            this.Name = "frmAddEditCart";
            this.Text = "frmAddEditCart";
            this.Load += new System.EventHandler(this.frmAddEditCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Label lblCartID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.TextBox txtCartID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbbProductID;
        private System.Windows.Forms.Button btnSaveCart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}