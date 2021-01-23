namespace QLQuanCafe
{
    partial class UCSalary
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
            this.dgv_Salary = new Guna.UI.WinForms.GunaDataGridView();
            this.Col_Staff_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salary)).BeginInit();
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
            this.pnl_Container.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Salary);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 624);
            this.panel1.TabIndex = 6;
            // 
            // dgv_Salary
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Salary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Salary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Salary.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Salary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Salary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Salary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Salary.ColumnHeadersHeight = 21;
            this.dgv_Salary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Staff_Id,
            this.col_StaffName,
            this.col_BasicSalary,
            this.col_KPI,
            this.col_Fine,
            this.col_Salary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Salary.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Salary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Salary.EnableHeadersVisualStyles = false;
            this.dgv_Salary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Salary.Location = new System.Drawing.Point(0, 0);
            this.dgv_Salary.Name = "dgv_Salary";
            this.dgv_Salary.RowHeadersVisible = false;
            this.dgv_Salary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Salary.Size = new System.Drawing.Size(1074, 624);
            this.dgv_Salary.TabIndex = 6;
            this.dgv_Salary.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Salary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Salary.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Salary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Salary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Salary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Salary.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Salary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Salary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Salary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Salary.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Salary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Salary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Salary.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Salary.ThemeStyle.ReadOnly = false;
            this.dgv_Salary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Salary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Salary.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Salary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Salary.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Salary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Salary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.col_StaffName.FillWeight = 30F;
            this.col_StaffName.HeaderText = "Họ và Tên";
            this.col_StaffName.Name = "col_StaffName";
            // 
            // col_BasicSalary
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_BasicSalary.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_BasicSalary.FillWeight = 15F;
            this.col_BasicSalary.HeaderText = "Lương cơ bản";
            this.col_BasicSalary.Name = "col_BasicSalary";
            // 
            // col_KPI
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_KPI.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_KPI.FillWeight = 15F;
            this.col_KPI.HeaderText = "KPI";
            this.col_KPI.Name = "col_KPI";
            // 
            // col_Fine
            // 
            this.col_Fine.FillWeight = 15F;
            this.col_Fine.HeaderText = "Phạt";
            this.col_Fine.Name = "col_Fine";
            // 
            // col_Salary
            // 
            this.col_Salary.FillWeight = 15F;
            this.col_Salary.HeaderText = "Tổng lương";
            this.col_Salary.Name = "col_Salary";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Blackadder ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel4.Location = new System.Drawing.Point(403, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(290, 123);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Salary";
            // 
            // UCSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Name = "UCSalary";
            this.Size = new System.Drawing.Size(1074, 750);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDataGridView dgv_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Staff_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Salary;
    }
}
