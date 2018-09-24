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
    public partial class EmployeeEdit : Form
    {
        bool edit = false;
        int index = -1;
        Main referrer;
        public EmployeeEdit(Main main, bool edit)
        {
            InitializeComponent();
            index = main.SelectedIndex;
            referrer = main;
            this.edit = edit;
            if (edit)
            {
                smk.EmployeeRow row = Database.Data.Employee.Rows[index] as smk.EmployeeRow;
                Text = "Edit Karyawan";
                name.Text = row.name;
                email.Text = row.email;
                phone.Text = row.handphone;
                position.Text = row.position;
            }
            else
                Text = "Tambah Karyawan";
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                Database.Data.Employee.Rows[index]["name"] = name.Text;
                Database.Data.Employee.Rows[index]["email"] = email.Text;
                Database.Data.Employee.Rows[index]["handphone"] = phone.Text;
                Database.Data.Employee.Rows[index]["position"] = position.Text;
            }
            else
            {
                string id = "E-0000";
                if (Database.Data.Employee.Rows.Count > 0)
                    id = Database.Data.Employee.Last().employeeId;
                id = string.Format("E-{0:0000}", Program.GenerateCode(id, 2));
                Database.Data.Employee.AddEmployeeRow(id, name.Text, email.Text, "newpass", phone.Text, position.Text);
            }
            Database.Commit(Database.Data.Employee);
            referrer.button1_Click(null, null);
            Close();

        }
    }
}
