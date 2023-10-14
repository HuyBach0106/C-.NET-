namespace WindowsFormsAppLaiSuat
{
    partial class frmListControl
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
            lstBoxCategory = new ListBox();
            cbbBoxCategory = new ComboBox();
            btnHienKetQua = new Button();
            chkBoxCategory = new CheckedListBox();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lstBoxCategory
            // 
            lstBoxCategory.FormattingEnabled = true;
            lstBoxCategory.ItemHeight = 20;
            lstBoxCategory.Location = new Point(33, 44);
            lstBoxCategory.Name = "lstBoxCategory";
            lstBoxCategory.Size = new Size(322, 364);
            lstBoxCategory.TabIndex = 0;
            // 
            // cbbBoxCategory
            // 
            cbbBoxCategory.FormattingEnabled = true;
            cbbBoxCategory.Location = new Point(807, 44);
            cbbBoxCategory.Name = "cbbBoxCategory";
            cbbBoxCategory.Size = new Size(243, 28);
            cbbBoxCategory.TabIndex = 2;
            // 
            // btnHienKetQua
            // 
            btnHienKetQua.Location = new Point(33, 493);
            btnHienKetQua.Name = "btnHienKetQua";
            btnHienKetQua.Size = new Size(322, 29);
            btnHienKetQua.TabIndex = 3;
            btnHienKetQua.Text = "Hiện kết quả";
            btnHienKetQua.UseVisualStyleBackColor = true;
            btnHienKetQua.Click += btnHienKetQua_Click;
            // 
            // chkBoxCategory
            // 
            chkBoxCategory.FormattingEnabled = true;
            chkBoxCategory.Location = new Point(397, 44);
            chkBoxCategory.Name = "chkBoxCategory";
            chkBoxCategory.Size = new Size(319, 356);
            chkBoxCategory.TabIndex = 4;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(807, 115);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 20);
            lblKetQua.TabIndex = 5;
            lblKetQua.Text = "Kết quả";
            // 
            // frmListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 577);
            Controls.Add(lblKetQua);
            Controls.Add(chkBoxCategory);
            Controls.Add(btnHienKetQua);
            Controls.Add(cbbBoxCategory);
            Controls.Add(lstBoxCategory);
            Name = "frmListControl";
            Text = "ListBoxControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstBoxCategory;
        private ComboBox cbbBoxCategory;
        private Button btnHienKetQua;
        private CheckedListBox chkBoxCategory;
        private Label lblKetQua;
    }
}