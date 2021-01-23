using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Controller
{
    class cStaff
    {
        public static DataSet timMaNV(string username)
        {
            DBConnection db = new DBConnection(null, null);
            return db.ExecuteQueryDataSet("select * from [dbo].[func_timMaNV] ('" + username + "')",CommandType.Text);
        }
        public static DataSet thongtin(string Id_User)
        {
            DBConnection db = new DBConnection(null, null);
            return db.ExecuteQueryDataSet("select * from dbo.func_thongtin ('" + Id_User + "')", CommandType.Text);
        }
        public static DataSet timkh(string sdt,string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from dbo.func_timkh ('" + sdt + "')", CommandType.Text);
        }

        public static void ThemKH(string name,string phone, string address, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemKH N'" + name + "',N'"+phone+"',N'"+address+"'", CommandType.Text, ref err);
        }
        public static DataSet Temp_view()
        {
            DBConnection db = new DBConnection(null, null);
            return db.ExecuteQueryDataSet("select * from [dbo].[Temp_view]", CommandType.Text);
        }
        public static void ThemTemp(string id, string size, string phone,string Id_Staff,  ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemTemp N'" + id + "',N'" + size + "',N'"+phone+"',N'"+Id_Staff+"'", CommandType.Text, ref err);
        }
        public static void SuaTemp(string id, string size,string quantity, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_SuaTemp N'" + id + "',N'" + size + "',"+quantity, CommandType.Text, ref err);
        }
        public static void XoaMonTemp(string id, string size, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_XoaMonTemp N'" + id + "',N'" + size + "'", CommandType.Text, ref err);
        }
        public static DataSet bill_view()
        {
            DBConnection db = new DBConnection(null, null);
            return db.ExecuteQueryDataSet("select * from [dbo].[bill_view]", CommandType.Text);
        }
        public static void ThemOrder(ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemOrder ", CommandType.Text, ref err);
        }
    }
}
