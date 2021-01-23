using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.Controller;

namespace QLQuanCafe
{
    public partial class UCOrder : UserControl
    {
        private string tk;
        private string mk;
        DataTable KH = null;
        DataTable Bill = null;
        public string err;
        public UCOrder(string tk, string mk)
        {
            InitializeComponent();
            dgv_Order.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Order.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Order.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.tk = tk;
            this.mk = mk;
            this.txt_Phone.Text = frm_Menu_Order.phone;
            this.btn_AddCustumer.Enabled = false;
            DataSet bill = cStaff.Temp_view();
            Bill = bill.Tables[0];
            int check = Bill.Rows.Count;
            if(check>0)
            {
                for(int i=0;i<check;i++)
                {
                    var item = Bill.Rows[i];
                    var name = cShared.TimMonTheoMa(item[1].ToString(), tk, mk).Tables[0].Rows[0][0].ToString();
                    var price = float.Parse(item[4].ToString()).ToString("N0");
                    dgv_Order.Rows.Add(item[1],name,item[2],item[3],price);
                }
                var count = cStaff.bill_view().Tables[0].Rows.Count;
                var total = float.Parse(cStaff.bill_view().Tables[0].Rows[count - 1][4].ToString()).ToString("N0");
                this.txt_TotalPrice.Text = total;
            }
            else
            {
                return;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DataSet kh = cStaff.timkh(txt_Phone.Text, tk, mk);
            KH = kh.Tables[0];
            if(KH.Rows.Count==0)
            {
                MessageBox.Show("Số điện thoại không tồn tại");
                this.btn_AddCustumer.Enabled = true;
                return;
            }    
            else
            {
                txt_Level.Text = KH.Rows[0][5].ToString();
                lbl_CustomerName.Text = KH.Rows[0][1].ToString();

                frm_Menu_Order.phone = this.txt_Phone.Text;
            }    
        }

        private void btn_AddCustumer_Click(object sender, EventArgs e)
        {
            frm_AddCustomer frm = new frm_AddCustomer(txt_Phone.Text,tk,mk);
            frm.Show();
            this.btn_AddCustumer.Enabled = false;
        }

        private void dgv_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (chb_delete.Checked == true)
                {
                    var ID = dgv_Order.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var name = dgv_Order.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var size = dgv_Order.Rows[e.RowIndex].Cells[2].Value.ToString();
                    var result = MessageBox.Show("Bạn có muốn xóa " + name + " \nkhỏi order không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cStaff.XoaMonTemp(ID, size, ref err, tk, mk);
                        if (err == null)
                        {
                            MessageBox.Show("Xóa món khỏi order thành công!!");
                            UCOrder uCOrder = new UCOrder(tk, mk);
                            MainController.LoadUC(pnl_Order, uCOrder);
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
            catch { return; }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var count = dgv_Order.Rows.Count;
            for(int i=0;i<count-1;i++)
            {
                var id = dgv_Order.Rows[i].Cells[0].Value.ToString();
                var size = dgv_Order.Rows[i].Cells[2].Value.ToString();
                var quantity = dgv_Order.Rows[i].Cells[3].Value.ToString();
                cStaff.SuaTemp(id, size,quantity, ref err, tk, mk);
                if(err != null)
                {
                    MessageBox.Show(err);
                    err = null;
                    return;
                }
                else
                {
                    if (i == count - 2)
                    {
                        MessageBox.Show("Sửa số lượng thành công!!");
                        UCOrder uCOrder = new UCOrder(tk, mk);
                        MainController.LoadUC(pnl_Order, uCOrder);
                    }
                }
            }    
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            cStaff.ThemOrder(ref err, tk, mk);
            if(err == null)
            {
                MessageBox.Show("Thanh toán thành công");
                frm_Menu_Order.phone = "";
                UCOrder uCOrder = new UCOrder(tk, mk);
                MainController.LoadUC(pnl_Order, uCOrder);
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
