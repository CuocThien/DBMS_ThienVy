namespace QLQuanCafe.View.Admin
{
    partial class frm_ComputeTurnover
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ComputeTurnover));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.dtp_date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_Exit = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Outgoing = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Compute = new Guna.UI.WinForms.GunaButton();
            this.pnl_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.Controls.Add(this.dtp_date);
            this.pnl_Container.Controls.Add(this.btn_Exit);
            this.pnl_Container.Controls.Add(this.gunaLabel3);
            this.pnl_Container.Controls.Add(this.gunaLabel2);
            this.pnl_Container.Controls.Add(this.gunaLabel1);
            this.pnl_Container.Controls.Add(this.txt_Outgoing);
            this.pnl_Container.Controls.Add(this.btn_Compute);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(400, 450);
            this.pnl_Container.TabIndex = 1;
            // 
            // dtp_date
            // 
            this.dtp_date.BaseColor = System.Drawing.Color.Transparent;
            this.dtp_date.BorderColor = System.Drawing.Color.SaddleBrown;
            this.dtp_date.CustomFormat = null;
            this.dtp_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_date.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.ForeColor = System.Drawing.Color.Black;
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(114, 215);
            this.dtp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.dtp_date.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.dtp_date.OnHoverForeColor = System.Drawing.Color.Red;
            this.dtp_date.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_date.Size = new System.Drawing.Size(194, 42);
            this.dtp_date.TabIndex = 16;
            this.dtp_date.Text = "01/12/2020";
            this.dtp_date.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Exit.Location = new System.Drawing.Point(0, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnHoverImage = null;
            this.btn_Exit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel3.Location = new System.Drawing.Point(106, 104);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(202, 47);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Doanh thu";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel2.Location = new System.Drawing.Point(109, 167);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(221, 30);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Tính doanh thu tháng";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel1.Location = new System.Drawing.Point(109, 272);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 30);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Tổng chi";
            // 
            // txt_Outgoing
            // 
            this.txt_Outgoing.BaseColor = System.Drawing.Color.White;
            this.txt_Outgoing.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Outgoing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Outgoing.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Outgoing.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Outgoing.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Outgoing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outgoing.Location = new System.Drawing.Point(114, 322);
            this.txt_Outgoing.Name = "txt_Outgoing";
            this.txt_Outgoing.PasswordChar = '\0';
            this.txt_Outgoing.Size = new System.Drawing.Size(189, 40);
            this.txt_Outgoing.TabIndex = 12;
            // 
            // btn_Compute
            // 
            this.btn_Compute.AnimationHoverSpeed = 0.07F;
            this.btn_Compute.AnimationSpeed = 0.03F;
            this.btn_Compute.BackColor = System.Drawing.Color.Transparent;
            this.btn_Compute.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Compute.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Compute.BorderSize = 2;
            this.btn_Compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Compute.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Compute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compute.ForeColor = System.Drawing.Color.Black;
            this.btn_Compute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Compute.Image")));
            this.btn_Compute.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Compute.Location = new System.Drawing.Point(114, 389);
            this.btn_Compute.Name = "btn_Compute";
            this.btn_Compute.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Compute.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Compute.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_Compute.OnHoverImage = null;
            this.btn_Compute.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Compute.Radius = 10;
            this.btn_Compute.Size = new System.Drawing.Size(194, 38);
            this.btn_Compute.TabIndex = 8;
            this.btn_Compute.Text = "Tính doanh thu";
            this.btn_Compute.Click += new System.EventHandler(this.btn_Compute_Click);
            // 
            // frm_ComputeTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ComputeTurnover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ComputeTurnover";
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private Guna.UI.WinForms.GunaImageButton btn_Exit;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_Outgoing;
        private Guna.UI.WinForms.GunaButton btn_Compute;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_date;
    }
}