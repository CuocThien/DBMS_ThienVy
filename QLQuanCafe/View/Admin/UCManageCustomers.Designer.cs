namespace QLQuanCafe.View.Admin
{
    partial class UCManageCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Customers = new Guna.UI.WinForms.GunaDataGridView();
            this.Col_Cus_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Manager = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Top3Cus = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Customers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customers.ColumnHeadersHeight = 21;
            this.dgv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Cus_Id,
            this.col_StaffName,
            this.col_Phone,
            this.col_Address,
            this.col_Points,
            this.col_level});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customers.EnableHeadersVisualStyles = false;
            this.dgv_Customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customers.Location = new System.Drawing.Point(0, 0);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.RowHeadersVisible = false;
            this.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customers.Size = new System.Drawing.Size(1074, 624);
            this.dgv_Customers.TabIndex = 6;
            this.dgv_Customers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Customers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Customers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Customers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Customers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Customers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Customers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Customers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Customers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Customers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Customers.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Customers.ThemeStyle.ReadOnly = false;
            this.dgv_Customers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Customers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Customers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Customers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Customers.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Customers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Customers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Col_Cus_Id
            // 
            this.Col_Cus_Id.FillWeight = 10F;
            this.Col_Cus_Id.HeaderText = "Mã KH";
            this.Col_Cus_Id.Name = "Col_Cus_Id";
            // 
            // col_StaffName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_StaffName.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_StaffName.FillWeight = 20F;
            this.col_StaffName.HeaderText = "Họ và Tên";
            this.col_StaffName.Name = "col_StaffName";
            // 
            // col_Phone
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Phone.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_Phone.FillWeight = 15F;
            this.col_Phone.HeaderText = "Số điện thoại";
            this.col_Phone.Name = "col_Phone";
            // 
            // col_Address
            // 
            this.col_Address.FillWeight = 30F;
            this.col_Address.HeaderText = "Địa chỉ";
            this.col_Address.Name = "col_Address";
            // 
            // col_Points
            // 
            this.col_Points.FillWeight = 10F;
            this.col_Points.HeaderText = "Điểm";
            this.col_Points.Name = "col_Points";
            // 
            // col_level
            // 
            this.col_level.FillWeight = 15F;
            this.col_level.HeaderText = "Bậc";
            this.col_level.Name = "col_level";
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.panel1);
            this.pnl_Container.Controls.Add(this.lbl_Top3Cus);
            this.pnl_Container.Controls.Add(this.lbl_Manager);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1074, 750);
            this.pnl_Container.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Customers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 624);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Manager
            // 
            this.lbl_Manager.AutoSize = true;
            this.lbl_Manager.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Manager.Font = new System.Drawing.Font("Blackadder ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manager.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Manager.Location = new System.Drawing.Point(193, 0);
            this.lbl_Manager.Name = "lbl_Manager";
            this.lbl_Manager.Size = new System.Drawing.Size(686, 123);
            this.lbl_Manager.TabIndex = 5;
            this.lbl_Manager.Text = "Manage Customer";
            // 
            // lbl_Top3Cus
            // 
            this.lbl_Top3Cus.AutoSize = true;
            this.lbl_Top3Cus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Top3Cus.Font = new System.Drawing.Font("Blackadder ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Top3Cus.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Top3Cus.Location = new System.Drawing.Point(240, 0);
            this.lbl_Top3Cus.Name = "lbl_Top3Cus";
            this.lbl_Top3Cus.Size = new System.Drawing.Size(604, 123);
            this.lbl_Top3Cus.TabIndex = 5;
            this.lbl_Top3Cus.Text = "Top 3 Customers";
            // 
            // UCManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Name = "UCManageCustomers";
            this.Size = new System.Drawing.Size(1074, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cus_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_level;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lbl_Manager;
        private Guna.UI.WinForms.GunaLabel lbl_Top3Cus;
    }
}
