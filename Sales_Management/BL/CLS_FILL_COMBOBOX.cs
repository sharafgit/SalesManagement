using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Sales_Management.BL
{
    class CLS_FILL_COMBOBOX
    {
        // تعبئة ComboBox

        // انشاء دالة جلب البيانات
        public DataTable GET_ALL_SALESMAN()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SALESMAN", null);
            DAL.Close();
            return Dt;

        }


        // تعبئة ComboBox

        // انشاء دالة جلب البيانات
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.Close();
            return Dt;

        }

        // تعبئة ComboBox

        // انشاء دالة جلب البيانات
        public DataTable GET_ALL_ACCOUNTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_ACCOUNTS", null);
            DAL.Close();
            return Dt;
        }

        // تعبئة ComboBox

        // انشاء دالة جلب البيانات
        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.Close();
            return Dt;
        }
    }
}
