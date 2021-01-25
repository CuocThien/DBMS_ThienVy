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

namespace QLQuanCafe.View.Admin
{
    public partial class frm_ComputeSalary : Form
    {
        private string id, tk, mk;
        public string err;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public frm_ComputeSalary(string id, string tk, string mk)
        {
            InitializeComponent();
            this.id = id;
            this.tk = tk;
            this.mk = mk;
            this.lbl_Name.Text=cStaff.thongtin(id).Tables[0].Rows[0][1].ToString();
        }

        private void btn_Luong_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("MM-dd-yyyy");
            var check = cManager.checksalary(id, date, tk, mk).Tables[0].Rows[0][0].ToString();
            if (check == "1")
            {
                MessageBox.Show("Đã tính lương tháng này cho nhân viên");
                return;
            }    
            cManager.Luong(id, txt_BasicSalary.Text, txt_Fine.Text, ref err, tk, mk);
            if(err==null)
            {
                MessageBox.Show("Hoàn thành!!!");
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
