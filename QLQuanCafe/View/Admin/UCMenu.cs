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
using System.IO;

namespace QLQuanCafe.View.Admin
{
    public partial class UCMenu : UserControl
    {
        private string tk;
        private string mk;
        DataTable Menu = null;
        public UCMenu(string tk, string mk)
        {

            InitializeComponent();
            dgv_Product.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Product.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Product.BackgroundColor = Color.FromArgb(242, 232, 196);
            this.tk = tk;
            this.mk = mk;
            DataSet menu = cShared.Menu_View(tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }
        public void loadF_B(DataTable data)
        {
            this.dgv_Product.Rows.Clear();
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                Image Img;
                string filename = Path.Combine(dir + "\\" + item[2]);
                Img = Image.FromFile(filename);
                Img = new Bitmap(Img, new Size(70, 70));
                dgv_Product.Rows.Add(item[0], item[1], item[8], Img, item[7], item[5]);
            }
        }
        private void rbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.Menu_View(tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }



        private void rbtn_F_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimFandB(rbtn_F.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_B_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimFandB(rbtn_B.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Breakfast_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai(rbtn_Breakfast.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Lunch_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai(rbtn_Lunch.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Nosh_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai(rbtn_Nosh.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }
        private void rbtn_Coffee_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai("Coffee", tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Expresso_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai(rbtn_Expresso.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_IceBlended_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai("Ice Blended", tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Milktea_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai("Milk tea", tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Tea_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai("Tea", tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void rbtn_Yogurt_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMontheoLoai("Yogurt", tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMon(this.txt_Search.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgv_Product.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm_Manager.idMon = id;
            var TenMon = dgv_Product.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm_Manager.TenMon = TenMon;
            this.dgv_Product.Refresh();
            this.dgv_Product.Update();
        }
    }
}
