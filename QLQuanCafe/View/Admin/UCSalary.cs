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

namespace QLQuanCafe
{
    public partial class UCSalary : UserControl
    {
        public UCSalary(DataTable data,string tk, string mk)
        {
            InitializeComponent();
            dgv_Salary.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Salary.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Salary.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            if(!(data is null))
            {
                for (int i=0;i<data.Rows.Count;i++)
                {
                    var item = data.Rows[i];
                    var name = cStaff.thongtin(item[0].ToString()).Tables[0].Rows[0][1].ToString();
                    dgv_Salary.Rows.Add(item[0],name,item[2],item[3],item[4],item[5]);
                }    
            }    
        }

    }
}
