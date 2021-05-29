using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management.PL
{
    public partial class FRM_ORDERS_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();

        public FRM_ORDERS_LIST()
        {
            InitializeComponent();

            this.dgvorder.DataSource = order.SearchOrders("");
        }

        private void FRM_ORDERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvorder.DataSource = order.SearchOrders(textBox1.Text);
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(dgvorder.CurrentRow.Cells[0].Value);
            RPT.rpt_orders report = new RPT.rpt_orders();
            RPT.FRM_Reports frm = new RPT.FRM_Reports();
            report.SetDataSource(order.Get_Order_Detials(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
