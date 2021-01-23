using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Controller
{
    class cManager
    {
        public static DataSet DSNhanVien_view(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from DSNhanvien_view ", CommandType.Text);
        }
        public static DataSet TimNV(string key, int chosse, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_TimNV (N'"+key+"',"+chosse+")", CommandType.Text);
        }
        public static DataSet checkid(string id, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_checkid (N'" + id +  "')", CommandType.Text);
        }
        public static DataSet checkUsername(string username, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_checkUsername (N'" + username + "')", CommandType.Text);
        }
        public static DataSet checkpass(string pass,string comfirm, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_checkpass (N'" + pass+"',N'"+comfirm + "')", CommandType.Text);
        }
        public static void ThemNV(string id,string name, string
            date,string phone,string address, string position,ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemNV N'" + id + "',N'" + name + "','" + date + "',N'" + phone + "',N'" + address + "',N'" + position + "'", CommandType.Text,ref err);
        }
        public static void ThemAccountNV(string username, string password, string iduser, string role, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemAccountNV N'" + username + "',N'" + password + "',N'" + iduser + "',N'" + role + "'", CommandType.Text, ref err);
        }
        public static void ThemLoginNV(string username, string password, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemLoginNV N'" + username + "',N'" + password +  "'", CommandType.Text, ref err);
        }
        public static void XoaNV(string id_user, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_XoaNV N'" + id_user+ "'", CommandType.Text, ref err);
        }
        public static void XoaAccount(string id_user, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_XoaAccount N'" + id_user + "'", CommandType.Text, ref err);
        }
        public static void xoalogin(string username, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_xoalogin N'" + username + "'", CommandType.Text, ref err);
        }
        public static void ThemMenu(string name,string image,string FandB,string catogory, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemMenu N'" + name + "',N'"+image+"',N'"+FandB+"',N'"+catogory+"'", CommandType.Text, ref err);
        }
        public static void ThemSize(string id, string size, float price, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_ThemSize N'" + id + "',N'" + size + "'," + price, CommandType.Text, ref err);
        }
        public static DataSet checkSize(string name, string size, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_checkSize (N'" + name + "',N'" + size + "')", CommandType.Text);
        }
        public static DataSet checkname(string name, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select dbo.func_checkname (N'" + name + "')", CommandType.Text);
        }
        public static void SuaMenu(string id, string name, string image, string FandB, string catogory, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_SuaMenu N'"+id+"',N'" + name + "',N'" + image + "',N'" + FandB + "',N'" + catogory + "'", CommandType.Text, ref err);
        }
        public static void Suagia(string id, string size, float price, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_Suagia N'" + id + "',N'" + size + "'," + price, CommandType.Text, ref err);
        }
        public static void xoasize(string id, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_xoasize N'" + id +"'", CommandType.Text, ref err);
        }
        public static void XoaMenu(string id, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_XoaMenu N'" + id + "'", CommandType.Text, ref err);
        }
        public static DataSet DSLuong_view(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from DSLuong_view ", CommandType.Text);
        }
        public static void Luong(string id,string basicSalary, string fine, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_Luong N'" + id + "','"+basicSalary+"','"+fine+"'", CommandType.Text, ref err);
        }
        public static DataSet Luongnv(string id, string date, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_Luongnv (N'" + id + "','" + date +  "')", CommandType.Text);
        }
        public static DataSet Top1nhanvien(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_Top1nhanvien ()", CommandType.Text);
        }
        public static DataSet timTop1nhanvien(string date,string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_timTop1nhanvien ('"+date+"')", CommandType.Text);
        }
        public static DataSet DoanhSo_view(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from DoanhSo_view ", CommandType.Text);
        }
        public static DataSet Timdoanhthu(string date,string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_Timdoanhthu ('" + date+"')", CommandType.Text);
        }
        public static void Doanhthu(string date, string outgoing, ref string err, string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            db.MyExecuteNonQuery("exec proc_Doanhthu N'" + date + "','" + outgoing + "'", CommandType.Text, ref err);
        }
        public static DataSet DSKH_view(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from DSKH_view ", CommandType.Text);
        }
        public static DataSet Top3KH(string tk, string mk)
        {
            DBConnection db = new DBConnection(tk, mk);
            return db.ExecuteQueryDataSet("select * from func_Top3KH ()", CommandType.Text);
        }
    }
}
