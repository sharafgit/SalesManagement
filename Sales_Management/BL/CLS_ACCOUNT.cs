using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class CLS_ACCOUNT
    {
        // اجراء الاضافة
        public void ADD_ACCOUNT(string الاسم,
            string العنوان, DateTime تاريخ_الميلاد, string البريد_الالكترونى, string اسم_مستخدم, string كلمة_مرور)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            

            param[0] = new SqlParameter("@الاسم", SqlDbType.VarChar, 50);
            param[0].Value = الاسم;

            param[1] = new SqlParameter("@العنوان", SqlDbType.VarChar, 100);
            param[1].Value = العنوان;

            param[2] = new SqlParameter("@تاريخ_الميلاد", SqlDbType.DateTime);
            param[2].Value = تاريخ_الميلاد;

            param[3] = new SqlParameter("@البريد_الالكترونى", SqlDbType.VarChar, 25);
            param[3].Value = البريد_الالكترونى;

            param[4] = new SqlParameter("@اسم_مستخدم", SqlDbType.VarChar, 8);
            param[4].Value = اسم_مستخدم;

            param[5] = new SqlParameter("@كلمة_مرور", SqlDbType.VarChar, 8);
            param[5].Value = كلمة_مرور;

            DAL.ExecuteCommand("ADD_ACCOUNT", param);
            DAL.Close();
        }

        // اجراء الاضافة
        public void ADD_ACCOUNT_TEL(int رقم_المحاسب,
            string التليفون)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@رقم_المحاسب", SqlDbType.Int);
            param[0].Value = رقم_المحاسب;


            

            param[1] = new SqlParameter("@التليفون", SqlDbType.VarChar, 20);
            param[1].Value = التليفون;



            DAL.ExecuteCommand("ADD_ACCOUNT_TEL", param);
            DAL.Close();
        }


        // انشاء دالة جلب البيانات
        public DataTable GET_ALL_ACCOUNTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_ACCOUNTS", null);
            DAL.Close();
            return Dt;
        }
    }
}
