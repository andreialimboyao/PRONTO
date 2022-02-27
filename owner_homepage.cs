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
    public partial class frm_ownerhome : Form
    {
        public frm_ownerhome()
        {
            InitializeComponent();
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show(); 
            this.Hide();
        }

        private void btn_transactionsreport_Click(object sender, EventArgs e)
        {
            Transaction_Report tr = new Transaction_Report();
            tr.Show();
            this.Hide();
        }
    }
}
