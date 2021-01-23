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

namespace QLQuanCafe
{
    public partial class frm_AddMenu : Form
    {
        private string link, image, tk, mk;

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

        public string err;

        private void btn_Price_Click(object sender, EventArgs e)
        {
            var id_Mon = cShared.MaMon(txt_Name.Text, tk, mk).Tables[0].Rows[0][0].ToString();
            if(id_Mon!="")
            {
                if(cb_Size.Text!=""&&txt_Price.Text!="")
                {
                    var price=float.Parse(txt_Price.Text);
                    var checkSize = cManager.checkSize(id_Mon, cb_Size.Text, tk, mk).Tables[0].Rows[0][0].ToString();
                    if (int.Parse(checkSize) == 0)
                    {
                        cManager.ThemSize(id_Mon, cb_Size.Text, price, ref err, tk, mk);
                        if (err == null)
                        {
                            MessageBox.Show("Thêm Size và giá thành công!!!");
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
                        MessageBox.Show("Size đã có!\nNhập size khác!!!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin giá và size trước khi thêm!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Thêm món trước khi thêm size và giá!!!");
                return;
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_AddMenu_Click_1(object sender, EventArgs e)
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
                cManager.ThemMenu(txt_Name.Text, link_db, f_b, loai, ref err, tk, mk);
                if (err == null)
                {
                    File.Copy(link, dir, true);
                    MessageBox.Show("Thêm món thành công");
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

        private void cb_FandB_SelectedIndexChanged_1(object sender, EventArgs e)
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

        public frm_AddMenu(string tk, string mk)
        {
            InitializeComponent();
            ptb_LoadImg.SizeMode = PictureBoxSizeMode.Zoom;
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            this.tk = tk;
            this.mk = mk;
            this.txt_Name.ReadOnly = false;
        }


    }
}
