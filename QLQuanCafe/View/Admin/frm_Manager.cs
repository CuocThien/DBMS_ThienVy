using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQuanCafe.View;
using QLQuanCafe.Controller;
using QLQuanCafe.View.Admin;
using QLQuanCafe.View.Both;

namespace QLQuanCafe
{
    public partial class frm_Manager : Form
    {
        public static string id="", TenMon, idMon;
        private string Id_Staff;
        private string FullName;
        private string tk;
        private string mk;
        private UCStaff uCStaff;
        private UCSalary uCSalary;
        private UCMenu uCMenu;

        public string err;
        public frm_Manager(string Id_Staff, string FullName, string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.Id_Staff = Id_Staff;
            this.FullName = FullName;
            this.lbl_Manager_Id.Text = Id_Staff;
            this.lbl_Manager_Name.Text = FullName;
        }

        private void btn_ManageStaff_Click(object sender, EventArgs e)
        {
            MainController.ShowPnlControl(pnl_MenuControl, pnl_SalaryControl, pnl_TopStaff,pnl_Turnover, pnl_StaffControl);
            pnl_StaffControl.BringToFront();
            uCStaff = new UCStaff(tk, mk);
            MainController.LoadUC(pnl_Content, uCStaff);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_ManageSalary_Click(object sender, EventArgs e)
        {
            MainController.ShowPnlControl(pnl_StaffControl, pnl_TopStaff, pnl_MenuControl, pnl_Turnover,pnl_SalaryControl);
            pnl_SalaryControl.BringToFront();
            uCSalary = new UCSalary(null, tk, mk);
            MainController.LoadUC(pnl_Content, uCSalary);
        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            frm_StaffRegister frm = new frm_StaffRegister(tk, mk);
            frm.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var luachon = cb_Chosse.Text;
            if (luachon == "Mã")
            {
                uCStaff = new UCStaff(tk, mk, txt_StaffName.Text, 1);
                MainController.LoadUC(pnl_Content, uCStaff);
            }
            else if (luachon == "Tên")
            {
                uCStaff = new UCStaff(tk, mk, txt_StaffName.Text, 2);
                MainController.LoadUC(pnl_Content, uCStaff);
            }
            else
            {
                MessageBox.Show("Chọn lựa chọn để tìm kiếm");
                return;
            }
        }

        private void btn_EditStaffInfor_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Chọn nhân viên cần chỉnh sửa thông tin");
                return;
            }
            frm_StaffEditInformation frm = new frm_StaffEditInformation(id, tk, mk);
            frm.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var flag = pnl_StaffControl.Visible;
            var flag1 = pnl_SalaryControl.Visible;
            var flag2 = pnl_MenuControl.Visible;
            if (flag == true)
            {
                pnl_SalaryControl.Visible = false;
                pnl_MenuControl.Visible = false;
                pnl_StaffControl.Visible = true;
                uCStaff = new UCStaff(tk, mk);
                MainController.LoadUC(pnl_Content, uCStaff);
            }
            if (flag2 == true)
            {
                pnl_SalaryControl.Visible = false;
                pnl_MenuControl.Visible = true;
                pnl_StaffControl.Visible = false;
                uCMenu = new UCMenu(tk, mk);
                MainController.LoadUC(pnl_Content, uCMenu);
            }

            //refresh content
        }

