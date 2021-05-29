using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// جلب مجالات الاسماء التى تمكننا من التعامل مع البيانات و SQL Server
using System.Data.SqlClient;
using System.Data;

namespace Sales_Management.BL
{
    class CLS_LOGIN
    {
        // انشاء الدالة التى تنفذ تلاجراء المخزن SP_LOGIN

        public DataTable LOGIN(string اسم_مستخدم, string كلمة_مرور)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@اسم_مستخدم", SqlDbType.VarChar, 8);
            param[0].Value = اسم_مستخدم;

            param[1] = new SqlParameter("@كلمة_مرور", SqlDbType.VarChar, 8);
            param[1].Value = كلمة_مرور;


            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SP_LOGIN", param);
            DAL.Close();
            return Dt;
        }
    }
}
