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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 93);
            panel1.TabIndex = 0;
            // 
            // cbbCustomer
            // 
            cbbCustomer.FormattingEnabled = true;
            cbbCustomer.Location = new Point(88, 26);
            cbbCustomer.Margin = new Padding(3, 2, 3, 2);
            cbbCustomer.Name = "cbbCustomer";
            cbbCustomer.Size = new Size(148, 23);
            cbbCustomer.TabIndex = 6;
            cbbCustomer.SelectedIndexChanged += cbbCustomer_SelectedIndexChanged;
            cbbCustomer.Click += SearchOrders_Load;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(589, 26);
            btnSearchCustomer.Margin = new Padding(3, 2, 3, 2);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(162, 22);
            btnSearchCustomer.TabIndex = 5;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Full Name:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(326, 26);
            txtFullname.Margin = new Padding(3, 2, 3, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(242, 23);
            txtFullname.TabIndex = 3;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(0, 29);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(76, 15);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Customer ID:";
            // 
            // dtgvOrders
            // 
            dtgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOrders.Location = new Point(0, 98);
            dtgvOrders.Margin = new Padding(3, 2, 3, 2);
            dtgvOrders.Name = "dtgvOrders";
            dtgvOrders.RowHeadersWidth = 51;
            dtgvOrders.RowTemplate.Height = 29;
            dtgvOrders.Size = new Size(850, 357);
            dtgvOrders.TabIndex = 6;
            dtgvOrders.CellContentClick += dtgvOrders_CellContentClick;
            dtgvOrders.RowEnter += dtgvOrders_RowEnter;
            // 
            // btnAddNewOrder
            // 
            btnAddNewOrder.Location = new Point(41, 482);
            btnAddNewOrder.Name = "btnAddNewOrder";
            btnAddNewOrder.Size = new Size(122, 23);
            btnAddNewOrder.TabIndex = 7;
            btnAddNewOrder.Text = "Add New";
            btnAddNewOrder.UseVisualStyleBackColor = true;
            btnAddNewOrder.Click += btnAddNewOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(183, 482);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(122, 23);
            btnEditOrder.TabIndex = 8;
            btnEditOrder.Text = "Edit";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(326, 482);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(122, 23);
            btnDeleteOrder.TabIndex = 9;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(707, 482);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // SearchOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 517);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnEditOrder);
            Controls.Add(btnAddNewOrder);
            Controls.Add(dtgvOrders);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchOrders";
            Text = "SearchOrders";
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