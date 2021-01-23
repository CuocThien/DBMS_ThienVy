using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe
{
    class Login
    {
        
        public static DataSet ktDangNhap(string tk, string mk)
        {
            DBControl db = new DBControl(null, null);
            return db.ExecuteQueryDataSet("select dbo.func_Login('" + tk + "','" + mk +"')", CommandType.Text);
        }
    }
}
