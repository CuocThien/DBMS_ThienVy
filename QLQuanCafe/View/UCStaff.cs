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
    public partial class UCStaff : UserControl
    {
        public UCStaff()
        {
            InitializeComponent();

            dgv_Staff.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Staff.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
