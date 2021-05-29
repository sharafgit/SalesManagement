using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// جلب مجالات الاسماء
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class CLS_PRODUCTS
    {
        // اجراء الاضافة
        public void ADD_PRODUCTS(string رقم_المنتج, string اسم_المنتج, int الكمية_المخزنة,
            string السعر, byte[] صورة_المنتج, int رقم_الصنف, int رقم_مسئول_المبيعات, DateTime تاريخ_التسحيل, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@رقم_المنتج", SqlDbType.VarChar, 30);
            param[0].Value = رقم_المنتج;

            param[1] = new SqlParameter("@اسم_المنتج", SqlDbType.VarChar, 30);
            param[1].Value = اسم_المنتج;

            param[2] = new SqlParameter("@الكمية_المخزنة", SqlDbType.Int);
            param[2].Value = الكمية_المخزنة;

            param[3] = new SqlParameter("@السعر", SqlDbType.VarChar, 50);
            param[3].Value = السعر;

            param[4] = new SqlParameter("@صورة_المنتج", SqlDbType.Image);
            param[4].Value = صورة_المنتج;

            param[5] = new SqlParameter("@رقم_الصنف", SqlDbType.Int);
            param[5].Value = رقم_الصنف;

            param[6] = new SqlParameter("@رقم_مسئول_المبيعات", SqlDbType.Int);
            param[6].Value = رقم_مسئول_المبيعات;

            param[7] = new SqlParameter("@تاريخ_التسحيل", SqlDbType.DateTime);
            param[7].Value = تاريخ_التسحيل;

            param[8] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[8].Value = Criterion;

            DAL.ExecuteCommand("ADD_PRODUCTS", param);
            DAL.Close();
        }



            // تعديل
        public void EDIT_PRODUCTS(string رقم_المنتج, string اسم_المنتج, int الكمية_المخزنة,
            string السعر, byte[] صورة_المنتج, int رقم_الصنف, int رقم_مسئول_المبيعات, DateTime تاريخ_التسحيل, string Criterion, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];

           

            param[0] = new SqlParameter("@اسم_المنتج", SqlDbType.VarChar, 30);
            param[0].Value = اسم_المنتج;

            param[1] = new SqlParameter("@الكمية_المخزنة", SqlDbType.Int);
            param[1].Value = الكمية_المخزنة;

            param[2] = new SqlParameter("@السعر", SqlDbType.VarChar, 50);
            param[2].Value = السعر;

            param[3] = new SqlParameter("@صورة_المنتج", SqlDbType.Image);
            param[3].Value = صورة_المنتج;

            param[4] = new SqlParameter("@رقم_الصنف", SqlDbType.Int);
            param[4].Value = رقم_الصنف;

            param[5] = new SqlParameter("@رقم_مسئول_المبيعات", SqlDbType.Int);
            param[5].Value = رقم_مسئول_المبيعات;

            param[6] = new SqlParameter("@تاريخ_التسحيل", SqlDbType.DateTime);
            param[6].Value = تاريخ_التسحيل;

            param[7] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[7].Value = Criterion;

            param[8] = new SqlParameter("@ID", SqlDbType.Int);
            param[8].Value = ID ;

            param[9] = new SqlParameter("@رقم_المنتج", SqlDbType.VarChar, 30);
            param[9].Value = رقم_المنتج;

            DAL.ExecuteCommand("EDIT_PRODUCTS", param);
            DAL.Close();

        }

       // انشاء دالة جلب البيانات
        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.Close();
            return Dt;
        }


        // اجراء الحذف
        public void DeleteProduct(string رقم_المنتج)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@رقم_المنتج", SqlDbType.VarChar, 30);
            param[0].Value = رقم_المنتج;

            DAL.ExecuteCommand("DeleteProduct", param);
            DAL.Close();

        }

        // انشاء دالة جلب البيانات
        public DataTable VERIFYPRODUCTID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;


            Dt = DAL.SelectData("VERIFYPRODUCTID", param);
            DAL.Close();
            return Dt;
        }
    }
}

