using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronto
{
    public partial class Receipt : Form
    {
        string username;

        public Receipt()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {

            if (this.username != "guest")
            {
                User_Home home = new User_Home();
                HistoryOrder order = new HistoryOrder();
                order.populateHistory();
                home.Show();
                home.setUsername(this.username);
                this.Hide();
            }
            else
            {
                StartingPage start = new StartingPage();
                start.Show();
                this.Hide();
            }
            
        }

        public void receipt(string pickup, string drop, string option, string mop, string user, string deliveryfee,
                            string schedulereceipt, string courier)
        {
            ReceiptPickup.Text = pickup;
            ReceiptDropoff.Text = drop;
            ReceiptDeliveryOption.Text = option;
            label8.Text = mop;
            ReceiptTotalPayment.Text = deliveryfee;
            ReceiptCourier.Text = courier;

            this.username = user;

            if (schedulereceipt=="Standard Delivery - Metro Manila")
            {
                lbl_reminder.Text = "Thank you!The pick - up and delivery of your transaction will be done within 2 - 5 days.";
            }
            else if (schedulereceipt == "Standard Delivery - Province")
            {
                lbl_reminder.Text = "Thank you!The pick - up and delivery of your transaction will be done within 5 - 15 days.";
            }
            else if (schedulereceipt == "Same Day Delivery")
            {
                lbl_reminder.Text = "Thank you! The pick-up and delivery of your transaction will be done today.";
            }
        }

        public void setUsername(string user)
        {
            this.username = user;
        }

        private void ReceiptPickup_Click(object sender, EventArgs e)
        {

        }
    }
}
