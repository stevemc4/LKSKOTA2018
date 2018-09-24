namespace LKS
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.name = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDetail = new System.Windows.Forms.ListView();
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 48);
            this.panel1.TabIndex = 7;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.linkLabel2.Location = new System.Drawing.Point(656, 18);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ubah Password";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            // 
            // logout
            // 
            this.logout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logout.Location = new System.Drawing.Point(749, 18);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(39, 13);
            this.logout.TabIndex = 5;
            this.logout.TabStop = true;
            this.logout.Text = "Keluar";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // name
            // 
            this.name.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.name.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.name.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.Location = new System.Drawing.Point(445, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 21);
            this.name.TabIndex = 4;
            this.name.TabStop = true;
            this.name.Text = "Selamat Datang, ";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.name.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMK RESTAURANT";
            // 
            // orders
            // 
            this.orders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(12, 67);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(146, 355);
            this.orders.TabIndex = 8;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Daftar Pesanan";
            // 
            // orderDetail
            // 
            this.orderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.qty,
            this.status});
            this.orderDetail.FullRowSelect = true;
            this.orderDetail.Location = new System.Drawing.Point(164, 67);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(620, 321);
            this.orderDetail.TabIndex = 10;
            this.orderDetail.UseCompatibleStateImageBehavior = false;
            this.orderDetail.View = System.Windows.Forms.View.Details;
            this.orderDetail.SelectedIndexChanged += new System.EventHandler(this.orderDetail_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.Text = "Menu";
            this.menu.Width = 113;
            // 
            // qty
            // 
            this.qty.Text = "Jumlah";
            this.qty.Width = 99;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 84;
            // 
            // menuStatus
            // 
            this.menuStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStatus.Enabled = false;
            this.menuStatus.FormattingEnabled = true;
            this.menuStatus.Items.AddRange(new object[] {
            "Queued",
            "Preparing",
            "Cooking",
            "Finishing",
            "Ready",
            "Done"});
            this.menuStatus.Location = new System.Drawing.Point(663, 394);
            this.menuStatus.Name = "menuStatus";
            this.menuStatus.Size = new System.Drawing.Size(121, 21);
            this.menuStatus.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.apply.Enabled = false;
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(718, 421);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(66, 23);
            this.apply.TabIndex = 16;
            this.apply.Text = "Simpan";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStatus);
            this.Controls.Add(this.orderDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.LinkLabel name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView orderDetail;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ComboBox menuStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button apply;
    }
}