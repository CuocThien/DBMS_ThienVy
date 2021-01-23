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
    public partial class UCManageCustomers : UserControl
    {
        public UCManageCustomers(DataTable data,string tk, string mk)
        {
            InitializeComponent();
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var item = data.Rows[i];
                    dgv_Customers.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
                }
            }
        }
    }
}
