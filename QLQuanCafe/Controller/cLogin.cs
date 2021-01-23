using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Controller
{
    class cLogin
    {
        public static DataSet ktDangNhap(string tk, string mk)
        {
            DBConnection db = new DBConnection(null, null);
            return db.ExecuteQueryDataSet("select * from dbo.func_ktlogin('" + tk + "','" + mk + "')", CommandType.Text);
        }
    }
}
