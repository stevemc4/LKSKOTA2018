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
    public partial class Payment : Form
    {
        private Cashier referrer;
        private smk.OrderRow orderRow;
        public Payment(Cashier cashier, smk.OrderRow orderRow)
        {
            referrer = cashier;
            this.orderRow = orderRow;
            InitializeComponent();
            header.Text += orderRow.MemberRow.name;
            payTotal.Text += $@"Rp. {referrer.total:0,0}";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(cardNumber.Text != "")
            {
                if (cardNumber.Text.Length == 16)
                {
                    long temp;
                    if(long.TryParse(cardNumber.Text, out temp))
                    {
                        orderRow.bank = bank.Text;
                        orderRow.payment = method.Text;
                        orderRow.cardNumber = cardNumber.Text;
                        Database.Commit(Database.Data.Order);
                        MessageBox.Show("Pembayaran Berhasil");
                        referrer.LoadList();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Format Nomor Kartu salah!");
                    }
                }
                else MessageBox.Show("Nomor Kartu Salah!");

            }
            else
            {
                MessageBox.Show("Nomor Kartu tidak boleh kosong!");
            }
        }
    }
}
