using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonderlandReservation
{
    public partial class PassesScreen : UserControl
    {
        List<Order> orders = new List<Order>();

        public PassesScreen()
        {
            InitializeComponent();

            passesButton.BackColor = Color.SteelBlue;
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            TicketScreen ts = new TicketScreen();
            f.Controls.Add(ts);
            ts.Focus();
        }

        private void passesButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            PassesScreen ps = new PassesScreen();
            f.Controls.Add(ps);
            ps.Focus();
        }

        private void diningButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            DiningScreen ds = new DiningScreen();
            f.Controls.Add(ds);
            ds.Focus();
        }

        private void parkingButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ParkingScreen bs = new ParkingScreen();
            f.Controls.Add(bs);
            bs.Focus();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            PaymentScreen cs = new PaymentScreen();
            f.Controls.Add(cs);
            cs.Focus();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string seasonPass, goldPass, platinumPass;

            seasonPass = amountInput1.Text;
            goldPass = amountInput2.Text;
            platinumPass = amountInput3.Text;

            Order o = new Order(seasonPass, goldPass, platinumPass);
            orders.Add(o);
        }
    }
}
