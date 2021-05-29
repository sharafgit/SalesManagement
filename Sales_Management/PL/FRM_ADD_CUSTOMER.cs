using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// جلب مجالات الاسماء
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace Sales_Management.PL
{
    public partial class FRM_ADD_CUSTOMER : Form
    {
        // نص الاتصال
        SqlConnection sqlcon = new SqlConnection("Server=.; Database=Sales_DB; Integrated Security=true");

        // الاعلان عن كائن ارسال وجلب البيانات من جداول قاعدة البيانات
        SqlDataAdapter da;
        
        
        DataTable dt = new DataTable();
       

        // الاعلان عن كائن من الكلاس المستخدم لملاء بيانات ComboBox
        BL.CLS_FILL_COMBOBOX SALESMAN = new BL.CLS_FILL_COMBOBOX();

        //الاعلان عن كائن يقوم بادارة الادوات المرتبطة مع بيانات موجودة فى قاعدة البيانات
        // BindingManagerBase

        BindingManagerBase bmb;

        // نعلن عن الكائن المسئول عن الاضافة والحذف والتعديل
        // SqlCommandBuilder

        SqlCommandBuilder cmdb;


        public FRM_ADD_CUSTOMER()
        {
            InitializeComponent();
            // جلب البيانات
            da = new SqlDataAdapter(" select رقم_العميل, اسم_العميل, العنوان,البريد_الالكترونى, رقم_مسئول_المبيعات from العملاء  ", sqlcon);
            
           
            
            da.Fill(dt);
            
            dgList.DataSource = dt;

            // ربط ادوات الشاشة بحقول جدول البيانات

            txtID.DataBindings.Add("text", dt, "رقم_العميل");
            
            txtName.DataBindings.Add("text", dt, "اسم_العميل");
            txtAddress.DataBindings.Add("Text", dt, "العنوان");
            txtEmail.DataBindings.Add("text", dt, "البريد_الالكترونى");
            

            
// تعبئة ComboBox

            cmbSalesMan.DataSource = SALESMAN.GET_ALL_SALESMAN();
            cmbSalesMan.DisplayMember = "الاسم";
            cmbSalesMan.ValueMember = "رقم_مسئول_المبيعات";

            // ربط اداة combobox مع حقل جدول البيانات
            cmbSalesMan.DataBindings.Add("selectedvalue", dt, "رقم_مسئول_المبيعات");

            // تعريف // BindingManagerBase
            bmb = this.BindingContext[dt];
            
            // اظهار رتبة العنصر الحالى على مجموع العناصر
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;



           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //كود زر الخروج
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // كود الزر الاول للتنقل
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // كود الزر الاخير للتنقل
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // كود الزر السابق للتنقل
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // كود الزر االتالى للتنقل
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // كود زر جديد
            bmb.AddNew();
           
            btnNew.Enabled = false;
            btnAdd.Enabled = true;

            
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //كود زر الاضافة

            bmb.EndCurrentEdit();
            
            cmdb = new SqlCommandBuilder(da);
            
           da.Update(dt);
            
           
            MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
            da.Update(dt);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //كود زر الحذف

            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //كود زر التعديل

            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_customers rpt = new RPT.rpt_all_customers();
            RPT.FRM_Reports frm = new RPT.FRM_Reports();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
         
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           


        }
    }
}
