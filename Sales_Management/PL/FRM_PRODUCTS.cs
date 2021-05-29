using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Sales_Management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
       
        // الاعلان عن كائن ارسال وجلب البيانات من جداول قاعدة البيانات
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        // الاعلان عن كائن من الكلاس المستخدم لملاء بيانات ComboBox
        BL.CLS_FILL_COMBOBOX SALESMAN = new BL.CLS_FILL_COMBOBOX();

        // الاعلان عن كائن من الكلاس المستخدم لملاء بيانات ComboBox
        BL.CLS_FILL_COMBOBOX CATEGORY = new BL.CLS_FILL_COMBOBOX();

        BL.CLS_PRODUCTS product = new BL.CLS_PRODUCTS();
        int ID;

      

        public FRM_PRODUCTS()
        {
            InitializeComponent();
            // تعبئة ComboBox

            cmbsalesman.DataSource = SALESMAN.GET_ALL_SALESMAN();
            cmbsalesman.DisplayMember = "الاسم";
            cmbsalesman.ValueMember = "رقم_مسئول_المبيعات";

            // ربط اداة combobox مع حقل جدول البيانات
            cmbsalesman.DataBindings.Add("selectedvalue", dt, "رقم_مسئول_المبيعات");


            // تعبئة ComboBox

            cmbidcateg.DataSource = CATEGORY.GET_ALL_CATEGORIES();
            cmbidcateg.DisplayMember = "اسم_الصنف";
            cmbidcateg.ValueMember = "رقم_الصنف";

            // ربط اداة combobox مع حقل جدول البيانات
            cmbidcateg.DataBindings.Add("selectedvalue", dt, "رقم_الصنف");

            // تعبئة DGV
            this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();

            

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Picture;
                if (pbox.Image == null)
                {
                    Picture = new byte[0];
                    product.ADD_PRODUCTS( txtidproduct.Text.ToString(), txtnameproduct.Text.ToString(), Convert.ToInt32(txtqty.Text), txtpriceproduct.Text, Picture,
                    Convert.ToInt32(cmbidcateg.SelectedValue),
                    Convert.ToInt32(cmbsalesman.SelectedValue), dtregistproduct.Value, "without_image");
                    MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تعبئة DGV
                    this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();

                    
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    Picture = ms.ToArray();

                    product.ADD_PRODUCTS(txtidproduct.Text, txtnameproduct.Text.ToString(), Convert.ToInt32(txtqty.Text), txtpriceproduct.Text, Picture,
                        Convert.ToInt32(cmbidcateg.SelectedValue),
                        Convert.ToInt32(cmbsalesman.SelectedValue), dtregistproduct.Value, "with_image");

                    MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تعبئة DGV
                    this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();

                   
                }
            }
            catch
            {
                return;
            } 

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور| *.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            // كود زر جديد

            cmbidcateg.ResetText();
            cmbsalesman.ResetText();
            txtidproduct.Clear();
            dtregistproduct.ResetText();
            txtnameproduct.Clear();
            txtpriceproduct.Clear();
            txtqty.Clear();
            pbox.Image = null;
            cmbidcateg.Focus();

            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvproductlist_DoubleClick(object sender, EventArgs e)
        {
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            try
            {
                pbox.Image = null;
                ID = Convert.ToInt32(dgvproductlist.CurrentRow.Cells[0].Value);
                this.cmbidcateg.SelectedValue = dgvproductlist.CurrentRow.Cells[5].Value.ToString();
                this.cmbsalesman.SelectedValue = dgvproductlist.CurrentRow.Cells[6].Value.ToString();
                this.txtidproduct.Text = dgvproductlist.CurrentRow.Cells[0].Value.ToString();
                this.dtregistproduct.Value = Convert.ToDateTime(dgvproductlist.CurrentRow.Cells[7].Value.ToString());
                this.txtnameproduct.Text = dgvproductlist.CurrentRow.Cells[1].Value.ToString();
                this.txtqty.Text = dgvproductlist.CurrentRow.Cells[2].Value.ToString();
                this.txtpriceproduct.Text = dgvproductlist.CurrentRow.Cells[3].Value.ToString();
                byte[] Picture = (byte[])dgvproductlist.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void dgvproductlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] Picture;
                if (pbox.Image == null)
                {
                    Picture = new byte[0];
                    product.EDIT_PRODUCTS(txtidproduct.Text.ToString(), txtnameproduct.Text.ToString(), Convert.ToInt32(txtqty.Text), txtpriceproduct.Text, Picture,
                    Convert.ToInt32(cmbidcateg.SelectedValue),
                    Convert.ToInt32(cmbsalesman.SelectedValue), dtregistproduct.Value, "without_image",ID);
                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تعبئة DGV
                    this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();


                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    Picture = ms.ToArray();

                    product.EDIT_PRODUCTS(txtidproduct.Text.ToString(), txtnameproduct.Text.ToString(), Convert.ToInt32(txtqty.Text), txtpriceproduct.Text, Picture,
                        Convert.ToInt32(cmbidcateg.SelectedValue),
                        Convert.ToInt32(cmbsalesman.SelectedValue), dtregistproduct.Value, "with_image",ID);

                    MessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تعبئة DGV
                    this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();


                }
            }
            catch
            {
                return;
            }

                    }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتج المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                product.DeleteProduct(this.dgvproductlist.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvproductlist.DataSource = product.GET_ALL_PRODUCTS();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtnameproduct_Validated(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = product.VERIFYPRODUCTID(txtnameproduct.Text);
            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا المنتج موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtidproduct_Validated(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = product.VERIFYPRODUCTID(txtidproduct.Text);
            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("هذا المنتج يوجد مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtidproduct.Focus();
                txtidproduct.SelectionStart = 0;
                txtidproduct.SelectionLength = txtidproduct.TextLength;
            }
        }

        private void dgvproductlist_DoubleClick_1(object sender, EventArgs e)
        {
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            try
            {
                pbox.Image = null;
                ID = Convert.ToInt32(dgvproductlist.CurrentRow.Cells[0].Value);
                this.cmbidcateg.SelectedValue = dgvproductlist.CurrentRow.Cells[5].Value.ToString();
                this.cmbsalesman.SelectedValue = dgvproductlist.CurrentRow.Cells[6].Value.ToString();
                this.txtidproduct.Text = dgvproductlist.CurrentRow.Cells[0].Value.ToString();
                this.dtregistproduct.Value = Convert.ToDateTime(dgvproductlist.CurrentRow.Cells[7].Value.ToString());
                this.txtnameproduct.Text = dgvproductlist.CurrentRow.Cells[1].Value.ToString();
                this.txtqty.Text = dgvproductlist.CurrentRow.Cells[2].Value.ToString();
                this.txtpriceproduct.Text = dgvproductlist.CurrentRow.Cells[3].Value.ToString();
                byte[] Picture = (byte[])dgvproductlist.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(Picture);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }
    }
}
