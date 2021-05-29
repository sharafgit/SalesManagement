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
    public partial class FRM_ACCOUNTS : Form
    {
        BL.CLS_ACCOUNT account = new BL.CLS_ACCOUNT();
        public FRM_ACCOUNTS()
        {
            InitializeComponent();
            dgvaccount.DataSource = account.GET_ALL_ACCOUNTS();
            dgvaccount.Columns[0].Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                account.ADD_ACCOUNT(txtname.Text, xtadd.Text, dtbirth.Value,
                    txtemail.Text,
                    txtuser.Text, txtpwd.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvaccount.DataSource = account.GET_ALL_ACCOUNTS();
                // تعبئة DGV



            }


            catch
            {
                return;
            }
            {
                
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.ADD_ACCOUNT_TEL(Convert.ToInt32(txtid.Text), txttel.Text);
        
            MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvaccount.DataSource = account.GET_ALL_ACCOUNTS();
        }

        private void dgvaccount_DoubleClick(object sender, EventArgs e)
        {
            txtname.Text = dgvaccount.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dgvaccount.CurrentRow.Cells[7].Value.ToString();
            txtid.Text = dgvaccount.CurrentRow.Cells[0].Value.ToString();
        }


    }
}



