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
    public partial class UCStaff : UserControl
    {
        private string tk;
        private string mk;
        DataTable DS;
        public UCStaff(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            dgv_Staff.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Staff.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataSet DSNV = cManager.DSNhanVien_view(tk, mk);
            DS = DSNV.Tables[0];
            loadData(DS);
        }
        public UCStaff(string tk, string mk,string search,int luachon)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            dgv_Staff.BackgroundColor = Color.FromArgb(242, 232, 196);
            dgv_Staff.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgv_Staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataSet DSNV = cManager.TimNV(search,luachon,tk, mk);
            DS = DSNV.Tables[0];
            loadData(DS);
        }
        public void loadData(DataTable data)
        {
            this.dgv_Staff.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                var DoB = item[2].ToString().Split(' ')[0];
                dgv_Staff.Rows.Add(item[0],item[1],DoB,item[3],item[4],item[5]);
            }
        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ID=dgv_Staff.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm_Manager.id = ID;
            this.dgv_Staff.Refresh();
            this.dgv_Staff.Update();
        }
    }
}
