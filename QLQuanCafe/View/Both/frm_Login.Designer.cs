namespace QLQuanCafe
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI.WinForms.GunaImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_lock = new Guna.UI.WinForms.GunaPictureBox();
            this.ptb_avt = new Guna.UI.WinForms.GunaPictureBox();
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Username = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Login = new Guna.UI.WinForms.GunaButton();
            this.ptb_logo = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.Controls.Add(this.btn_Exit);
            this.pnl_Container.Controls.Add(this.panel1);
            this.pnl_Container.Controls.Add(this.ptb_logo);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(384, 411);
            this.pnl_Container.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Exit.Location = new System.Drawing.Point(336, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnHoverImage = null;
            this.btn_Exit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ptb_lock);
            this.panel1.Controls.Add(this.ptb_avt);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 183);
            this.panel1.TabIndex = 0;
            // 
            // ptb_lock
            // 
            this.ptb_lock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_lock.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_lock.Image = ((System.Drawing.Image)(resources.GetObject("ptb_lock.Image")));
            this.ptb_lock.ImageLocation = "";
            this.ptb_lock.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_lock.InitialImage")));
            this.ptb_lock.Location = new System.Drawing.Point(35, 78);
            this.ptb_lock.Name = "ptb_lock";
            this.ptb_lock.Padding = new System.Windows.Forms.Padding(8);
            this.ptb_lock.Size = new System.Drawing.Size(40, 40);
            this.ptb_lock.TabIndex = 2;
            this.ptb_lock.TabStop = false;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_avt.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageLocation = "";
            this.ptb_avt.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_avt.InitialImage")));
            this.ptb_avt.Location = new System.Drawing.Point(35, 16);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Padding = new System.Windows.Forms.Padding(8);
            this.ptb_avt.Size = new System.Drawing.Size(40, 40);
            this.ptb_avt.TabIndex = 2;
            this.ptb_avt.TabStop = false;
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
            this.txt_Password.Location = new System.Drawing.Point(96, 78);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(223, 40);
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
            this.txt_Username.Location = new System.Drawing.Point(96, 16);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.Size = new System.Drawing.Size(223, 40);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.AnimationHoverSpeed = 0.07F;
            this.btn_Login.AnimationSpeed = 0.03F;
            this.btn_Login.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderColor = System.Drawing.Color.Black;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = null;
            this.btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Login.Location = new System.Drawing.Point(112, 138);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Login.OnHoverImage = null;
            this.btn_Login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Login.Size = new System.Drawing.Size(160, 42);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Transparent;
            this.ptb_logo.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_logo.Image = ((System.Drawing.Image)(resources.GetObject("ptb_logo.Image")));
            this.ptb_logo.Location = new System.Drawing.Point(0, 0);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(384, 411);
            this.ptb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_logo.TabIndex = 1;
            this.ptb_logo.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_lock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private Guna.UI.WinForms.GunaButton btn_Login;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox txt_Username;
        private Guna.UI.WinForms.GunaPictureBox ptb_avt;
        private Guna.UI.WinForms.GunaTextBox txt_Password;
        private Guna.UI.WinForms.GunaPictureBox ptb_lock;
        private Guna.UI.WinForms.GunaImageButton btn_Exit;
        private Guna.UI.WinForms.GunaPictureBox ptb_logo;
    }
}

