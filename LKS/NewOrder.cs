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
    public partial class NewOrder : Form
    {
        Cashier referrer;
        bool safe = false;
        smk.EmployeeRow currentEmployee;
        long total = 0;
        public NewOrder(Cashier cashier, smk.EmployeeRow currentEmployee)
        {
            referrer = cashier;
            this.currentEmployee = currentEmployee;
            InitializeComponent();
            AutoCompleteStringCollection emails = new AutoCompleteStringCollection();
            foreach(smk.MemberRow rows in Database.Data.Member.Rows)
            {
                emails.Add(rows.email);
            }
            member.AutoCompleteMode = AutoCompleteMode.Suggest;
            member.AutoCompleteSource = AutoCompleteSource.CustomSource;
            member.AutoCompleteCustomSource = emails;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            foreach (smk.MenuRow row in Database.Data.Menu.Rows)
            {
                if (row.photo != "default.png")
                {
                    using (StreamReader stream = new StreamReader(Environment.CurrentDirectory + "\\Images\\" + row.photo))
                    {
                        Image image = new Bitmap(stream.BaseStream);
                        menuImageList.Images.Add(row.photo, image);
                        stream.Close();
                    }

                }
                ListViewItem item = new ListViewItem(row.name);
                item.ImageKey = row.photo;
                //item.SubItems.Add(string.Format("Rp. {0:0,0}", row.price));
                item.SubItems.Add(string.Format("{0}", row.price));
                item.Tag = "Menu";
                item.SubItems.Add(row.menuId.ToString());
                menuList.Items.Add(item);
                
            }
            foreach (smk.PackageRow row in Database.Data.Package.Rows)
            {
                ListViewItem item = new ListViewItem("Paket " + row.type);
                //item.SubItems.Add(string.Format("Rp. {0:0,0}", row.price));
                item.SubItems.Add(string.Format("{0}", row.price));
                item.Tag = "Package";
                item.SubItems.Add(row.packageId.ToString());
                menuList.Items.Add(item);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void newMember_Click(object sender, EventArgs e)
        {
            if (member.Text != "")
            {
                smk.MemberRow[] rows = Database.Data.Member.Select($@"email='{member.Text}'") as smk.MemberRow[];
                if (rows.Count() > 0)
                {
                    MessageBox.Show($"Email Ditemukan! Nama: {rows[0].name}");
                }
                else MessageBox.Show("Tidak ditemukan member yang memiliki Email tersebut!");
            }
            else MessageBox.Show("Kolom Email tidak boleh kosong!");
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(menuList.SelectedItems.Count > 0)
            {
                ListViewItem item = menuList.SelectedItems[0];
                smk.CartRow[] rows = Database.Data.Cart.Select($@"name='{item.Text}'") as smk.CartRow[];
                if (Database.Data.Cart.Select($@"name='{item.Text}'").Count() > 0)
                {
                    Database.Data.Cart.FindByid(rows[0].id).qty++;
                    Database.Data.Cart.FindByid(rows[0].id).subtotal += int.Parse(item.SubItems[1].Text);
                }
                else
                {
                    string name = item.Text;
                    long price = long.Parse(item.SubItems[1].Text);
                    Database.Data.Cart.AddCartRow(name, price, 1, price, item.Tag.ToString(), item.SubItems[2].Text);
                }

                Database.Commit();
                reloadDetail();
            }
        }
        private void reloadDetail()
        {
            total = 0;
            cart.Items.Clear();
            foreach(smk.CartRow rows in Database.Data.Cart)
            {
                ListViewItem item = new ListViewItem(rows.name);
                item.SubItems.Add(rows.price.ToString());
                item.SubItems.Add(rows.qty.ToString());
                item.SubItems.Add(rows.subtotal.ToString());
                cart.Items.Add(item);
                total += rows.subtotal;
            }
            if (total > 0)
                totalText.Text = $@"Rp. {total:0,0}";
            else totalText.Text = "Rp. 0";
        }

        private void NewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!safe)
            {
                if(MessageBox.Show("Apakah Anda ingin membatalkan pesanan ini?", "Pembatalan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            Database.Data.Cart.Clear();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(cart.SelectedItems.Count > 0)
            {
                int index = cart.SelectedIndices[0];
                if(int.Parse(Database.Data.Cart.Rows[index]["qty"].ToString()) > 1)
                {
                    ((smk.CartRow)Database.Data.Cart.Rows[index]).qty--;
                    ((smk.CartRow)Database.Data.Cart.Rows[index]).subtotal-= ((smk.CartRow)Database.Data.Cart.Rows[index]).price;
                }
                else
                {
                    Database.Data.Cart.Rows[index].Delete();
                }
                Database.Commit();
                reloadDetail();
            }
        }

        private void process_Click(object sender, EventArgs e)
        {
            if(Database.Data.Cart.Rows.Count > 0)
            {
                if (member.Text != "")
                {
                    smk.MemberRow[] rows = Database.Data.Member.Select($@"email='{member.Text}'") as smk.MemberRow[];
                    if (rows.Count() > 0)
                    {
                        string id = DateTime.Now.ToString("yyyyMMdd") + "01";
                        string lastId = Database.Data.Order.Last().orderId;

                        if (lastId.Substring(0, 8) == DateTime.Now.ToString("yyyyMMdd"))
                        {
                            int code = Program.GenerateCode(lastId, 8);
                            id = $@"{DateTime.Now.ToString("yyyyMMdd")}{code:00}";
                        }
                        Database.Data.Order.AddOrderRow(id, currentEmployee.employeeId, Database.Data.Member.FindBymemberId(rows[0].memberId), DateTime.Now, "!", "!", "!");
                        Database.Transact(Database.Data.Order);
                        Database.Commit();
                        foreach (smk.CartRow row in Database.Data.Cart.Rows)
                        {
                            if (row.type == "Menu")
                            {
                                Console.WriteLine("Menu");
                                Database.Data.DetailMenu.AddDetailMenuRow(Database.Data.Order.FindByorderId(id), Database.Data.Menu.Select($@"menuId='{row.itemId}'")[0] as smk.MenuRow, row.qty, (int)row.subtotal, "Queued");
                            }
                            else if (row.type == "Package")
                            {
                                Console.WriteLine("Package");
                                Database.Data.DetailPackage.AddDetailPackageRow(Database.Data.Order.FindByorderId(id), Database.Data.Package.Select($@"packageId='{row.itemId}'")[0] as smk.PackageRow, row.qty, (int)row.subtotal, "Queued");
                            }
                        }
                        Database.Transact(Database.Data.DetailMenu);
                        Database.Transact(Database.Data.DetailPackage);
                        Database.Commit();

                        safe = true;
                        Close();
                        referrer.LoadList();
                    }
                    else
                    {
                        MessageBox.Show("Email tidak valid!");
                    }
                }
                else MessageBox.Show("Kolom Email Member tidak boleh kosong!");
            }
            else
            {
                MessageBox.Show("Pesanan kosong!");
            }
        }
    }
}
