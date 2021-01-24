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
            this.pnl_container.SendToBack();
            this.pnl_btn.BringToFront();
        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
