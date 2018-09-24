using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public enum State { Menu, Employee, Member}
    public partial class Main : Form
    {
        State state = State.Employee;
        bool safe = false;
        public int SelectedIndex = -1;
        smk.EmployeeRow currentEmployee;
        Login referrer;
        public Main(Login referrer, smk.EmployeeRow currentEmployee)
        {
            InitializeComponent();
            this.referrer = referrer;
            this.currentEmployee = currentEmployee;
            name.Text += currentEmployee.name;
            button1_Click(null, null);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            state = State.Employee;
            SetupList(new string[]{ "ID Karyawan", "Nama", "Telepon", "Posisi"});
            foreach(smk.EmployeeRow row in Database.Data.Employee.Rows)
            {
                ListViewItem item = new ListViewItem(row.employeeId);
                item.SubItems.Add(row.name);
                item.SubItems.Add(row.handphone);
                item.SubItems.Add(row.position);
                listView1.Items.Add(item);
            }
        }

        void SetupList(string[] headers)
        {
            ClearList();
            if (state == State.Menu) listView1.View = View.Tile;
            else listView1.View = View.Details;
            listView1.Columns.Clear();
            foreach(string header in headers)
            {
                ColumnHeader h = new ColumnHeader();
                h.Text = header;
                h.Width = 125;
                listView1.Columns.Add(h);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            state = State.Menu;
            SetupList(new string[] { "Nama", "Harga" });
            foreach (smk.MenuRow row in Database.Data.Menu.Rows)
            {
                ListViewItem item = new ListViewItem(row.name);
                item.ImageKey = row.photo;
                item.SubItems.Add(string.Format("Rp. {0:0,0}", row.price));
                listView1.Items.Add(item);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            state = State.Member;
            SetupList(new string[] { "ID Member", "Nama", "Telepon", "Tanggal Bergabung" });
            foreach (smk.MemberRow row in Database.Data.Member.Rows)
            {
                ListViewItem item = new ListViewItem(row.memberId);
                item.SubItems.Add(row.name);
                item.SubItems.Add(row.handphone);
                item.SubItems.Add(row.joindate.ToString("dd MMM yyyy"));
                listView1.Items.Add(item);
            }
        }
        void ClearList()
        {
            SelectedIndex = -1;
            listView1.Items.Clear();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            OpenDialog(false);
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            if(SelectedIndex > -1) OpenDialog(true);
        }

        void OpenDialog(bool edit)
        {
            Form form = new Form();
            if (state == State.Employee)
                form = new EmployeeEdit(this, edit);
            else if (state == State.Menu)
                form = new MenuEdit(this, edit);
            form.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                SelectedIndex = listView1.SelectedIndices[0];
            }
            else SelectedIndex = -1;
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (SelectedIndex > -1)
            {
                Database.Data.EnforceConstraints = false;
                if (state == State.Employee)
                {
                    
                    Database.Data.Employee.Rows[SelectedIndex].Delete();
                    Database.Commit(Database.Data.Employee);
                    Database.Data.EnforceConstraints = true;
                    button1_Click(null, null);
                }
                else if (state == State.Menu)
                {
                    Database.Data.Menu.Rows[SelectedIndex].Delete();
                    Database.Commit(Database.Data.Menu);
                    Database.Data.EnforceConstraints = true;
                    button2_Click(null, null);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadImages();
        }

        public void LoadImages()
        {
            ClearImages();
            foreach (smk.MenuRow row in Database.Data.Menu.Rows)
            {
                if (row.photo != "default.png")
                {
                    using (StreamReader stream = new StreamReader(Environment.CurrentDirectory + "\\Images\\" + row.photo))
                    {
                        Image image = new Bitmap(stream.BaseStream);
                        menuImages.Images.Add(row.photo, image);
                        stream.Close();
                    }
                        
                }
                    
            }
        }
        public void ClearImages() => menuImages.Images.Clear();

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!safe) Application.Exit();
            else referrer.Show();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            safe = true;
            Close();
            referrer.Show();
        }
    }
}
