namespace QLQuanCafe.View.Admin
{
    partial class UCTurnover
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
            this.dgv_Turnover = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Payrolls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Outgoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turnover)).BeginInit();
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
            this.pnl_Container.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Turnover);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 624);
            this.panel1.TabIndex = 6;
            // 
            // dgv_Turnover
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Turnover.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Turnover.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Turnover.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Turnover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Turnover.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Turnover.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turnover.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Turnover.ColumnHeadersHeight = 21;
            this.dgv_Turnover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Date,
            this.Earnings,
            this.col_Payrolls,
            this.col_Outgoing,
            this.col_Profit});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Turnover.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Turnover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Turnover.EnableHeadersVisualStyles = false;
            this.dgv_Turnover.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Turnover.Location = new System.Drawing.Point(0, 0);
            this.dgv_Turnover.Name = "dgv_Turnover";
            this.dgv_Turnover.RowHeadersVisible = false;
            this.dgv_Turnover.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turnover.Size = new System.Drawing.Size(1074, 624);
            this.dgv_Turnover.TabIndex = 6;
            this.dgv_Turnover.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Turnover.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Turnover.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Turnover.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Turnover.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Turnover.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Turnover.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Turnover.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Turnover.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Turnover.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Turnover.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Turnover.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Turnover.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Turnover.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Turnover.ThemeStyle.ReadOnly = false;
            this.dgv_Turnover.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Turnover.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Turnover.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Turnover.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Turnover.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Turnover.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Turnover.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Blackadder ITC", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.gunaLabel4.Location = new System.Drawing.Point(335, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(351, 123);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Turnover";
            // 
            // Col_Date
            // 
            this.Col_Date.FillWeight = 20F;
            this.Col_Date.HeaderText = "Ngày tổng kết";
            this.Col_Date.Name = "Col_Date";
            // 
            // Earnings
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Earnings.DefaultCellStyle = dataGridViewCellStyle3;
            this.Earnings.FillWeight = 20F;
            this.Earnings.HeaderText = "Tổng thu";
            this.Earnings.Name = "Earnings";
            // 
            // col_Payrolls
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Payrolls.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_Payrolls.FillWeight = 20F;
            this.col_Payrolls.HeaderText = "Trả Lương";
            this.col_Payrolls.Name = "col_Payrolls";
            // 
            // col_Outgoing
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Outgoing.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_Outgoing.FillWeight = 20F;
            this.col_Outgoing.HeaderText = "Tổng chi";
            this.col_Outgoing.Name = "col_Outgoing";
            // 
            // col_Profit
            // 
            this.col_Profit.FillWeight = 20F;
            this.col_Profit.HeaderText = "Lợi nhuận";
            this.col_Profit.Name = "col_Profit";
            // 
            // UCTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Container);
            this.Name = "UCTurnover";
            this.Size = new System.Drawing.Size(1074, 750);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turnover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dgv_Turnover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Payrolls;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Outgoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Profit;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}
