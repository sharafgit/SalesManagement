using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management.PL
{
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtserver.Text = Properties.Settings.Default.Server;
            txtdatabase.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbsql.Checked = true;
                txtid.Text = Properties.Settings.Default.ID;
                txtpwd.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbwindows.Checked = true;
                txtid.Clear();
                txtpwd.Clear();
                txtid.ReadOnly = true;
                txtpwd.ReadOnly = true;


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtserver.Text;
            Properties.Settings.Default.Database = txtdatabase.Text;
            Properties.Settings.Default.Mode = rbsql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txtid.Text;
            Properties.Settings.Default.Password = txtpwd.Text;

            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات بنجاح", "اعدادات الاتصال بالسيرفر", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = false;
            txtpwd.ReadOnly = false;
        }

        private void rbwindows_CheckedChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            txtpwd.ReadOnly = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
