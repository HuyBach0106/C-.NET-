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
            this.lblTitleReview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSaveReview = new System.Windows.Forms.Button();
            this.btnCloseReview = new System.Windows.Forms.Button();
            this.cbbProductID = new System.Windows.Forms.ComboBox();
            this.cbbCustomerName = new System.Windows.Forms.ComboBox();
            this.txtReviewID = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.cbbCustomerEmail = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitleReview
            // 
            this.lblTitleReview.AutoSize = true;
            this.lblTitleReview.Location = new System.Drawing.Point(27, 33);
            this.lblTitleReview.Name = "lblTitleReview";
            this.lblTitleReview.Size = new System.Drawing.Size(50, 13);
            this.lblTitleReview.TabIndex = 0;
            this.lblTitleReview.Text = "REVIEW";
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
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(27, 221);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(27, 260);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(54, 13);
            this.lblComments.TabIndex = 7;
            this.lblComments.Text = "Comment:";
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(112, 218);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(276, 20);
            this.txtRating.TabIndex = 11;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(105, 253);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(283, 20);
            this.txtComment.TabIndex = 12;
            // 
            // btnSaveReview
            // 
            this.btnSaveReview.Location = new System.Drawing.Point(155, 288);
            this.btnSaveReview.Name = "btnSaveReview";
            this.btnSaveReview.Size = new System.Drawing.Size(75, 23);
            this.btnSaveReview.TabIndex = 13;
            this.btnSaveReview.Text = "Save";
            this.btnSaveReview.UseVisualStyleBackColor = true;
            this.btnSaveReview.Click += new System.EventHandler(this.btnSaveReview_Click);
            // 
            // btnCloseReview
            // 
            this.btnCloseReview.Location = new System.Drawing.Point(313, 288);
            this.btnCloseReview.Name = "btnCloseReview";
            this.btnCloseReview.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReview.TabIndex = 14;
            this.btnCloseReview.Text = "Close";
            this.btnCloseReview.UseVisualStyleBackColor = true;
            this.btnCloseReview.Click += new System.EventHandler(this.btnCloseReview_Click);
            // 
            // cbbProductID
            // 
            this.cbbProductID.FormattingEnabled = true;
            this.cbbProductID.Location = new System.Drawing.Point(105, 122);
            this.cbbProductID.Name = "cbbProductID";
            this.cbbProductID.Size = new System.Drawing.Size(283, 21);
            this.cbbProductID.TabIndex = 15;
            // 
            // cbbCustomerName
            // 
            this.cbbCustomerName.FormattingEnabled = true;
            this.cbbCustomerName.Location = new System.Drawing.Point(112, 156);
            this.cbbCustomerName.Name = "cbbCustomerName";
            this.cbbCustomerName.Size = new System.Drawing.Size(276, 21);
            this.cbbCustomerName.TabIndex = 16;
            // 
            // txtReviewID
            // 
            this.txtReviewID.Location = new System.Drawing.Point(105, 91);
            this.txtReviewID.Name = "txtReviewID";
            this.txtReviewID.Size = new System.Drawing.Size(283, 20);
            this.txtReviewID.TabIndex = 17;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(27, 191);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(79, 13);
            this.lblCustomerEmail.TabIndex = 18;
            this.lblCustomerEmail.Text = "Customer Email";
            // 
            // cbbCustomerEmail
            // 
            this.cbbCustomerEmail.FormattingEnabled = true;
            this.cbbCustomerEmail.Location = new System.Drawing.Point(112, 188);
            this.cbbCustomerEmail.Name = "cbbCustomerEmail";
            this.cbbCustomerEmail.Size = new System.Drawing.Size(276, 21);
            this.cbbCustomerEmail.TabIndex = 19;
            // 
            // frmAddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.cbbCustomerEmail);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.txtReviewID);
            this.Controls.Add(this.cbbCustomerName);
            this.Controls.Add(this.cbbProductID);
            this.Controls.Add(this.btnCloseReview);
            this.Controls.Add(this.btnSaveReview);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleReview);
            this.Name = "frmAddReview";
            this.Text = "frmAddReview";
            this.Load += new System.EventHandler(this.frmAddReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSaveReview;
        private System.Windows.Forms.Button btnCloseReview;
        private System.Windows.Forms.ComboBox cbbProductID;
        private System.Windows.Forms.ComboBox cbbCustomerName;
        private System.Windows.Forms.TextBox txtReviewID;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.ComboBox cbbCustomerEmail;
    }
}