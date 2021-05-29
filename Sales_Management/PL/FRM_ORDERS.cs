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
    public partial class FRM_ORDERS : Form
    {
        // الاعلان عن كائن من الكلاس المستخدم لملاء بيانات ComboBox
        BL.CLS_FILL_COMBOBOX ACCOUNT = new BL.CLS_FILL_COMBOBOX();

        // الاعلان عن كائن من الكلاس المستخدم لملاء بيانات ComboBox
        BL.CLS_FILL_COMBOBOX CUSTOMER = new BL.CLS_FILL_COMBOBOX();

        BL.CLS_ORDERS orders = new BL.CLS_ORDERS();
        DataTable Dt = new DataTable();

        // 
        void CalculateAmount()
        {
            if (txtprice.Text != string.Empty && txtqty.Text != string.Empty)

                txtpricebeforedis.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
        }

        //
        double Discount;
        void CalculateTotalAmount()
        {
            if (txtdiscount.Text != string.Empty && txtpricebeforedis.Text != string.Empty)
                Discount = Convert.ToDouble(txtdiscount.Text);
            double Amount = Convert.ToDouble(txtpricebeforedis.Text);
            double TotalAmount = Amount - (Amount * (Discount / 100));
            txtpriceafterdis.Text = TotalAmount.ToString();
        }
        //
        void ClearBoxes()
        {
            txtidproduct.Clear();
            txtnameproduct.Clear();
            txtprice.Clear();
            txtqty.Clear();
            txtpricebeforedis.Clear();
            txtdiscount.Clear();
            txtpriceafterdis.Clear();
            btnproduct.Focus();
        }

        //
        void CreateDataTable()
        {
            Dt.Columns.Add("رقم_المنتج");
            Dt.Columns.Add("اسم_المنتج");
            Dt.Columns.Add("السعر");
            Dt.Columns.Add("الكمية");
            Dt.Columns.Add("الثمن_قبل_الخصم");
            Dt.Columns.Add("نسبة_الخصم(%)");
            Dt.Columns.Add("الثمن_بعد_الخصم");

            dgvproduct.DataSource = Dt;

        }

        void ResizeDGV()
        {
            this.dgvproduct.RowHeadersWidth = 181;
            this.dgvproduct.Columns[0].Width = 123;
            this.dgvproduct.Columns[1].Width = 310;
            this.dgvproduct.Columns[2].Width = 129;
            this.dgvproduct.Columns[3].Width = 129;
            this.dgvproduct.Columns[4].Width = 180;
            this.dgvproduct.Columns[5].Width = 168;
            this.dgvproduct.Columns[6].Width = 163;

        }

        public FRM_ORDERS()
        {
            InitializeComponent();

            CreateDataTable();
            ResizeDGV();

            // تعبئة ComboBox

            cmbaccount.DataSource = ACCOUNT.GET_ALL_ACCOUNTS();
            cmbaccount.DisplayMember = "الاسم";
            cmbaccount.ValueMember = "رقم_محاسب";

            // تعبئة ComboBox

            cmbcustomer.DataSource = CUSTOMER.GET_ALL_CUSTOMERS();
            cmbcustomer.DisplayMember = "اسم_العميل";
            cmbcustomer.ValueMember = "رقم_العميل";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtorderid.Text = orders.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnsave.Enabled = true;
            btnprint.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            ClearBoxes();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();

            this.txtidproduct.Text = frm.dgvproducts.CurrentRow.Cells[0].Value.ToString();

            this.txtnameproduct.Text = frm.dgvproducts.CurrentRow.Cells[1].Value.ToString();
            this.txtprice.Text = frm.dgvproducts.CurrentRow.Cells[3].Value.ToString();

            txtqty.Focus();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpricebeforedis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceafterdis_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqty.Text != string.Empty)
            {
                txtdiscount.Focus();
            }
        }

        private void txtqty_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateAmount();
            CalculateTotalAmount();
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (orders.VerifyQty(txtidproduct.Text, Convert.ToInt32(txtqty.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية غير متوفرة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                for (int i = 0; i < dgvproduct.Rows.Count - 1; i++)
                {
                    if (dgvproduct.Rows[i].Cells[0].Value.ToString() == txtidproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخالة من قبل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                }


                DataRow r = Dt.NewRow();
                r[0] = txtidproduct.Text;
                r[1] = txtnameproduct.Text;
                r[2] = txtprice.Text;
                r[3] = txtqty.Text;
                r[4] = txtpricebeforedis.Text;
                r[5] = txtdiscount.Text;
                r[6] = txtpriceafterdis.Text;

                Dt.Rows.Add(r);
                dgvproduct.DataSource = Dt;
                ClearBoxes();



                // حساب المجموع
                txtsum.Text = (from DataGridViewRow row in dgvproduct.Rows where row.Cells[6].FormattedValue.ToString() != string.Empty select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();



            }
        }


            
            
        

        private void btnsave_Click(object sender, EventArgs e)
        {
            // اضافة معلومات الفاتورة
            orders.ADD_ORDER(Convert.ToInt32(txtorderid.Text), dtorder.Value,txtordernotes.Text,
                Convert.ToInt32(cmbcustomer.SelectedValue), Convert.ToInt32(cmbaccount.SelectedValue));

            // اضافة تفاصيل الفاتورة
            for(int i=0; i<dgvproduct.Rows.Count -1;i++)
            {
                orders.ORDER_DETAILS(dgvproduct.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(txtorderid.Text),
                    Convert.ToInt32(dgvproduct.Rows[i].Cells[3].Value.ToString()),
                    Convert.ToInt32(dgvproduct.Rows[i].Cells[5].Value),
                    dgvproduct.Rows[i].Cells[4].Value.ToString(),
                    dgvproduct.Rows[i].Cells[6].Value.ToString());
            }

            MessageBox.Show("تمت عملية الخغظ بنجاح", "عملية الخفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnnew.Enabled = true;
            ClearBoxes();

            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            // GET THE LAST Order
            
            int order_id = Convert.ToInt32(orders.GET_LAST_ORDER_FOR_PRINT().Rows[0][0]);
            RPT.rpt_orders report = new RPT.rpt_orders();
            RPT.FRM_Reports frm = new RPT.FRM_Reports();
            report.SetDataSource(orders.Get_Order_Detials(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

 
    
