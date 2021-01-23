using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe
{
    public partial class UCSalary : UserControl
    {
        public UCSalary()
        {
            InitializeComponent();
            dgv_Salary.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Salary.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Salary.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
