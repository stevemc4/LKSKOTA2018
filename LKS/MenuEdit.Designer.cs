namespace LKS
{
    partial class MenuEdit
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
            this.name = new System.Windows.Forms.TextBox();
            this.Input1Label = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.viewfinder = new System.Windows.Forms.PictureBox();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findImage = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewfinder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Harga";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(64, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 20);
            this.name.TabIndex = 5;
            // 
            // Input1Label
            // 
            this.Input1Label.AutoSize = true;
            this.Input1Label.Location = new System.Drawing.Point(12, 9);
            this.Input1Label.Name = "Input1Label";
            this.Input1Label.Size = new System.Drawing.Size(35, 13);
            this.Input1Label.TabIndex = 4;
            this.Input1Label.Text = "Nama";
            // 
            // price
            // 
            this.price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(64, 32);
            this.price.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(259, 20);
            this.price.TabIndex = 7;
            // 
            // viewfinder
            // 
            this.viewfinder.Image = global::LKS.Properties.Resources._default;
            this.viewfinder.Location = new System.Drawing.Point(330, 6);
            this.viewfinder.Name = "viewfinder";
            this.viewfinder.Size = new System.Drawing.Size(108, 108);
            this.viewfinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewfinder.TabIndex = 8;
            this.viewfinder.TabStop = false;
            // 
            // imagePath
            // 
            this.imagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePath.Location = new System.Drawing.Point(64, 58);
            this.imagePath.Name = "imagePath";
            this.imagePath.ReadOnly = true;
            this.imagePath.Size = new System.Drawing.Size(178, 20);
            this.imagePath.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gambar";
            // 
            // findImage
            // 
            this.findImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.findImage.FlatAppearance.BorderSize = 0;
            this.findImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findImage.ForeColor = System.Drawing.Color.White;
            this.findImage.Location = new System.Drawing.Point(248, 55);
            this.findImage.Name = "findImage";
            this.findImage.Size = new System.Drawing.Size(75, 23);
            this.findImage.TabIndex = 11;
            this.findImage.Text = "Cari";
            this.findImage.UseVisualStyleBackColor = false;
            this.findImage.Click += new System.EventHandler(this.findImage_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.cancel.Location = new System.Drawing.Point(186, 91);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Batal";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(248, 91);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Simpan";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // MenuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 125);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.findImage);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewfinder);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Input1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEdit";
            this.Load += new System.EventHandler(this.MenuEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewfinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label Input1Label;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.PictureBox viewfinder;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findImage;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}