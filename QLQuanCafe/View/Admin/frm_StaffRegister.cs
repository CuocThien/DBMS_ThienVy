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
    public partial class frm_StaffRegister : Form
    {
        private string tk;
        private string mk;
        string err;
        public frm_StaffRegister(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var checkid = cManager.checkid(txt_IdStaff.Text, tk, mk).Tables[0].Rows[0][0];
            if (int.Parse(checkid.ToString()) == 0)
            {
                if (cb_Position.Text == "")
                {
                    MessageBox.Show("Chọn chức vụ cho nhân viên!!!");
                    return;
                }
                var dob = dtp_DoB.Value.ToString("MM-dd-yyyy");
                var checkUsername = cManager.checkUsername(txt_Username.Text, tk, mk).Tables[0].Rows[0][0];
                if (int.Parse(checkUsername.ToString()) == 0)
                {
                    var checkpass = cManager.checkpass(txt_Password.Text, txt_Confirm.Text, tk, mk).Tables[0].Rows[0][0];
                    if (int.Parse(checkpass.ToString()) == 1)
                    {
                        cManager.ThemNV(txt_IdStaff.Text, txt_Fullname.Text, dob, txt_Phone.Text, txt_Address.Text, cb_Position.Text, ref err, tk, mk);
                        cManager.ThemAccountNV(txt_Username.Text, txt_Password.Text, txt_IdStaff.Text, "NV", ref err, tk, mk);
                        if (err == null)
                        {
                            cManager.ThemLoginNV(txt_Username.Text, txt_Password.Text, ref err, tk, mk);
                            if (err == null)
                            {
                                MessageBox.Show("Thêm Nhân viên thành công!!!");
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
                    MessageBox.Show("Tên tài khoản đã tồn tại!! \nNhập lại tên tài khoản khác!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên đã tồn tại!! \nMời nhập lại mã Nhân Viên khác!!!");
                return;
            }
        }
    }
}
