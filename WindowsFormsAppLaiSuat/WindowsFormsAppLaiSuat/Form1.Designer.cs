namespace WindowsFormsAppLaiSuat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSoTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSoNam = new TextBox();
            label3 = new Label();
            btnTinhLaiSuat = new Button();
            lblMucLaiSuat = new Label();
            SuspendLayout();
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(112, 27);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(125, 27);
            txtSoTien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Số tiền:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 72);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Số năm:";
            label2.Click += label2_Click;
            // 
            // txtSoNam
            // 
            txtSoNam.Location = new Point(112, 69);
            txtSoNam.Name = "txtSoNam";
            txtSoNam.Size = new Size(125, 27);
            txtSoNam.TabIndex = 2;
            txtSoNam.TextChanged += txtSoNam_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 125);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // btnTinhLaiSuat
            // 
            btnTinhLaiSuat.Location = new Point(112, 148);
            btnTinhLaiSuat.Name = "btnTinhLaiSuat";
            btnTinhLaiSuat.Size = new Size(206, 29);
            btnTinhLaiSuat.TabIndex = 5;
            btnTinhLaiSuat.TabStop = false;
            btnTinhLaiSuat.Text = "Tính lãi suất từ Library";
            btnTinhLaiSuat.UseVisualStyleBackColor = true;
            btnTinhLaiSuat.Click += btnTinhLaiSuatTuLibrary_Click;
            // 
            // lblMucLaiSuat
            // 
            lblMucLaiSuat.AutoSize = true;
            lblMucLaiSuat.Location = new Point(112, 115);
            lblMucLaiSuat.Name = "lblMucLaiSuat";
            lblMucLaiSuat.Size = new Size(89, 20);
            lblMucLaiSuat.TabIndex = 7;
            lblMucLaiSuat.Text = "Mức lãi suất";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 595);
            Controls.Add(lblMucLaiSuat);
            Controls.Add(btnTinhLaiSuat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoNam);
            Controls.Add(label1);
            Controls.Add(txtSoTien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoTien;
        private Label label1;
        private Label label2;
        private TextBox txtSoNam;
        private Label label3;
        private Button btnTinhLaiSuat;
        private Label lblMucLaiSuat;
    }
}