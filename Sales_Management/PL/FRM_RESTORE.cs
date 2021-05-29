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
    public partial class FRM_RESTORE : Form
    {
        SqlConnection con = new SqlConnection("Server=.; Database=master; Integrated Security=true");
        SqlCommand cmd;
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnbrows_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtfilename.Text = openFileDialog1.FileName;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {


           OpenFileDialog op = new OpenFileDialog();
           op.Filter = "Backup files(*.Bak) | *.Bak";
           if (op.ShowDialog() == DialogResult.OK)
           {
                cmd = new SqlCommand("ALTER Database Sales_DB SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore Database Sales_DB From Disk = '" + op.FileName + "'with replace,recovery", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة النسخة بنجاح", "استعادة", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }
    }
}
