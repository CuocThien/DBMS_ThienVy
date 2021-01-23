using QLQuanCafe.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQuanCafe
{
    public partial class frm_AddCustomer : Form
    {
        private string phone, tk, mk;
        public string err;

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Phone.Text != "" && txt_Fullname.Text != "" && txt_Address.Text != "")
            {
                cStaff.ThemKH(txt_Fullname.Text, phone, txt_Address.Text, ref err, tk, mk);
                if (err == null)
                {
                    MessageBox.Show("Thêm khách hàng thành công!!!");
                    this.Dispose();
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
                MessageBox.Show("Nhập đầy đủ thông tin đăng ký!!!");
            }
        }

        public frm_AddCustomer(string phone, string tk, string mk)
        {
            InitializeComponent();
            this.phone = phone;
            this.tk = tk;
            this.mk = mk;
            txt_Phone.Text = phone;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
