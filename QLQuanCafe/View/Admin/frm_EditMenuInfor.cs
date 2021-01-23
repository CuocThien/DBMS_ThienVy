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

namespace QLQuanCafe.View.Admin
{
    public partial class frm_EditMenuInfor : Form
    {
        private string link, image, tk, mk,name,id;
        DataTable Menu = null;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string F_B, Loai, f_b, loai;
            if (cb_FandB.Text == "" || cb_catogories.Text == "" || image == null || txt_Name.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin để thêm món!!!");
                return;
            }
            F_B = cb_FandB.Text;
            Loai = cb_catogories.Text;
            f_b = cb_FandB.Text;
            loai = cb_catogories.Text;
            if (cb_FandB.Text == "Đồ Ăn")
            {
                F_B = "F";
            }
            else
            {
                F_B = "B";
            }
            if (cb_catogories.Text == "Ăn Sáng")
            {
                Loai = "Breakfast";
            }
            else if (cb_catogories.Text == "Ăn Trưa/Chiều")
            {
                Loai = "Lunch";
            }
            else
            {
                Loai = "Nosh";
            }
            string dir;
            if (F_B == "F")
            {
                dir = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\" + F_B + "\\" + Loai + "\\" + image;
            }
            else
            {
                dir = Path.GetDirectoryName(Application.ExecutablePath) + "\\Image\\" + F_B + "\\" + loai + "\\" + image;
            }
            string link_db;
            if (F_B == "F")
            {
                link_db = "Image/" + F_B + "/" + Loai + "/" + image;
            }
            else
            {
                link_db = "Image/" + F_B + "/" + loai + "/" + image;
            }
            
            var checkname = cManager.checkname(txt_Name.Text, tk, mk).Tables[0].Rows[0][0].ToString();
            if (int.Parse(checkname) == 0)
            {
                int i = 0;
                while(i<3)
                {
                    if (i == 0 && txt_PriceS.Enabled==true) { 
                        cManager.Suagia(id, "S", float.Parse(txt_PriceS.Text), ref err, tk, mk); 
                        if(err!=null)
                        {
                            MessageBox.Show(err);
                            err = null;
                            return;
                        }    
                    }
                    if (i == 1 && txt_PriceM.Enabled == true) {
                        cManager.Suagia(id, "M", float.Parse(txt_PriceM.Text), ref err, tk, mk);
                        if (err != null)
                        {
                            MessageBox.Show(err);
                            err = null;
                            return;
                        }
                    }
                    if (i == 2 && txt_PriceL.Enabled == true) {
                        cManager.Suagia(id, "L", float.Parse(txt_PriceL.Text), ref err, tk, mk);
                        if (err != null)
                        {
                            MessageBox.Show(err);
                            err = null;
                            return;
                        }
                    }
                    i++;
                }    
                cManager.SuaMenu(id,txt_Name.Text, link_db, f_b, loai, ref err, tk, mk);
                if (err == null)
                {
                    File.Copy(link, dir, true);
                    MessageBox.Show("Sửa thông tin thành công");
                    txt_Name.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show(err);
                    err = null;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Món đã tồn tại trong Menu!!");
                return;
            }
        }

        public string err;
        private void cb_FandB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_FandB.Text == "Đồ Ăn")
            {
                cb_catogories.Items.Clear();
                cb_catogories.Items.Add("Ăn Sáng");
                cb_catogories.Items.Add("Ăn Trưa/Chiều");
                cb_catogories.Items.Add("Ăn Vặt");
            }
            else
            {
                cb_catogories.Items.Clear();
                cb_catogories.Items.Add("Coffee");
                cb_catogories.Items.Add("Expresso");
                cb_catogories.Items.Add("IceBlended");
                cb_catogories.Items.Add("MilkTea");
                cb_catogories.Items.Add("Tea");
                cb_catogories.Items.Add("Yogurt");
            }
        }

        private void btn_AddImg_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);

                // Gán ảnh
                ptb_LoadImg.Image = img;

                var x = openFileDialog1.FileName.Split('\\');
                image = x[x.Count() - 1].ToString();
                link = openFileDialog1.FileName;
            }
        }

        public frm_EditMenuInfor(string id,string name,string tk,string mk)
        {
            InitializeComponent();
            ptb_LoadImg.SizeMode = PictureBoxSizeMode.Zoom;
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            this.tk = tk;
            this.mk = mk;
            this.name = name;
            this.id = id;
            Menu=cShared.TimMon(name, tk, mk).Tables[0];
            var Mon = Menu.Rows[0];
            txt_Name.Text = Mon[1].ToString();
            cb_FandB.Text = Mon[3].ToString();
            cb_catogories.Text = Mon[4].ToString();
            int i = 0;
            while (i<Menu.Rows.Count)
            {
                if (i == 0) { txt_PriceS.Text = Menu.Rows[Menu.Rows.Count - 1 - i][7].ToString(); txt_PriceS.Enabled = true; }
                if (i == 1) { txt_PriceM.Text = Menu.Rows[Menu.Rows.Count - 1 - i][7].ToString(); txt_PriceM.Enabled = true; }
                if (i == 2) { txt_PriceL.Text = Menu.Rows[Menu.Rows.Count - 1 - i][7].ToString(); txt_PriceL.Enabled = true; }
                i++;
            }
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            Image Img;
            string filename = Path.Combine(dir + "\\" + Mon[2]);
            Img = Image.FromFile(filename);
            ptb_LoadImg.Image = Img;
        }

    }
}
