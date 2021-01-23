using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.Controller;

namespace QLQuanCafe.View.Admin
{
    public partial class UCTopStaff : UserControl
    {
        DataTable Topstaff = null;
        private string tk, mk;
        public UCTopStaff(DataTable data,string tk, string mk)
        {
            InitializeComponent();
            Topstaff = data;
            this.tk = tk;
            this.mk = mk;
            if(data.Rows.Count>0)
            {
                for ( int i=0;i<data.Rows.Count;i++)
                {
                    var item = data.Rows[i];
                    var staff = cStaff.thongtin(item[1].ToString()).Tables[0].Rows[0];
                    dgv_TopStaff.Rows.Add(item[1], staff[1], DateTime.Parse(staff[2].ToString()).ToShortDateString(), staff[3], item[2], DateTime.Parse(item[0].ToString()).ToShortDateString());
                }    
            }    
        }

    }
}
