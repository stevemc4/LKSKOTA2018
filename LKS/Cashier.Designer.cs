namespace LKS
{
    partial class Cashier
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
            this.orderDetail = new System.Windows.Forms.ListView();
            this.menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.orders = new System.Windows.Forms.ListBox();
            this.newOrder = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalText = new System.Windows.Forms.Label();
            this.member = new System.Windows.Forms.Label();
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
            // orderDetail
            // 
            this.orderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menu,
            this.qty,
            this.price,
            this.status});
            this.orderDetail.FullRowSelect = true;
            this.orderDetail.Location = new System.Drawing.Point(164, 80);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(620, 303);
            this.orderDetail.TabIndex = 13;
            this.orderDetail.UseCompatibleStateImageBehavior = false;
            this.orderDetail.View = System.Windows.Forms.View.Details;
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
            // price
            // 
            this.price.Text = "Subtotal";
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Daftar Pesanan";
            // 
            // orders
            // 
            this.orders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(12, 80);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(146, 303);
            this.orders.TabIndex = 11;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // newOrder
            // 
            this.newOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.newOrder.FlatAppearance.BorderSize = 0;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrder.ForeColor = System.Drawing.Color.White;
            this.newOrder.Location = new System.Drawing.Point(12, 401);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(146, 23);
            this.newOrder.TabIndex = 14;
            this.newOrder.Text = "Buat Pesanan Baru";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // pay
            // 
            this.pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.White;
            this.pay.Location = new System.Drawing.Point(686, 394);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(98, 36);
            this.pay.TabIndex = 15;
            this.pay.Text = "Bayar Pesanan";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total";
            // 
            // totalText
            // 
            this.totalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.totalText.Location = new System.Drawing.Point(164, 401);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(89, 45);
            this.totalText.TabIndex = 17;
            this.totalText.Text = "Rp. 0";
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member.Location = new System.Drawing.Point(169, 61);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(76, 16);
            this.member.TabIndex = 18;
            this.member.Text = "Pemesan: -";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.member);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.orderDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.panel1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cashier_FormClosed);
            this.Load += new System.EventHandler(this.Cashier_Load);
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
        private System.Windows.Forms.ListView orderDetail;
        private System.Windows.Forms.ColumnHeader menu;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.Label member;
    }
}