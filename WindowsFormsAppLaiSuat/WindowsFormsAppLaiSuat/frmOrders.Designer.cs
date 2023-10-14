namespace WindowsFormsAppLaiSuat
{
    partial class frmOrders
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
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlMain = new Panel();
            dtpShipDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            txtOrderID = new TextBox();
            cbbCustomerID = new ComboBox();
            lblShipDate = new Label();
            lblOrderDate = new Label();
            lblOrderID = new Label();
            lblCustomerID = new Label();
            pnlBottom = new Panel();
            btnCloseOrder = new Button();
            btnSaveOrder = new Button();
            pnlTop.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(735, 99);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(57, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Orders";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dtpShipDate);
            pnlMain.Controls.Add(dtpOrderDate);
            pnlMain.Controls.Add(txtOrderID);
            pnlMain.Controls.Add(cbbCustomerID);
            pnlMain.Controls.Add(lblShipDate);
            pnlMain.Controls.Add(lblOrderDate);
            pnlMain.Controls.Add(lblOrderID);
            pnlMain.Controls.Add(lblCustomerID);
            pnlMain.Location = new Point(3, 97);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(731, 385);
            pnlMain.TabIndex = 1;
            // 
            // dtpShipDate
            // 
            dtpShipDate.CustomFormat = "dd/MM/yyyy";
            dtpShipDate.Format = DateTimePickerFormat.Custom;
            dtpShipDate.Location = new Point(218, 267);
            dtpShipDate.Margin = new Padding(3, 4, 3, 4);
            dtpShipDate.Name = "dtpShipDate";
            dtpShipDate.Size = new Size(244, 27);
            dtpShipDate.TabIndex = 7;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(218, 205);
            dtpOrderDate.Margin = new Padding(3, 4, 3, 4);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(244, 27);
            dtpOrderDate.TabIndex = 6;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(218, 137);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(471, 27);
            txtOrderID.TabIndex = 5;
            // 
            // cbbCustomerID
            // 
            cbbCustomerID.FormattingEnabled = true;
            cbbCustomerID.Location = new Point(218, 71);
            cbbCustomerID.Margin = new Padding(3, 4, 3, 4);
            cbbCustomerID.Name = "cbbCustomerID";
            cbbCustomerID.Size = new Size(471, 28);
            cbbCustomerID.TabIndex = 4;
            cbbCustomerID.Click += SearchOrders_Load;
            // 
            // lblShipDate
            // 
            lblShipDate.AutoSize = true;
            lblShipDate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblShipDate.Location = new Point(67, 273);
            lblShipDate.Name = "lblShipDate";
            lblShipDate.Size = new Size(111, 22);
            lblShipDate.TabIndex = 3;
            lblShipDate.Text = "Ship Date: ";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDate.Location = new Point(67, 211);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(123, 22);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Order Date: ";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderID.Location = new Point(67, 137);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(95, 22);
            lblOrderID.TabIndex = 1;
            lblOrderID.Text = "Order ID:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerID.Location = new Point(67, 77);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(132, 22);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "Customer ID:";
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnCloseOrder);
            pnlBottom.Controls.Add(btnSaveOrder);
            pnlBottom.Location = new Point(3, 491);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(731, 85);
            pnlBottom.TabIndex = 2;
            // 
            // btnCloseOrder
            // 
            btnCloseOrder.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseOrder.Location = new Point(561, 27);
            btnCloseOrder.Margin = new Padding(3, 4, 3, 4);
            btnCloseOrder.Name = "btnCloseOrder";
            btnCloseOrder.Size = new Size(111, 31);
            btnCloseOrder.TabIndex = 5;
            btnCloseOrder.Text = "Close";
            btnCloseOrder.UseVisualStyleBackColor = true;
            btnCloseOrder.Click += btnCloseOrder_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveOrder.Location = new Point(65, 27);
            btnSaveOrder.Margin = new Padding(3, 4, 3, 4);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(111, 31);
            btnSaveOrder.TabIndex = 4;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 579);
            Controls.Add(pnlBottom);
            Controls.Add(pnlMain);
            Controls.Add(pnlTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrders";
            Text = "frmOrders";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlMain;
        private Panel pnlBottom;
        private Label lblTitle;
        private Label lblShipDate;
        private Label lblOrderDate;
        private Label lblOrderID;
        private Label lblCustomerID;
        private Button btnCloseOrder;
        private Button btnSaveOrder;
        private ComboBox cbbCustomerID;
        private TextBox txtOrderID;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpShipDate;
    }
}