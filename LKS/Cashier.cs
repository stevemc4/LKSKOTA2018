using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public partial class Cashier : Form
    {
        Login referrer;
        smk.EmployeeRow currentEmployee;
        bool safe = false;
        public long total = 0;
        public Cashier(Login login, smk.EmployeeRow employeeRow)
        {
            referrer = login;
            currentEmployee = employeeRow;
            InitializeComponent();
            name.Text += currentEmployee.name;
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            safe = true;
            Close();
        }

        private void Cashier_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!safe) Application.Exit();
            else referrer.Show();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            LoadList();   
        }

        public void LoadList()
        {
            orders.Items.Clear();
            foreach (smk.OrderRow order in Database.Data.Order.Rows)
            {
                if(order.payment == "!" && order.bank == "!" && order.cardNumber == "!")
                    orders.Items.Add(order.orderId);
            }
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = 0;
            totalText.Text = "Rp. 0";
            orderDetail.Items.Clear();
            if (orders.SelectedIndex > -1)
            {
                member.Text = $@"Pemesan: {Database.Data.Order.FindByorderId(orders.SelectedItem.ToString()).MemberRow.name}";
                smk.DetailMenuRow[] menuRows = Database.Data.DetailMenu.Select($@"orderId='{orders.SelectedItem.ToString()}'") as smk.DetailMenuRow[];
                smk.DetailPackageRow[] packageRows = Database.Data.DetailPackage.Select($@"orderId='{orders.SelectedItem.ToString()}'") as smk.DetailPackageRow[];
                foreach(smk.DetailMenuRow row in menuRows)
                {
                    ListViewItem item = new ListViewItem(row.MenuRow.name);
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add($@"Rp. {row.price:0,0}");
                    item.SubItems.Add(row.status);
                    orderDetail.Items.Add(item);
                    total += row.price;
                }
                foreach (smk.DetailPackageRow row in packageRows)
                {
                    ListViewItem item = new ListViewItem("Paket " + row.PackageRow.type);
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add($@"Rp. {row.price:0,0}");
                    item.SubItems.Add(row.status);
                    orderDetail.Items.Add(item);
                    total += row.price;
                }
                totalText.Text = $@"Rp. {total:0,0}";
                orderDetail.Sorting = SortOrder.Ascending;
            }
            else
            {
                orderDetail.Items.Clear();
                member.Text = "Pemesan: -";
            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            new NewOrder(this, currentEmployee).Show();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(orders.SelectedIndex > -1)
                new Payment(this, Database.Data.Order.FindByorderId(orders.SelectedItem.ToString()) as smk.OrderRow).Show();
        }
    }
}
