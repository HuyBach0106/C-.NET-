namespace WindowsFormsAppLaiSuat
{
    partial class SearchOrders
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
            panel1 = new Panel();
            cbbCustomer = new ComboBox();
            btnSearchCustomer = new Button();
            label1 = new Label();
            txtFullname = new TextBox();
            lblCustomerId = new Label();
            dtgvOrders = new DataGridView();
            btnAddNewOrder = new Button();
            btnEditOrder = new Button();
            btnDeleteOrder = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbbCustomer);
            panel1.Controls.Add(btnSearchCustomer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFullname);
            panel1.Controls.Add(lblCustomerId);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 124);
            panel1.TabIndex = 0;
            // 
            // cbbCustomer
            // 
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(101, 35);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(169, 28);
            cbbCustomer.TabIndex = 6;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(673, 35);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(185, 29);
            btnSearchCustomer.TabIndex = 5;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Full Name:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(373, 35);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(276, 27);
            txtFullname.TabIndex = 3;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(0, 39);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(94, 20);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Customer ID:";
            // 
            // dtgvOrders
            // 
            dtgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrders.Location = new Point(0, 131);
            dtgvOrders.Name = "dtgvOrders";
            dtgvOrders.RowHeadersWidth = 51;
            dtgvOrders.RowTemplate.Height = 29;
            dtgvOrders.Size = new Size(971, 476);
            dtgvOrders.TabIndex = 6;
            dtgvOrders.CellContentClick += dtgvOrders_CellContentClick;
            dtgvOrders.RowEnter += dtgvOrders_RowEnter;
            // 
            // btnAddNewOrder
            // 
            btnAddNewOrder.Location = new Point(47, 643);
            btnAddNewOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddNewOrder.Name = "btnAddNewOrder";
            btnAddNewOrder.Size = new Size(139, 31);
            btnAddNewOrder.TabIndex = 7;
            btnAddNewOrder.Text = "Add New";
            btnAddNewOrder.UseVisualStyleBackColor = true;
            btnAddNewOrder.Click += btnAddNewOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(209, 643);
            btnEditOrder.Margin = new Padding(3, 4, 3, 4);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(139, 31);
            btnEditOrder.TabIndex = 8;
            btnEditOrder.Text = "Edit";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(373, 643);
            btnDeleteOrder.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(139, 31);
            btnDeleteOrder.TabIndex = 9;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(808, 643);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 31);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // SearchOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 689);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnEditOrder);
            Controls.Add(btnAddNewOrder);
            Controls.Add(dtgvOrders);
            Controls.Add(panel1);
            Name = "SearchOrders";
            Text = "SearchOrders";
            Load += SearchOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCustomerId;
        private Label label1;
        private TextBox txtFullname;
        private Button btnSearchCustomer;
        private DataGridView dtgvOrders;
        private ComboBox cbbCustomer;
        private Button btnAddNewOrder;
        private Button btnEditOrder;
        private Button btnDeleteOrder;
        private Button btnClose;
    }
}