        private void btn_DeleteStaff_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
                return;
            }
            var check = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                var account = cShared.layAccount(id, tk, mk).Tables[0].Rows[0];
                cManager.xoalogin(account[1].ToString(), ref err, tk, mk);
                if (err == null)
                {
                    cManager.XoaAccount(id, ref err, tk, mk);
                    if (err == null)
                    {
                        cManager.XoaNV(id, ref err, tk, mk);
                        if (err == null)
                        {
                            MessageBox.Show("Xóa nhân viên thành công");
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
                    MessageBox.Show(err);
                    err = null;
                    return;
                }
            }
        }

        private void btn_ManageMenu_Click(object sender, EventArgs e)
        {
            MainController.ShowPnlControl(pnl_SalaryControl, pnl_StaffControl, pnl_TopStaff,pnl_Turnover, pnl_MenuControl);
            UCMenu uCMenu = new UCMenu(tk, mk);
            MainController.LoadUC(pnl_Content, uCMenu);
        }

        private void btn_AddMenu_Click(object sender, EventArgs e)
        {
            frm_AddMenu frm = new frm_AddMenu(tk, mk);
            frm.Show();
        }

        private void btn_SearchSalary_Click(object sender, EventArgs e)
        {
            var day = dtp_Salary.Value.Date;
            var BangLuong = cManager.DSLuong_view(tk, mk).Tables[0];
            for(int i=0;i<BangLuong.Rows.Count; i++)
            {
                var item = BangLuong.Rows[i];
                if (day!=DateTime.Parse(item[1].ToString()))
                {
                    BangLuong.Rows.Remove(item);
                }    
            }
            uCSalary = new UCSalary(BangLuong, tk, mk);
            MainController.LoadUC(pnl_Content, uCSalary);
        }

        private void btn_Luong_Click(object sender, EventArgs e)
        {
            if(id != "")
            {
                frm_ComputeSalary frm = new frm_ComputeSalary(id, tk, mk);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần nhập lương!!!");
                return;
            }
        }

        private void btn_SearchSalary1Staff_Click(object sender, EventArgs e)
        {
            var day = dtp_Salary.Value.Date.ToString("MM-dd-yyyy");
            var LuongNV=cManager.Luongnv(txt_IdStaffSalary.Text, day, tk, mk).Tables[0];
            uCSalary = new UCSalary(LuongNV, tk, mk);
            MainController.LoadUC(pnl_Content, uCSalary);
        }

        private void btn_SearchTopStaff_Click(object sender, EventArgs e)
        {

            var date = this.dtp_TopStaff.Value.ToString("MM-dd-yyyy");
            DataTable data = cManager.timTop1nhanvien(date, tk, mk).Tables[0];
            UCTopStaff uCTopStaff = new UCTopStaff(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCTopStaff);
        }

        private void btn_SearchStaffonTop_Click(object sender, EventArgs e)
        {
            DataTable data = cManager.Top1nhanvien(tk, mk).Tables[0];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                var name = cStaff.thongtin(item[1].ToString()).Tables[0].Rows[0][1].ToString().ToLower() ;
                var check = name.Contains(txt_IdStaffTop.Text.ToLower());
                if (cb_Top.Text == "Mã")
                {
                    if (txt_IdStaffTop.Text != item[1].ToString() )
                    {
                        data.Rows.Remove(item);
                    }
                }
                else
                {
                    if (check == false)
                    {
                        data.Rows.Remove(item);
                    }
                }    
            }
            UCTopStaff uCTopStaff = new UCTopStaff(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCTopStaff);
        }

        private void btn_TopStaff_Click(object sender, EventArgs e)
        {
            DataTable data = cManager.Top1nhanvien(tk, mk).Tables[0];
            MainController.ShowPnlControl(pnl_MenuControl, pnl_SalaryControl, pnl_StaffControl,pnl_Turnover, pnl_TopStaff);
            UCTopStaff uCTopStaff = new UCTopStaff(data,tk,mk);
            MainController.LoadUC(pnl_Content, uCTopStaff);
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            MainController.ShowPnlControl(pnl_MenuControl, pnl_SalaryControl, pnl_StaffControl, pnl_TopStaff, pnl_Turnover);
            DataTable data = cManager.DoanhSo_view(tk, mk).Tables[0];
            UCTurnover uCTurnover = new UCTurnover(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCTurnover);
        }

        private void btn_SearchTurnover_Click(object sender, EventArgs e)
        {
            var date = dtp_date.Value.ToString("MM-dd-yyyy");
            DataTable data = cManager.Timdoanhthu(date,tk,mk).Tables[0];
            UCTurnover uCTurnover = new UCTurnover(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCTurnover);
        }

        private void btn_ComputeTurnover_Click(object sender, EventArgs e)
        {
            frm_ComputeTurnover frm = new frm_ComputeTurnover(tk, mk);
            frm.Show();
        }

        private void btn_Top5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Top5inMenu frm = new frm_Top5inMenu(tk, mk);
            frm.ShowDialog();
            this.Close();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu_Order frm = new frm_Menu_Order(lbl_Manager_Id.Text, lbl_Manager_Name.Text, tk, mk);
            frm.ShowDialog();
            this.Close();
        }

        private void btn_ManageCustomers_Click(object sender, EventArgs e)
        {
            DataTable data = cManager.DSKH_view(tk, mk).Tables[0];
            UCManageCustomers uCManageCustomers = new UCManageCustomers(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCManageCustomers);
        }

        private void btn_Top3Cus_Click(object sender, EventArgs e)
        {
            DataTable data = cManager.Top3KH(tk, mk).Tables[0];
            UCManageCustomers uCManageCustomers = new UCManageCustomers(data, tk, mk);
            MainController.LoadUC(pnl_Content, uCManageCustomers);
        }

        private void btn_EditInfor_Click(object sender, EventArgs e)
        {
            if (TenMon == null)
            {
                MessageBox.Show("Chọn Món cần chỉnh sửa!!!");
                return;
            }
            frm_EditMenuInfor frm = new frm_EditMenuInfor(idMon, TenMon, tk, mk);
            frm.Show();
        }

        private void btn_DeleteMenu_Click(object sender, EventArgs e)
        {
            if (idMon == null)
            {
                MessageBox.Show("Chọn Món cần xóa");
                return;
            }
            var check = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xóa món", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                cManager.XoaMenu(idMon, ref err, tk, mk);
                if (err == null)
                {
                    MessageBox.Show("Xóa món ăn thành công");
                }
                else
                {
                    MessageBox.Show(err);
                    err = null;
                }

            }
        }
    }
}
