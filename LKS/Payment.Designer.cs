namespace LKS
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.payTotal = new System.Windows.Forms.Label();
            this.methodlabel = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.ComboBox();
            this.bank = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "PEMBAYARAN";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(13, 51);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(259, 25);
            this.header.TabIndex = 5;
            this.header.Text = "Yth. Bapak/Ibu/Tuan/Nyonya ";
            // 
            // payTotal
            // 
            this.payTotal.AutoSize = true;
            this.payTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTotal.Location = new System.Drawing.Point(13, 76);
            this.payTotal.Name = "payTotal";
            this.payTotal.Size = new System.Drawing.Size(152, 20);
            this.payTotal.TabIndex = 6;
            this.payTotal.Text = "Tagihan Anda adalah ";
            // 
            // methodlabel
            // 
            this.methodlabel.AutoSize = true;
            this.methodlabel.Location = new System.Drawing.Point(15, 128);
            this.methodlabel.Name = "methodlabel";
            this.methodlabel.Size = new System.Drawing.Size(105, 13);
            this.methodlabel.TabIndex = 7;
            this.methodlabel.Text = "Metode Pembayaran";
            // 
            // method
            // 
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "Debit",
            "Kartu Kredit"});
            this.method.Location = new System.Drawing.Point(16, 144);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(159, 21);
            this.method.TabIndex = 8;
            this.method.Text = "Debit";
            // 
            // bank
            // 
            this.bank.FormattingEnabled = true;
            this.bank.Items.AddRange(new object[] {
            "BCA",
            "BNI",
            "Mandiri",
            "BRI",
            "BTPN",
            "Bukopin",
            "Danamon",
            "CIMB Niaga",
            "StringPay e-Card",
            "Jenius x-Card",
            "BTN"});
            this.bank.Location = new System.Drawing.Point(16, 184);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(159, 21);
            this.bank.TabIndex = 10;
            this.bank.Text = "BCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bank";
            // 
            // pay
            // 
            this.pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.White;
            this.pay.Location = new System.Drawing.Point(395, 250);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(98, 36);
            this.pay.TabIndex = 16;
            this.pay.Text = "Proses";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nomor Kartu";
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(18, 224);
            this.cardNumber.MaxLength = 16;
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(157, 20);
            this.cardNumber.TabIndex = 18;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 298);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.method);
            this.Controls.Add(this.methodlabel);
            this.Controls.Add(this.payTotal);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label payTotal;
        private System.Windows.Forms.Label methodlabel;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.ComboBox bank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardNumber;
    }
}