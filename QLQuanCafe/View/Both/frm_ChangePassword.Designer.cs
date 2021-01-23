namespace QLQuanCafe
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox6 = new Guna.UI.WinForms.GunaPictureBox();
            this.ptb_lock = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_Exit = new Guna.UI.WinForms.GunaImageButton();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_avt = new Guna.UI.WinForms.GunaPictureBox();
            this.txt_Confirm = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Username = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Change = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lock)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(116, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "ĐỔI MẬT KHẨU";
            // 
            // gunaPictureBox6
            // 
            this.gunaPictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox6.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox6.Image")));
            this.gunaPictureBox6.ImageLocation = "";
            this.gunaPictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox6.InitialImage")));
            this.gunaPictureBox6.Location = new System.Drawing.Point(48, 181);
            this.gunaPictureBox6.Name = "gunaPictureBox6";
            this.gunaPictureBox6.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gunaPictureBox6.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox6.TabIndex = 2;
            this.gunaPictureBox6.TabStop = false;
            // 
            // ptb_lock
            // 
            this.ptb_lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_lock.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_lock.Image = ((System.Drawing.Image)(resources.GetObject("ptb_lock.Image")));
            this.ptb_lock.ImageLocation = "";
            this.ptb_lock.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_lock.InitialImage")));
            this.ptb_lock.Location = new System.Drawing.Point(48, 125);
            this.ptb_lock.Name = "ptb_lock";
            this.ptb_lock.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ptb_lock.Size = new System.Drawing.Size(40, 40);
            this.ptb_lock.TabIndex = 2;
            this.ptb_lock.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Exit.Location = new System.Drawing.Point(332, 11);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnHoverImage = null;
            this.btn_Exit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.Controls.Add(this.btn_Exit);
            this.pnl_Container.Controls.Add(this.panel2);
            this.pnl_Container.Controls.Add(this.gunaLabel1);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(384, 380);
            this.pnl_Container.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gunaPictureBox6);
            this.panel2.Controls.Add(this.ptb_lock);
            this.panel2.Controls.Add(this.ptb_avt);
            this.panel2.Controls.Add(this.txt_Confirm);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_Username);
            this.panel2.Controls.Add(this.btn_Change);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 313);
            this.panel2.TabIndex = 1;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_avt.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageLocation = "";
            this.ptb_avt.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_avt.InitialImage")));
            this.ptb_avt.Location = new System.Drawing.Point(48, 63);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ptb_avt.Size = new System.Drawing.Size(40, 40);
            this.ptb_avt.TabIndex = 2;
            this.ptb_avt.TabStop = false;
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.BaseColor = System.Drawing.Color.White;
            this.txt_Confirm.BorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Confirm.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Confirm.FocusedBorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Confirm.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Confirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm.Location = new System.Drawing.Point(94, 181);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '●';
            this.txt_Confirm.Size = new System.Drawing.Size(243, 40);
            this.txt_Confirm.TabIndex = 3;
            this.txt_Confirm.UseSystemPasswordChar = true;
            // 
            // txt_Password
            // 
            this.txt_Password.BaseColor = System.Drawing.Color.White;
            this.txt_Password.BorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Password.FocusedBorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(94, 125);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(243, 40);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.BaseColor = System.Drawing.Color.White;
            this.txt_Username.BorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Username.FocusedBorderColor = System.Drawing.Color.Fuchsia;
            this.txt_Username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(94, 63);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.Size = new System.Drawing.Size(243, 40);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_Change
            // 
            this.btn_Change.AnimationHoverSpeed = 0.07F;
            this.btn_Change.AnimationSpeed = 0.03F;
            this.btn_Change.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Change.BorderColor = System.Drawing.Color.Black;
            this.btn_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Change.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Change.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Change.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.Color.White;
            this.btn_Change.Image = null;
            this.btn_Change.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Change.Location = new System.Drawing.Point(121, 243);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Change.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Change.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Change.OnHoverImage = null;
            this.btn_Change.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Change.Size = new System.Drawing.Size(160, 42);
            this.btn_Change.TabIndex = 9;
            this.btn_Change.Text = "Đổi mật khẩu";
            this.btn_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 380);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lock)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox6;
        private Guna.UI.WinForms.GunaPictureBox ptb_lock;
        private Guna.UI.WinForms.GunaImageButton btn_Exit;
        private System.Windows.Forms.Panel pnl_Container;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox ptb_avt;
        private Guna.UI.WinForms.GunaTextBox txt_Confirm;
        private Guna.UI.WinForms.GunaTextBox txt_Password;
        private Guna.UI.WinForms.GunaTextBox txt_Username;
        private Guna.UI.WinForms.GunaButton btn_Change;
    }
}