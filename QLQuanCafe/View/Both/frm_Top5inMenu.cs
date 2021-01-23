using QLQuanCafe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe.View.Both
{
    public partial class frm_Top5inMenu : Form
    {
        private string tk, mk;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user = cStaff.timMaNV(tk).Tables[0].Rows[0][3].ToString();
            var infor = cStaff.thongtin(user).Tables[0].Rows[0];
            var x = infor[0].ToString().Substring(0, 2);
            if (x=="TN")
            {
                frm_Menu_Order frm = new frm_Menu_Order(infor[0].ToString(), infor[1].ToString(), tk, mk);
                frm.ShowDialog();
                this.Close();
            }    
            else
            {
                frm_Manager frm = new frm_Manager(infor[0].ToString(), infor[1].ToString(), tk, mk);
                frm.ShowDialog();
                this.Close();
            }    
        }

        public frm_Top5inMenu(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            DataTable data = cShared.Top5Mon(tk, mk).Tables[0];
            if (data.Rows.Count > 0)
            {
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    var item = data.Rows[i];
                    Image Img;
                    string filename = Path.Combine(dir + "\\" + item[2]);
                    Img = Image.FromFile(filename);
                    Img = new Bitmap(Img, new Size(70, 70));
                    dgv_Product.Rows.Add(item[0], item[1], Img, item[3], item[4], item[5],item[7]);
                }
            }
        }
    } 
}
