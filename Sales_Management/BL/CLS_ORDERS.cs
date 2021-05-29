using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Management.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return Dt;
        }

        public DataTable GET_LAST_ORDER_FOR_PRINT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LAST_ORDER_FOR_PRINT", null);
            DAL.Close();
            return Dt;
        }

        //  اضافة بيانات الفاتورة
        public void ADD_ORDER(int رقم_الفاتورة, DateTime تاريخ_الفاتورة, string ملاحظات,
            int رقم_العميل, int رقم_محاسب)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@رقم_الفاتورة", SqlDbType.Int);
            param[0].Value = رقم_الفاتورة;

            param[1] = new SqlParameter("@تاريخ_الفاتورة", SqlDbType.DateTime);
            param[1].Value = تاريخ_الفاتورة;

            param[2] = new SqlParameter("@ملاحظات", SqlDbType.VarChar, 50);
            param[2].Value = ملاحظات;

            param[3] = new SqlParameter("@رقم_العميل", SqlDbType.Int);
            param[3].Value = رقم_العميل;

            param[4] = new SqlParameter("@رقم_محاسب", SqlDbType.Int);
            param[4].Value = رقم_محاسب;

            DAL.ExecuteCommand("ADD_ORDER", param);
            DAL.Close();
        }

        //  اضافة بيانات تفاصيل الفاتورة
        public void ORDER_DETAILS(string رقم_المنتج, int رقم_الفاتورة, int الكمية,
            float نسبة_الخصم, string الثمن_قبل_الخصم, string الثمن_بعد_الخصم)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@رقم_المنتج", SqlDbType.VarChar,30);
            param[0].Value = رقم_المنتج;

            param[1] = new SqlParameter("@رقم_الفاتورة", SqlDbType.Int);
            param[1].Value = رقم_الفاتورة;

            param[2] = new SqlParameter("@الكمية", SqlDbType.Int);
            param[2].Value = الكمية;

            param[3] = new SqlParameter("@نسبة_الخصم", SqlDbType.Float);
            param[3].Value = نسبة_الخصم;

            param[4] = new SqlParameter("@الثمن_قبل_الخصم", SqlDbType.VarChar,50);
            param[4].Value = الثمن_قبل_الخصم;

            param[5] = new SqlParameter("@الثمن_بعد_الخصم", SqlDbType.VarChar, 50);
            param[5].Value = الثمن_بعد_الخصم;

            DAL.ExecuteCommand("ORDER_DETAILS", param);
            DAL.Close();
        }

        public DataTable SearchOrders(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;



            Dt = DAL.SelectData("SearchOrders", param);
            DAL.Close();
            return Dt;
        }

        public DataTable VerifyQty(string رقم_المنتج, int الكمية_المخزنة)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@رقم_المنتج", SqlDbType.VarChar, 30);
            param[0].Value = رقم_المنتج;

            param[1] = new SqlParameter("@الكمية_المخزنة", SqlDbType.Int);
            param[1].Value = الكمية_المخزنة;




            Dt = DAL.SelectData("VerifyQty", param);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Order_Detials(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            Dt = DAL.SelectData("Get_Order_Detials", param);
            DAL.Close();
            return Dt;
        }
    }
}
