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
    public partial class frm_paymaya : Form
    {
        string username;
        string pickup, drop, option, mop, user, deliveryfee, courier, reminder;

        public frm_paymaya()
        {
            InitializeComponent();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            btn_verify.Text = "Resend Code";
            btn_confirm.Visible = true;
            lbl_code.Visible = true;
            txtbox_code.Visible = true;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txtbox_code.Text == "")
            {
                MessageBox.Show("Error. Please enter your verification code properly.");
            }

            const string message = "Are you sure?";
            const string caption = "Confirmation";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the yes button was pressed ...
            if (result == DialogResult.Yes)
            {
                Receipt r = new Receipt();
                r.receipt(this.pickup, this.drop, this.option, this.mop, this.user, this.deliveryfee, this.reminder, this.courier);
                r.Show();
                this.Hide();
            }
        }

        public void receipt(string pickup, string drop, string option, string mop, string user, string deliveryfee,
                            string schedulereceipt, string courier)
        {
            this.pickup = pickup;
            this.drop = drop;
            this.option = option;
            this.mop = mop;
            this.deliveryfee = deliveryfee;
            this.courier = courier;

            this.user = user;

            if (schedulereceipt == "Standard Delivery - Metro Manila")
            {
                this.reminder = "Standard Delivery - Metro Manila";
            }
            else if (schedulereceipt == "Standard Delivery - Province")
            {
                this.reminder = "Standard Delivery - Province";
            }
            else if (schedulereceipt == "Same Day Delivery")
            {
                this.reminder = "Same Day Delivery";
            }
        }



    }
}
