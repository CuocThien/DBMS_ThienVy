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
    public partial class frm_ComputeTurnover : Form
    {
        private string tk, mk;
        public string err;
        public frm_ComputeTurnover(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void btn_Compute_Click(object sender, EventArgs e)
        {
            var date = dtp_date.Value.ToString("MM-dd-yyyy");
            var check = cManager.checkPayday(date, tk, mk).Tables[0].Rows[0][0].ToString();
            if(check == "1")
            {
                MessageBox.Show("Tháng này đã tính doanh thu rồi!!!");
                return;
            }    
            if(txt_Outgoing.Text=="")
            {
                MessageBox.Show("Nhập tổng chi trước khi tính doanh thu");
                return;
            }    
            cManager.Doanhthu(date, txt_Outgoing.Text, ref err, tk, mk);
            if(err==null)
            {
                MessageBox.Show("Nhập doanh thu thành công");
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
