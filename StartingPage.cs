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
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void StartLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void StartSignup_Click(object sender, EventArgs e)
        {
            Sign_up signup = new Sign_up();
            signup.Show();
            this.Hide();
        }

        private void StartGuest_Click(object sender, EventArgs e)
        {
            Order_Form order = new Order_Form();
            order.Show();
            order.setUsername("guest");
            order.setVisible();
            this.Hide();
        }
        

    }
}
