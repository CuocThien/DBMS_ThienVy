namespace QLQuanCafe.View.Admin
{
    partial class frm_EditMenuInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditMenuInfor));
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI.WinForms.GunaImageButton();
            this.cb_catogories = new Guna.UI.WinForms.GunaComboBox();
            this.cb_FandB = new Guna.UI.WinForms.GunaComboBox();
            this.txt_PriceS = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Name = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_AddImg = new Guna.UI.WinForms.GunaButton();
            this.ptb_LoadImg = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PriceM = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PriceL = new Guna.UI.WinForms.GunaTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Container.BackgroundImage")));
            this.pnl_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Container.Controls.Add(this.btn_Exit);
            this.pnl_Container.Controls.Add(this.cb_catogories);
            this.pnl_Container.Controls.Add(this.cb_FandB);
            this.pnl_Container.Controls.Add(this.txt_PriceL);
            this.pnl_Container.Controls.Add(this.txt_PriceM);
            this.pnl_Container.Controls.Add(this.txt_PriceS);
            this.pnl_Container.Controls.Add(this.txt_Name);
            this.pnl_Container.Controls.Add(this.btn_Edit);
            this.pnl_Container.Controls.Add(this.btn_AddImg);
            this.pnl_Container.Controls.Add(this.ptb_LoadImg);
            this.pnl_Container.Controls.Add(this.label5);
            this.pnl_Container.Controls.Add(this.gunaLabel3);
            this.pnl_Container.Controls.Add(this.label4);
            this.pnl_Container.Controls.Add(this.label2);
            this.pnl_Container.Controls.Add(this.label3);
            this.pnl_Container.Controls.Add(this.label1);
            this.pnl_Container.Controls.Add(this.Tên);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(500, 550);
            this.pnl_Container.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Exit.Location = new System.Drawing.Point(433, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.OnHoverImage = null;
            this.btn_Exit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_catogories
            // 
            this.cb_catogories.BackColor = System.Drawing.Color.Transparent;
            this.cb_catogories.BaseColor = System.Drawing.Color.White;
            this.cb_catogories.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cb_catogories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_catogories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_catogories.FocusedColor = System.Drawing.Color.Empty;
            this.cb_catogories.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_catogories.ForeColor = System.Drawing.Color.Black;
            this.cb_catogories.FormattingEnabled = true;
            this.cb_catogories.ItemHeight = 40;
            this.cb_catogories.Location = new System.Drawing.Point(230, 201);
            this.cb_catogories.Name = "cb_catogories";
            this.cb_catogories.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_catogories.OnHoverItemForeColor = System.Drawing.Color.Lime;
            this.cb_catogories.Size = new System.Drawing.Size(243, 46);
            this.cb_catogories.TabIndex = 9;
            // 
            // cb_FandB
            // 
            this.cb_FandB.BackColor = System.Drawing.Color.Transparent;
            this.cb_FandB.BaseColor = System.Drawing.Color.White;
            this.cb_FandB.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cb_FandB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_FandB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FandB.FocusedColor = System.Drawing.Color.Empty;
            this.cb_FandB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FandB.ForeColor = System.Drawing.Color.Black;
            this.cb_FandB.FormattingEnabled = true;
            this.cb_FandB.ItemHeight = 40;
            this.cb_FandB.Items.AddRange(new object[] {
            "Đồ Ăn",
            "Nước uống"});
            this.cb_FandB.Location = new System.Drawing.Point(230, 139);
            this.cb_FandB.Name = "cb_FandB";
            this.cb_FandB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_FandB.OnHoverItemForeColor = System.Drawing.Color.Lime;
            this.cb_FandB.Size = new System.Drawing.Size(243, 46);
            this.cb_FandB.TabIndex = 9;
            this.cb_FandB.SelectedIndexChanged += new System.EventHandler(this.cb_FandB_SelectedIndexChanged);
            // 
            // txt_PriceS
            // 
            this.txt_PriceS.BaseColor = System.Drawing.Color.White;
            this.txt_PriceS.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceS.Enabled = false;
            this.txt_PriceS.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PriceS.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceS.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PriceS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceS.Location = new System.Drawing.Point(306, 295);
            this.txt_PriceS.Name = "txt_PriceS";
            this.txt_PriceS.PasswordChar = '\0';
            this.txt_PriceS.Size = new System.Drawing.Size(167, 46);
            this.txt_PriceS.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.BaseColor = System.Drawing.Color.White;
            this.txt_Name.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Name.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(230, 79);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(243, 40);
            this.txt_Name.TabIndex = 8;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Edit.BorderSize = 2;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Lime;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Edit.Location = new System.Drawing.Point(275, 455);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Edit.Radius = 10;
            this.btn_Edit.Size = new System.Drawing.Size(181, 42);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Sửa thông tin";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddImg
            // 
            this.btn_AddImg.AnimationHoverSpeed = 0.07F;
            this.btn_AddImg.AnimationSpeed = 0.03F;
            this.btn_AddImg.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddImg.BaseColor = System.Drawing.Color.Transparent;
            this.btn_AddImg.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_AddImg.BorderSize = 2;
            this.btn_AddImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddImg.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddImg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImg.ForeColor = System.Drawing.Color.Lime;
            this.btn_AddImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddImg.Image")));
            this.btn_AddImg.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_AddImg.Location = new System.Drawing.Point(12, 236);
            this.btn_AddImg.Name = "btn_AddImg";
            this.btn_AddImg.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_AddImg.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_AddImg.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_AddImg.OnHoverImage = null;
            this.btn_AddImg.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AddImg.Radius = 10;
            this.btn_AddImg.Size = new System.Drawing.Size(162, 42);
            this.btn_AddImg.TabIndex = 7;
            this.btn_AddImg.Text = "Thêm ảnh";
            this.btn_AddImg.Click += new System.EventHandler(this.btn_AddImg_Click);
            // 
            // ptb_LoadImg
            // 
            this.ptb_LoadImg.BackColor = System.Drawing.Color.Transparent;
            this.ptb_LoadImg.BaseColor = System.Drawing.Color.Transparent;
            this.ptb_LoadImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_LoadImg.Location = new System.Drawing.Point(12, 79);
            this.ptb_LoadImg.Name = "ptb_LoadImg";
            this.ptb_LoadImg.Size = new System.Drawing.Size(162, 141);
            this.ptb_LoadImg.TabIndex = 0;
            this.ptb_LoadImg.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Lime;
            this.gunaLabel3.Location = new System.Drawing.Point(86, -10);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(332, 65);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Sửa thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(300, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(224, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Size";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.BackColor = System.Drawing.Color.Transparent;
            this.Tên.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.ForeColor = System.Drawing.Color.Lime;
            this.Tên.Location = new System.Drawing.Point(175, 83);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(62, 32);
            this.Tên.TabIndex = 10;
            this.Tên.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(235, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(235, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "M";
            // 
            // txt_PriceM
            // 
            this.txt_PriceM.BaseColor = System.Drawing.Color.White;
            this.txt_PriceM.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceM.Enabled = false;
            this.txt_PriceM.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PriceM.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceM.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PriceM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceM.Location = new System.Drawing.Point(306, 347);
            this.txt_PriceM.Name = "txt_PriceM";
            this.txt_PriceM.PasswordChar = '\0';
            this.txt_PriceM.Size = new System.Drawing.Size(167, 46);
            this.txt_PriceM.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(235, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "L";
            // 
            // txt_PriceL
            // 
            this.txt_PriceL.BaseColor = System.Drawing.Color.White;
            this.txt_PriceL.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PriceL.Enabled = false;
            this.txt_PriceL.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_PriceL.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_PriceL.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_PriceL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PriceL.Location = new System.Drawing.Point(306, 399);
            this.txt_PriceL.Name = "txt_PriceL";
            this.txt_PriceL.PasswordChar = '\0';
            this.txt_PriceL.Size = new System.Drawing.Size(167, 46);
            this.txt_PriceL.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_EditMenuInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.pnl_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditMenuInfor";
            this.Text = "frm_EditMenuInfor";
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LoadImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Container;
        private Guna.UI.WinForms.GunaImageButton btn_Exit;
        private Guna.UI.WinForms.GunaComboBox cb_catogories;
        private Guna.UI.WinForms.GunaComboBox cb_FandB;
        private Guna.UI.WinForms.GunaTextBox txt_PriceS;
        private Guna.UI.WinForms.GunaTextBox txt_Name;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_AddImg;
        private Guna.UI.WinForms.GunaPictureBox ptb_LoadImg;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tên;
        private Guna.UI.WinForms.GunaTextBox txt_PriceL;
        private Guna.UI.WinForms.GunaTextBox txt_PriceM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}