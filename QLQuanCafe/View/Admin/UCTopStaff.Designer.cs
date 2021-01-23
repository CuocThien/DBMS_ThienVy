namespace QLQuanCafe.View.Admin
{
    partial class UCTopStaff
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_TopStaff = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Col_Staff_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Payday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.panel1);
            this.pnl_Container.Controls.Add(this.gunaLabel4);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1074, 750);
            this.pnl_Container.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_TopStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 624);
            this.panel1.TabIndex = 6;
            // 
            // dgv_TopStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TopStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TopStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TopStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TopStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TopStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TopStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TopStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TopStaff.ColumnHeadersHeight = 21;
            this.dgv_TopStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Staff_Id,
            this.col_StaffName,
            this.col_DoB,
            this.col_Phone,
            this.col_Revenue,
            this.col_Payday});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TopStaff.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TopStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TopStaff.EnableHeadersVisualStyles = false;
            this.dgv_TopStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TopStaff.Location = new System.Drawing.Point(0, 0);
            this.dgv_TopStaff.Name = "dgv_TopStaff";
            this.dgv_TopStaff.RowHeadersVisible = false;
            this.dgv_TopStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TopStaff.Size = new System.Drawing.Size(1074, 624);
            this.dgv_TopStaff.TabIndex = 6;
            this.dgv_TopStaff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_TopStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TopStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TopStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TopStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TopStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TopStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TopStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TopStaff.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_TopStaff.ThemeStyle.ReadOnly = false;
            this.dgv_TopStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TopStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TopStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TopStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TopStaff.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_TopStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TopStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Blackadder ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel4.Location = new System.Drawing.Point(335, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(394, 123);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Top Staff";
            // 
            // Col_Staff_Id
            // 
            this.Col_Staff_Id.FillWeight = 10F;
            this.Col_Staff_Id.HeaderText = "Mã NV";
            this.Col_Staff_Id.Name = "Col_Staff_Id";
            // 
            // col_StaffName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_StaffName.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_StaffName.FillWeight = 20F;
            this.col_StaffName.HeaderText = "Họ và Tên";
            this.col_StaffName.Name = "col_StaffName";
            // 
            // col_DoB
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_DoB.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_DoB.FillWeight = 15F;
            this.col_DoB.HeaderText = "Ngày sinh";
            this.col_DoB.Name = "col_DoB";
            // 
            // col_Phone
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Phone.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_Phone.FillWeight = 15F;
            this.col_Phone.HeaderText = "Số điện thoại";
            this.col_Phone.Name = "col_Phone";
            // 
            // col_Revenue
            // 
            this.col_Revenue.FillWeight = 20F;
            this.col_Revenue.HeaderText = "Doanh thu";
            this.col_Revenue.Name = "col_Revenue";
            // 
            // col_Payday
            // 
            this.col_Payday.FillWeight = 20F;
            this.col_Payday.HeaderText = "Ngày Tổng kết";
            this.col_Payday.Name = "col_Payday";
            // 
            // UCTopStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Name = "UCTopStaff";
            this.Size = new System.Drawing.Size(1074, 750);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dgv_TopStaff;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Staff_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Payday;
    }
}
