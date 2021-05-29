using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sales_Management.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection("Server=.; Database=Sales_DB; Integrated Security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string fileName = txtfilename.Text + "\\Sales_DB" + DateTime.Now.ToShortDateString().Replace('/','-')
                + "-" + DateTime.Now.ToLongTimeString().Replace(':','-');

            string strQuery = " Backup Database Sales_DB to Disk = '" + fileName + ".bak'";

            cmd = new SqlCommand(strQuery,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء النسخة الاحتياطية بنجاح", "انشاء النسخة الاحتياطية",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
