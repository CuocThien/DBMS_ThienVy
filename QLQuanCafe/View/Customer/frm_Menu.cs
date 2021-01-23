using QLQuanCafe.Controller;
using QLQuanCafe.View.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe.View.Customer
{
    public partial class frm_Menu : Form
    {
        public frm_Menu(string tk,string mk)
        {
            InitializeComponent();
            UCMenu uCMenu = new UCMenu(tk, mk);
            MainController.LoadUC(pnl_container, uCMenu);
        }
    }
}
