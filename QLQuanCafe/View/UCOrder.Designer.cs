namespace QLQuanCafe
{
    partial class UCOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Order = new System.Windows.Forms.Panel();
            this.pnl_BillControl = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.txt_TotalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Phone = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Payment = new Guna.UI.WinForms.GunaButton();
            this.btn_AddCustumer = new Guna.UI.WinForms.GunaButton();
            this.dgv_Order = new Guna.UI.WinForms.GunaDataGridView();
            this.Col_Bill_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BillProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PriceBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Level = new Guna.UI.WinForms.GunaLabel();
            this.lbl_CustomerName = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Order.SuspendLayout();
            this.pnl_BillControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Order
            // 
            this.pnl_Order.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Order.Controls.Add(this.lbl_CustomerName);
            this.pnl_Order.Controls.Add(this.txt_Level);
            this.pnl_Order.Controls.Add(this.pnl_BillControl);
            this.pnl_Order.Controls.Add(this.dgv_Order);
            this.pnl_Order.Controls.Add(this.gunaLabel4);
            this.pnl_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Order.Location = new System.Drawing.Point(0, 0);
            this.pnl_Order.Name = "pnl_Order";
            this.pnl_Order.Size = new System.Drawing.Size(400, 750);
            this.pnl_Order.TabIndex = 2;
            // 
            // pnl_BillControl
            // 
            this.pnl_BillControl.Controls.Add(this.gunaPictureBox1);
            this.pnl_BillControl.Controls.Add(this.gunaPictureBox3);
            this.pnl_BillControl.Controls.Add(this.txt_TotalPrice);
            this.pnl_BillControl.Controls.Add(this.txt_Phone);
            this.pnl_BillControl.Controls.Add(this.btn_Payment);
            this.pnl_BillControl.Controls.Add(this.btn_AddCustumer);
            this.pnl_BillControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BillControl.Location = new System.Drawing.Point(0, 521);
            this.pnl_BillControl.Name = "pnl_BillControl";
            this.pnl_BillControl.Size = new System.Drawing.Size(400, 229);
            this.pnl_BillControl.TabIndex = 6;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.ImageLocation = "";
            this.gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(11, 129);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.ImageLocation = "";
            this.gunaPictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.InitialImage")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(11, 21);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Padding = new System.Windows.Forms.Padding(8);
            this.gunaPictureBox3.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox3.TabIndex = 8;
            this.gunaPictureBox3.TabStop = false;
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.BaseColor = System.Drawing.Color.White;
            this.txt_TotalPrice.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_TotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TotalPrice.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_TotalPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPrice.Location = new System.Drawing.Point(57, 129);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.PasswordChar = '\0';
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(243, 40);
            this.txt_TotalPrice.TabIndex = 7;
            // 
            // txt_Phone
            // 
            this.txt_Phone.BaseColor = System.Drawing.Color.White;
            this.txt_Phone.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Phone.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(57, 21);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.Size = new System.Drawing.Size(243, 40);
            this.txt_Phone.TabIndex = 7;
            // 
            // btn_Payment
            // 
            this.btn_Payment.AnimationHoverSpeed = 0.07F;
            this.btn_Payment.AnimationSpeed = 0.03F;
            this.btn_Payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_Payment.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Payment.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Payment.BorderSize = 2;
            this.btn_Payment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Payment.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Payment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.ForeColor = System.Drawing.Color.Black;
            this.btn_Payment.Image = ((System.Drawing.Image)(resources.GetObject("btn_Payment.Image")));
            this.btn_Payment.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Payment.Location = new System.Drawing.Point(188, 175);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Payment.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_Payment.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_Payment.OnHoverImage = null;
            this.btn_Payment.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Payment.Radius = 10;
            this.btn_Payment.Size = new System.Drawing.Size(200, 42);
            this.btn_Payment.TabIndex = 6;
            this.btn_Payment.Text = "Thanh toán";
            // 
            // btn_AddCustumer
            // 
            this.btn_AddCustumer.AnimationHoverSpeed = 0.07F;
            this.btn_AddCustumer.AnimationSpeed = 0.03F;
            this.btn_AddCustumer.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddCustumer.BaseColor = System.Drawing.Color.Transparent;
            this.btn_AddCustumer.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_AddCustumer.BorderSize = 2;
            this.btn_AddCustumer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddCustumer.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddCustumer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustumer.ForeColor = System.Drawing.Color.Black;
            this.btn_AddCustumer.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCustumer.Image")));
            this.btn_AddCustumer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_AddCustumer.Location = new System.Drawing.Point(57, 73);
            this.btn_AddCustumer.Name = "btn_AddCustumer";
            this.btn_AddCustumer.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_AddCustumer.OnHoverBorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_AddCustumer.OnHoverForeColor = System.Drawing.Color.Red;
            this.btn_AddCustumer.OnHoverImage = null;
            this.btn_AddCustumer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_AddCustumer.Radius = 10;
            this.btn_AddCustumer.Size = new System.Drawing.Size(200, 42);
            this.btn_AddCustumer.TabIndex = 6;
            this.btn_AddCustumer.Text = "Thêm Khách hàng";
            // 
            // dgv_Order
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Order.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Order.ColumnHeadersHeight = 21;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Bill_Id,
            this.col_BillProduct,
            this.col_PriceBill,
            this.col_Quantity});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Order.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Order.EnableHeadersVisualStyles = false;
            this.dgv_Order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Order.Location = new System.Drawing.Point(0, 111);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersVisible = false;
            this.dgv_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Order.Size = new System.Drawing.Size(397, 404);
            this.dgv_Order.TabIndex = 5;
            this.dgv_Order.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Order.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_Order.ThemeStyle.ReadOnly = false;
            this.dgv_Order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Order.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Col_Bill_Id
            // 
            this.Col_Bill_Id.FillWeight = 10F;
            this.Col_Bill_Id.HeaderText = "Mã";
            this.Col_Bill_Id.Name = "Col_Bill_Id";
            // 
            // col_BillProduct
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_BillProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_BillProduct.FillWeight = 40F;
            this.col_BillProduct.HeaderText = "Tên sản phẩm";
            this.col_BillProduct.Name = "col_BillProduct";
            // 
            // col_PriceBill
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_PriceBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_PriceBill.FillWeight = 20F;
            this.col_PriceBill.HeaderText = "Giá tiền";
            this.col_PriceBill.Name = "col_PriceBill";
            // 
            // col_Quantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_Quantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_Quantity.FillWeight = 20F;
            this.col_Quantity.HeaderText = "Số lượng";
            this.col_Quantity.Name = "col_Quantity";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Blackadder ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(128, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(138, 82);
            this.gunaLabel4.TabIndex = 4;
            this.gunaLabel4.Text = "Bill";
            // 
            // txt_Level
            // 
            this.txt_Level.AutoSize = true;
            this.txt_Level.BackColor = System.Drawing.Color.Transparent;
            this.txt_Level.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Level.ForeColor = System.Drawing.Color.White;
            this.txt_Level.Location = new System.Drawing.Point(325, 69);
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.Size = new System.Drawing.Size(47, 30);
            this.txt_Level.TabIndex = 7;
            this.txt_Level.Text = "Bậc";
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.ForeColor = System.Drawing.Color.White;
            this.lbl_CustomerName.Location = new System.Drawing.Point(6, 69);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(164, 30);
            this.lbl_CustomerName.TabIndex = 8;
            this.lbl_CustomerName.Text = "Tên Khách hàng";
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnl_Order);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(400, 750);
            this.pnl_Order.ResumeLayout(false);
            this.pnl_Order.PerformLayout();
            this.pnl_BillControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Order;
        private System.Windows.Forms.Panel pnl_BillControl;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaTextBox txt_TotalPrice;
        private Guna.UI.WinForms.GunaTextBox txt_Phone;
        private Guna.UI.WinForms.GunaButton btn_Payment;
        private Guna.UI.WinForms.GunaButton btn_AddCustumer;
        private Guna.UI.WinForms.GunaDataGridView dgv_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Bill_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BillProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PriceBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lbl_CustomerName;
        private Guna.UI.WinForms.GunaLabel txt_Level;
    }
}
