using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// جلب مجال الاسماء الزى يسمح لنا بالتعامل مع قواعد البيانات من نوع SQL Server
using System.Data.SqlClient;
using System.Data;

namespace Sales_Management.DAL
{
    class DataAccessLayer
    {
        // انشاء كائن الاتصال مع قاعدة البيانات
        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                sqlconnection = new SqlConnection("Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=false; User ID = " + Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");
                    
            }
            else
            {
                sqlconnection = new SqlConnection("Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            }
            
        }

        // انشاء اجراء فتح الاتصال
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        // انشاء اجراء اغلاق الاتصال
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        // انشاء دالة قراءة البيانات من قاعدة البيانات
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.LongLength; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // انشاء اجراء ارسال البيانات (عمليات الاضافة - التعديل - الحذف) الى قاعدة البيانات
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
