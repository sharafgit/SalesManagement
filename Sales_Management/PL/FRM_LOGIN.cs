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
    public partial class FRM_LOGIN : Form
    {
        // استنساخ كائن من الكلاس الزى يحتوى على وظيفة التحقق
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();

        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // كود زر الالغاء
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // كود زر الدخول
            // الاعلان عن كائن يقوم باستقبال القيمة

            DataTable Dt = log.LOGIN(txtID.Text,txtPWD.Text);

            if (Dt.Rows.Count>0)
            {
                MessageBox.Show("الدخول صحيح !");

                // تفعيل القوائم

                MessageBox.Show("الدخول صحيح !","الدخول",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FRM_MAIN.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.الاصنافToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المحاسبToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.مسئولالمبيعاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.الموردينToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المبيعاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المشترياتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                this.Close();

                // تفعيل الادوات على الشاشة الرئيسية

                // الاعلان عن متغير من الشاشة الرئيسية 

            }
            else
            {
                MessageBox.Show("فشل الدخول !");
            }
        }
    }
}
