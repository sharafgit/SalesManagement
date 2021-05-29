using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class CLS_ACCOUNTS
    {
        // اجراء الاضافة
        public void ADD_ACCOUNTS5(int رقم_المحاسب, string التليفون, string الاسم,
            string العنوان, DateTime تاريخ_الميلاد, string البريد_الالكترونى, string اسم_مستخدم, string كلمة_مرور)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@رقم_المحاسب", SqlDbType.Int);
            param[0].Value = رقم_المحاسب;

            param[1] = new SqlParameter("@التليفون", SqlDbType.VarChar, 20);
            param[1].Value = التليفون;

            param[2] = new SqlParameter("@الاسم", SqlDbType.VarChar,50);
            param[2].Value = الاسم;

            param[3] = new SqlParameter("@العنوان", SqlDbType.VarChar, 100);
            param[3].Value = العنوان;

            param[4] = new SqlParameter("@تاريخ_الميلاد", SqlDbType.DateTime);
            param[4].Value = تاريخ_الميلاد;

            param[5] = new SqlParameter("@البريد_الالكترونى", SqlDbType.VarChar,25);
            param[5].Value = البريد_الالكترونى;

            param[6] = new SqlParameter("@اسم_مستخدم", SqlDbType.VarChar,8);
            param[6].Value = اسم_مستخدم;

            param[7] = new SqlParameter("@كلمة_مرور", SqlDbType.VarChar,8);
            param[7].Value = كلمة_مرور;

            DAL.ExecuteCommand("ADD_ACCOUNTS5", param);
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
