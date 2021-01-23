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
    public partial class frm_ChangePassword : Form
    {
        private string id, tk, mk;
        public string err;
        private void btn_Change_Click(object sender, EventArgs e)
        {

            var account = cShared.layAccount(id, tk, mk).Tables[0].Rows[0];
            if (txt_Username.Text == account[1].ToString())
            {
                var checkpass = cManager.checkpass(txt_Password.Text, txt_Confirm.Text, tk, mk).Tables[0].Rows[0][0];
                if (int.Parse(checkpass.ToString()) == 1)
                {
                    cShared.SuaMK(id, txt_Password.Text, ref err, tk, mk);
                    if(err==null)
                    {
                        cShared.doimksql(txt_Username.Text, account[2].ToString(), txt_Password.Text, ref err, tk, mk);
                        if(err==null)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
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
                        MessageBox.Show(err);
                        err = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu và Xác nhận mật khẩu không giống nhau!!!\nMời nhập lại!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nhập sai tên tài khoản!!\nHãy kiểm tra lại tên tài khoản đã nhập");
                return;
            }
        }

        public frm_ChangePassword(string id, string tk, string mk)
        {
            InitializeComponent();
            this.id = id;
            this.tk = tk;
            this.mk = mk;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
