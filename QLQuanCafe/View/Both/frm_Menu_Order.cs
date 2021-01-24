using QLQuanCafe.Controller;
using QLQuanCafe.View.Both;
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
    public partial class frm_Menu_Order : Form
    {
        public static string phone="";
        private string Id_Staff;
        private string FullName;
        private string tk;
        private string mk;
        public string err;
        DataTable Menu = null;
        public frm_Menu_Order(string Id_Staff, string FullName,string tk, string mk)
        {
            InitializeComponent();
            dgv_Product.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Product.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Product.BackgroundColor = Color.FromArgb(242, 232, 196);
            var x = Id_Staff.Substring(0, 2);
            if(x=="QL")
            {
                btn_BackToManager.Visible = true;
            }
            else
            {
                btn_BackToManager.Visible = false;
            }
            UCOrder uCOrder = new UCOrder(tk, mk);
            this.pnl_Order.Controls.Add(uCOrder);
            this.Id_Staff = Id_Staff;
            this.FullName = FullName;
            this.lbl_Staff_Id.Text = Id_Staff;
            this.lbl_Staff_Name.Text = FullName;
            this.tk = tk;
            this.mk = mk;
            DataSet menu = cShared.Menu_View(tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
            this.Close();
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

        private void rbtn_All_CheckedChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.Menu_View( tk, mk);
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

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            DataSet menu = cShared.TimMon(this.txt_Search.Text, tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void btn_EditInformation_Click(object sender, EventArgs e)
        {
            frm_StaffEditInformation frm = new frm_StaffEditInformation(Id_Staff, tk, mk);
            frm.Show();
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(chb_OutofStock.Checked == true)
            {
                return;
            }    
            if(phone=="" )
            {
                MessageBox.Show("Mời nhập số điện thoại khách hàng");
                return;
            }    

            var ID = dgv_Product.Rows[e.RowIndex].Cells[0].Value.ToString();
            var name = cShared.TimMonTheoMa(ID, tk, mk).Tables[0].Rows[0][0].ToString();
            var size = dgv_Product.Rows[e.RowIndex].Cells[4].Value.ToString();
            var result = MessageBox.Show("Bạn có muốn order " + name +" size "+size+ " không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cStaff.ThemTemp(ID, size,phone,lbl_Staff_Id.Text, ref err, tk, mk);
                if(err == null)
                {
                    MessageBox.Show("Thêm món vào order thành công!!");
                    UCOrder uCOrder = new UCOrder(tk, mk);
                    MainController.LoadUC(pnl_Order, uCOrder);
                }   
                else
                {
                    MessageBox.Show(err);
                    err = null;return;
                }    
            }
        }

        private void btn_Top5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Top5inMenu frm = new frm_Top5inMenu(tk, mk);
            frm.ShowDialog();
            this.Close();
        }

        private void btn_OutOfStock_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for(int i=0;i<dgv_Product.Rows.Count-1;i++)
            {
                var item = dgv_Product.Rows[i];
                if((bool)item.Cells[5].Value==false)
                {
                    cShared.suastatus(item.Cells[0].Value.ToString(), ref err, tk, mk);
                    if(err==null )
                    {
                        flag = true;
                    }
                    else 
                    {
                        MessageBox.Show(err);
                        err = null;
                        return;
                    }
                }    
            }    
            if(flag==true)
            {
                MessageBox.Show("Cập nhật trạng thái thành công!!!");
            }
            DataSet menu = cShared.Menu_View(tk, mk);
            Menu = menu.Tables[0];
            loadF_B(Menu);
        }

        private void btn_ResetStatus_Click(object sender, EventArgs e)
        {
            cShared.resetstatus(ref err, tk, mk);
            if(err== null)
            {
                MessageBox.Show("Cập nhật trạng thái thành công!!!");
                DataSet menu = cShared.Menu_View(tk, mk);
                Menu = menu.Tables[0];
                loadF_B(Menu);
            }
            else
            {
                MessageBox.Show(err);
                err = null;
                return;
            }
        }

        private void btn_BackToManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Manager frm = new frm_Manager(Id_Staff, FullName, tk, mk);
            frm.ShowDialog();
            this.Close();
        }
    }
}
