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
    public partial class Order : Form
    {
        Login referrer;
        smk.EmployeeRow currentEmployee;
        bool safe = false;
        public Order(Login login, smk.EmployeeRow employeeRow)
        {
            referrer = login;
            currentEmployee = employeeRow;
            InitializeComponent();
            name.Text += currentEmployee.name;
            LoadList();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            safe = true;
            Close();
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!safe) Application.Exit();
            else referrer.Show();
        }
        public void LoadList()
        {
            orders.Items.Clear();
            foreach (smk.OrderRow order in Database.Data.Order.Rows)
            {
                if (order.payment == "!" && order.bank == "!" && order.cardNumber == "!")
                    orders.Items.Add(order.orderId);
            }
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadDetail();
        }

        void reloadDetail()
        {
            orderDetail.Items.Clear();
            if (orders.SelectedIndex > -1)
            {
                smk.DetailMenuRow[] menuRows = Database.Data.DetailMenu.Select($@"orderId='{orders.SelectedItem.ToString()}'") as smk.DetailMenuRow[];
                smk.DetailPackageRow[] packageRows = Database.Data.DetailPackage.Select($@"orderId='{orders.SelectedItem.ToString()}'") as smk.DetailPackageRow[];
                foreach (smk.DetailMenuRow row in menuRows)
                {
                    ListViewItem item = new ListViewItem(row.MenuRow.name);
                    item.Tag = new string[] { "Menu", row.detailId.ToString() };
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add(row.status);
                    orderDetail.Items.Add(item);
                }
                foreach (smk.DetailPackageRow row in packageRows)
                {
                    ListViewItem item = new ListViewItem("Paket " + row.PackageRow.type);
                    item.Tag = new string[] { "Package", row.detailId.ToString() };
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add(row.status);
                    orderDetail.Items.Add(item);
                }
            }
            else
            {
                orderDetail.Items.Clear();
            }
        }

        private void orderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderDetail.SelectedIndices.Count > 0)
            {
                menuStatus.Enabled = true;
                apply.Enabled = true;
                menuStatus.Text = orderDetail.SelectedItems[0].SubItems[2].Text.ToString();
            }
            else
            {
                menuStatus.Enabled = false;
                apply.Enabled = false;
            }
        }

        private void apply_Click(object sender, EventArgs e)
        {
            ListViewItem item = orderDetail.SelectedItems[0];
            string[] props = item.Tag as string[];
            if(props[0] == "Menu")
            {
                ((smk.DetailMenuRow)Database.Data.DetailMenu.Select($@"detailId='{props[1]}'")[0]).status = menuStatus.Text;
                Database.Commit(Database.Data.DetailMenu);
            }
            else if (props[0] == "Package")
            {
                ((smk.DetailPackageRow)Database.Data.DetailPackage.Select($@"detailId='{props[1]}'")[0]).status = menuStatus.Text;
                Database.Commit(Database.Data.DetailPackage);
            }
            
            reloadDetail();
        }
    }
}
