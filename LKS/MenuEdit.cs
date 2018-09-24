using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public partial class MenuEdit : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        bool isPictureChanged = false;
        bool edit;
        Main referrer;
        int index = -1;
        public MenuEdit(Main main, bool edit)
        {
            referrer = main;
            this.edit = edit;
            InitializeComponent();
            dialog.Title = "Cari Gambar...";
            dialog.DefaultExt = ".png|.jpg";
            dialog.FileOk += Dialog_FileOk;
            if (edit)
            {
                index = main.SelectedIndex;
                smk.MenuRow row = Database.Data.Menu[main.SelectedIndex];
                name.Text = row.name;
                price.Value = row.price;
                imagePath.Text = row.photo;
                if (row.photo != "default.png")
                {
                    using (StreamReader stream = new StreamReader(Environment.CurrentDirectory + "\\Images\\" + row.photo))
                    {
                        Image image = new Bitmap(stream.BaseStream);
                        viewfinder.Image = image;
                        stream.Close();
                        stream.Dispose();
                    }
                }
                    
            }
        }

        private void Dialog_FileOk(object sender, CancelEventArgs e)
        {
            FileInfo info = new FileInfo(dialog.FileName);
            if (new Regex("\\.(jpeg|jpg|png)").IsMatch(info.Extension))
            {
                imagePath.Text = info.Name;
                viewfinder.Image = new Bitmap(dialog.FileName);
                isPictureChanged = true;
            }
            else MessageBox.Show("Gambar Tidak Valid!");
            
        }

        private void findImage_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
        }

        private void MenuEdit_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string filename = "default.png";
            if(isPictureChanged)
            {
                FileInfo info = new FileInfo(dialog.FileName);
                filename = name.Text.ToLower().Replace(' ', '-') + info.Extension;
                referrer.ClearImages();
                info.CopyTo(Environment.CurrentDirectory + "\\Images\\" + filename, true);
            }
            if(edit)
            {
                Database.Data.Menu.Rows[index]["name"] = name.Text;
                Database.Data.Menu.Rows[index]["price"] = price.Value;
                if (isPictureChanged)
                {
                    Database.Data.Menu.Rows[index]["photo"] = filename;
                }
            }
            else
            {
                Database.Data.Menu.AddMenuRow(name.Text, (int)price.Value, filename);
            }
            Database.Commit(Database.Data.Menu);
            referrer.button2_Click(null, null);
            referrer.LoadImages();
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
