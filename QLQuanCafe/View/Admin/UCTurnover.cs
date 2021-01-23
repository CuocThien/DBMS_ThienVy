using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe.View.Admin
{
    public partial class UCTurnover : UserControl
    {
        private string tk, mk;
        public UCTurnover(DataTable data , string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            if(data.Rows.Count>0)
            {
                for(int i=0;i<data.Rows.Count;i++)
                {
                    var item = data.Rows[i];
                    dgv_Turnover.Rows.Add(DateTime.Parse(item[0].ToString()).ToShortDateString(), price(item[1].ToString()), price(item[2].ToString()), price(item[3].ToString()), price(item[4].ToString()));
                }    
            }    
        }
        public string price(string price)
        {
            var gia = float.Parse(price).ToString("N0");
            return gia;
        }
    }
}
