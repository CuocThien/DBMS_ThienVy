namespace QLQuanCafe.View.Admin
{
    partial class frm_ComputeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ComputeSalary));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_Name = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_BasicSalary = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Fine = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Luong = new Guna.UI.WinForms.GunaButton();
            this.pnl_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.Controls.Add(this.btn_Exit);
            this.pnl_Container.Controls.Add(this.lbl_Name);
            this.pnl_Container.Controls.Add(this.gunaLabel3);
            this.pnl_Container.Controls.Add(this.gunaLabel2);
            this.pnl_Container.Controls.Add(this.gunaLabel1);
            this.pnl_Container.Controls.Add(this.txt_BasicSalary);
            this.pnl_Container.Controls.Add(this.txt_Fine);
            this.pnl_Container.Controls.Add(this.btn_Luong);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(400, 450);
            this.pnl_Container.TabIndex = 0;
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
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Name.Location = new System.Drawing.Point(109, 172);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(144, 30);
            this.lbl_Name.TabIndex = 14;
            this.lbl_Name.Text = "Tên nhân viên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel3.Location = new System.Drawing.Point(134, 101);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(130, 47);
            this.gunaLabel3.TabIndex = 14;
            this.gunaLabel3.Text = "Lương";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel2.Location = new System.Drawing.Point(99, 236);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(145, 30);
            this.gunaLabel2.TabIndex = 14;
            this.gunaLabel2.Text = "Lương cơ bản";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gunaLabel1.Location = new System.Drawing.Point(99, 312);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 30);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Tiền phạt";
            // 
            // txt_BasicSalary
            // 
            this.txt_BasicSalary.BaseColor = System.Drawing.Color.White;
            this.txt_BasicSalary.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_BasicSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BasicSalary.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_BasicSalary.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_BasicSalary.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_BasicSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BasicSalary.Location = new System.Drawing.Point(104, 269);
            this.txt_BasicSalary.Name = "txt_BasicSalary";
            this.txt_BasicSalary.PasswordChar = '\0';
            this.txt_BasicSalary.Size = new System.Drawing.Size(189, 40);
            this.txt_BasicSalary.TabIndex = 13;
            // 
            // txt_Fine
            // 
            this.txt_Fine.BaseColor = System.Drawing.Color.White;
            this.txt_Fine.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Fine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fine.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fine.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Fine.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fine.Location = new System.Drawing.Point(104, 345);
            this.txt_Fine.Name = "txt_Fine";
            this.txt_Fine.PasswordChar = '\0';
            this.txt_Fine.Size = new System.Drawing.Size(189, 40);
            this.txt_Fine.TabIndex = 12;
            // 
            // btn_Luong
            // 
            this.btn_Luong.AnimationHoverSpeed = 0.07F;
            this.btn_Luong.AnimationSpeed = 0.03F;
            this.btn_Luong.BackColor = System.Drawing.Color.Transparent;
            this.btn_Luong.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Luong.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Luong.BorderSize = 2;
            this.btn_Luong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Luong.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Luong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luong.ForeColor = System.Drawing.Color.Black;
            this.btn_Luong.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luong.Image")));
            this.btn_Luong.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Luong.Location = new System.Drawing.Point(104, 391);
            this.btn_Luong.Name = "btn_Luong";
            this.btn_Luong.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Luong.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Luong.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_Luong.OnHoverImage = null;
            this.btn_Luong.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Luong.Radius = 10;
            this.btn_Luong.Size = new System.Drawing.Size(194, 38);
            this.btn_Luong.TabIndex = 8;
            this.btn_Luong.Text = "Tính lương";
            this.btn_Luong.Click += new System.EventHandler(this.btn_Luong_Click);
            // 
            // frm_ComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ComputeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ComputeSalary";
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private Guna.UI.WinForms.GunaButton btn_Luong;
        private Guna.UI.WinForms.GunaTextBox txt_BasicSalary;
        private Guna.UI.WinForms.GunaTextBox txt_Fine;
        private Guna.UI.WinForms.GunaLabel lbl_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton btn_Exit;
    }
}