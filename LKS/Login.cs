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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            smk.EmployeeRow[] rows = Database.Data.Employee.Select($@"email='{email.Text}'") as smk.EmployeeRow[];
            if (rows.Count() > 0)
            {
                if(rows[0].password == password.Text)
                {
                    Hide();
                    password.Text = "";
                    if(rows[0].position == "Admin")
                    {
                        Main main = new Main(this, rows[0]);
                        main.Show();
                    }
                    else if (rows[0].position == "Koki")
                    {
                        Order order = new Order(this, rows[0]);
                        order.Show();
                    }
                    else if (rows[0].position == "Kasir")
                    {
                        Cashier cashier = new Cashier(this, rows[0]);
                        cashier.Show();
                    }

                }
                else MessageBox.Show("Password salah!!");
            }
            else
            {
                MessageBox.Show("Akun tidak ditemukan!");
            }
        }
    }
}
