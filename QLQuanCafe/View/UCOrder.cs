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
    public partial class UCOrder : UserControl
    {
        public UCOrder()
        {
            InitializeComponent();
            dgv_Order.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Order.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Order.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
