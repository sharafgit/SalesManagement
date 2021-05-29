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
    public partial class FRM_MAIN : Form
    {
        // انشاء حقل من نفس نوع فورم

        private static FRM_MAIN frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public FRM_MAIN()
        {
            InitializeComponent();
            // قيمة frm
            if (frm == null)
                frm = this;

            // الغاء تفعيل الادوات على الشاشة الرئيسية
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.الموردينToolStripMenuItem.Enabled = false;
            this.الاصنافToolStripMenuItem.Enabled = false;
            this.المحاسبToolStripMenuItem.Enabled = false;
            this.مسئولالمبيعاتToolStripMenuItem.Enabled = false;
            this.المبيعاتToolStripMenuItem.Enabled = false;
            this.المشترياتToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // عند الضغط يتم فتح شاشة الدخول

            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();

        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // لفتح شاشة اضافة عميل جديد

            FRM_ADD_CUSTOMER frm = new FRM_ADD_CUSTOMER();
            frm.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void اضافةفاتورةبيعجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS_LIST frm = new FRM_ORDERS_LIST();
            frm.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE frm = new FRM_RESTORE();
            frm.ShowDialog();
        }

        private void اعداداتالاتصالبقاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمحاسبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ACCOUNTS frm = new FRM_ACCOUNTS();
            frm.ShowDialog();
        }
    }
}
