namespace KiemTra01
{
    partial class frmAddReview
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
            this.lblReview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbbReview = new System.Windows.Forms.ComboBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSaveReview = new System.Windows.Forms.Button();
            this.btnCloseReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(27, 33);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(50, 13);
            this.lblReview.TabIndex = 0;
            this.lblReview.Text = "REVIEW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Review ID:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(27, 125);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(27, 159);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(79, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // cbbReview
            // 
            this.cbbReview.FormattingEnabled = true;
            this.cbbReview.Location = new System.Drawing.Point(105, 91);
            this.cbbReview.Name = "cbbReview";
            this.cbbReview.Size = new System.Drawing.Size(283, 21);
            this.cbbReview.TabIndex = 4;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(27, 188);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(79, 13);
            this.lblCustomerEmail.TabIndex = 5;
            this.lblCustomerEmail.Text = "Customer Email";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(27, 220);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(27, 255);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(54, 13);
            this.lblComments.TabIndex = 7;
            this.lblComments.Text = "Comment:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(105, 125);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(283, 20);
            this.txtProductID.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(112, 156);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(276, 20);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(112, 188);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(276, 20);
            this.txtCustomerEmail.TabIndex = 10;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(112, 220);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(276, 20);
            this.txtRating.TabIndex = 11;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(105, 252);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(283, 20);
            this.txtComment.TabIndex = 12;
            // 
            // btnSaveReview
            // 
            this.btnSaveReview.Location = new System.Drawing.Point(143, 329);
            this.btnSaveReview.Name = "btnSaveReview";
            this.btnSaveReview.Size = new System.Drawing.Size(75, 23);
            this.btnSaveReview.TabIndex = 13;
            this.btnSaveReview.Text = "Save";
            this.btnSaveReview.UseVisualStyleBackColor = true;
            this.btnSaveReview.Click += new System.EventHandler(this.btnSaveReview_Click);
            // 
            // btnCloseReview
            // 
            this.btnCloseReview.Location = new System.Drawing.Point(313, 329);
            this.btnCloseReview.Name = "btnCloseReview";
            this.btnCloseReview.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReview.TabIndex = 14;
            this.btnCloseReview.Text = "Close";
            this.btnCloseReview.UseVisualStyleBackColor = true;
            this.btnCloseReview.Click += new System.EventHandler(this.btnCloseReview_Click);
            // 
            // frmAddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 392);
            this.Controls.Add(this.btnCloseReview);
            this.Controls.Add(this.btnSaveReview);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.cbbReview);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReview);
            this.Name = "frmAddReview";
            this.Text = "frmAddReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cbbReview;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSaveReview;
        private System.Windows.Forms.Button btnCloseReview;
    }
}