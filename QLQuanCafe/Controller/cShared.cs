using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Controller
{
    class cShared
    {
        public static DataSet Menu_View(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from Menu_view ", CommandType.Text);
        }
        public static DataSet TimMontheoLoai(string loai, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_TimMontheoLoai (N'" + loai + "')", CommandType.Text);
        }
        public static DataSet TimFandB(string loai, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_TimFandB (N'" + loai + "')", CommandType.Text);
        }
        public static DataSet TimMon(string ten, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_TimMon (N'" + ten + "')", CommandType.Text);
        }
        public static void SuaNV(string id, string name, string
            date, string phone, string address, string position, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_SuaNV N'" + id + "',N'" + name + "','" + date + "',N'" + phone + "',N'" + address + "',N'" + position + "'", CommandType.Text, ref err);
        }
        public static void SuaMK(string id_User, string password, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_SuaMK N'" + id_User + "',N'" + password + "'", CommandType.Text, ref err);
        }
        public static void doimksql(string username, string passold, string passnew, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_doimksql N'" + username + "',N'" + passold + "',N'" + passnew + "'", CommandType.Text, ref err);
        }
        public static DataSet layAccount(string id_User, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_layAccount (N'" + id_User + "')", CommandType.Text);
        }
        public static DataSet MaMon(string name, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_MaMon (N'" + name + "')", CommandType.Text);
        }
        public static DataSet TimMonTheoMa(string id, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from dbo.func_TimMonTheoMa (N'" + id + "')", CommandType.Text);


        }
        public static DataSet Top5Mon(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from dbo.func_Top5Mon ()", CommandType.Text);
        }
        public static void suastatus(string id, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_suastatus N'" + id +  "'", CommandType.Text, ref err);
        }
        public static void resetstatus(ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_resetstatus", CommandType.Text, ref err);
        }
    }
}
