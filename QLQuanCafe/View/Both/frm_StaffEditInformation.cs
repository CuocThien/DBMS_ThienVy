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
    public partial class frm_StaffEditInformation : Form
    {
        private string id;
        private string tk;
        private string mk;
        public string err;
        public frm_StaffEditInformation(string id, string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.id = id;
            var infor = cStaff.thongtin(id).Tables[0].Rows[0];
            this.txt_Fullname.Text = infor[1].ToString();
            this.dtp_DoB.Value = DateTime.Parse(infor[2].ToString());
            this.txt_Address.Text = infor[4].ToString();
            this.txt_Phone.Text = infor[3].ToString();
            this.txt_Position.Text = infor[5].ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            frm_ChangePassword frm = new frm_ChangePassword(id,tk,mk);
            frm.Show();
            this.Dispose();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            var dob = dtp_DoB.Value.ToString("MM-dd-yyyy");
            cShared.SuaNV(id,this.txt_Fullname.Text, dob, this.txt_Phone.Text, this.txt_Address.Text, this.txt_Position.Text, ref err, tk, mk);
            if(err==null)
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công!!!");
                this.Dispose();
            } 
            else
            {
                MessageBox.Show(err);
                err = null;
                return;
            }    
        }
    }
}
