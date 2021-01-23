using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLQuanCafe.Controller;
using QLQuanCafe.View.Admin;
using QLQuanCafe.View.Customer;

namespace QLQuanCafe
{
    public partial class frm_Login : Form
    {
        public string tk;
        public string mk;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.tk = txt_Username.Text;
            this.mk = txt_Password.Text;
            try
            {
                if (this.txt_Username.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Nhập tài khoản!!");
                    return;
                }
                if (this.txt_Password.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Nhập mật khẩu!!");
                    return;
                }
                DataTable ktra = cLogin.ktDangNhap(txt_Username.Text, txt_Password.Text).Tables[0];
                var user = cStaff.timMaNV(txt_Username.Text).Tables[0].Rows[0][3].ToString();
                var infor = cStaff.thongtin(user).Tables[0].Rows[0];
                if (int.Parse(ktra.Rows[0][0].ToString()) == 1)
                {
                    
                    this.Hide();
                    frm_Menu_Order frm = new frm_Menu_Order(infor[0].ToString(), infor[1].ToString(), tk, mk);
                    frm.ShowDialog();
                    this.Close();
                }
                else if (int.Parse(ktra.Rows[0][0].ToString()) == 2)
                {
                    
                    this.Hide();
                    frm_Manager frm = new frm_Manager(infor[0].ToString(), infor[1].ToString(), tk, mk);
                    frm.ShowDialog();
                    this.Close();
                }
                else if (int.Parse(ktra.Rows[0][0].ToString()) == 0)
                {

                    this.Hide();
                    frm_Menu frm = new frm_Menu(tk, mk);
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
