using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe.Controller
{
    class MainController
    {
        public static void LoadForm(Panel pnl, Form frm)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(frm);
        }
        public static void LoadUC(Panel pnl, UserControl uc)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
        }
        public static void ShowPnlControl(Panel a, Panel b,Panel c,Panel d,Panel show)
        {
            a.Visible = false;
            a.SendToBack();
            b.Visible = false;
            b.SendToBack();
            c.Visible = false;
            c.SendToBack();
            d.Visible = false;
            d.SendToBack();
            show.Visible = true;
            show.BringToFront();
        }
    }
}
