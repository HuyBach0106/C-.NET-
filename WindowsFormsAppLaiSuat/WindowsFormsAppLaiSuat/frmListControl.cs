using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLaiSuat
{
    public partial class frmListControl : Form
    {
        public frmListControl()
        {
            InitializeComponent();
        }

        private void frmListControl_Load(object sender, EventArgs e)
        {
            LoadDuLieuListBox();
            LoadCheckBoxList();
        }

        private void LoadDuLieuListBox()
        {
            this.lstBoxCategory.Items.Clear();
            this.lstBoxCategory.Items.Add("Phone");
            this.lstBoxCategory.Items.Add("Computer");
            this.lstBoxCategory.Items.Add("Ipad");
        }

        private void lstBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxCategory.SelectedIndex > 0)
            {
                this.lblKetQua.Text = lstBoxCategory.SelectedIndex.ToString();
            }
        }

        private void LoadCheckBoxList()
        {
            this.chkBoxCategory.Items.Clear();
            this.chkBoxCategory.Items.Add("Phone");
            this.chkBoxCategory.Items.Add("Computer");
            this.chkBoxCategory.Items.Add("Ipad");
            this.chkBoxCategory.Items.Add("Laptop");
        }

        private void btnHienKetQua_Click(object sender, EventArgs e)
        {
            string results = "";
            if (chkBoxCategory.CheckedItems.Count > 0)
            {
                foreach (var item in this.chkBoxCategory.CheckedItems)
                {
                    results += item.ToString() + ",";
                }
                results = results.Substring(0, results.Length - 1);
                this.lblKetQua.Text = results;
            }
            else this.lblKetQua.Text = "";
        }

        private void LoadComboBox()
        {
            this.cbbBoxCategory.Items.Clear();
            this.cbbBoxCategory.Items.Add("Phone");
            this.cbbBoxCategory.Items.Add("Computer");
            this.cbbBoxCategory.Items.Add("Ipad");
            this.cbbBoxCategory.Items.Add("Laptop");
        }
    }
}
