using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pronto
{
    public partial class User_Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");

        string username, name, address, contact, area, city, password, checker, admin;

        public User_Home()
        {
            InitializeComponent();
        }

        //********************************************************EVENT************************************************************************
        private void MenuPlaceOrder_Click(object sender, EventArgs e)
        {
            if (this.username != "")
            {

                for (int i = 0; i < AccountTable.Rows.Count; i++)
                {
                    this.checker = AccountTable.Rows[i].Cells["Username"].FormattedValue.ToString();

                    if (this.checker == this.username)
                    {
                        this.name = AccountTable.Rows[i].Cells["Name"].FormattedValue.ToString();
                        this.contact = AccountTable.Rows[i].Cells["Phone"].FormattedValue.ToString();
                        this.address = AccountTable.Rows[i].Cells["Address"].FormattedValue.ToString();
                        this.area = AccountTable.Rows[i].Cells["Area"].FormattedValue.ToString();
                        this.city = AccountTable.Rows[i].Cells["City"].FormattedValue.ToString();
                        Order_Form order = new Order_Form();
                        order.setUsername(this.username);
                        order.updateInfo(this.name, this.contact, this.address, this.area, this.city);
                        order.Show();
                        this.Hide();
                        break;
                    }
                }
                    
                    
            }
        }
           
        private void OrderHistory_Click(object sender, EventArgs e)
        {
            HistoryOrder history = new HistoryOrder();
            history.setUsername(this.username);
            history.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            Change_Password change = new Change_Password();
            change.setUsername(this.username);
            change.setPassword(this.password);
            change.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.clearText();
            StartingPage start = new StartingPage();
            start.Show();
            this.Hide();
        }

        private void User_Home_Load(object sender, EventArgs e)
        {
            populate();
            AccountTable.Visible = false; //view grid table
        }

        //********************************************************VOID************************************************************************
        public void populate()
        {
            con.Open();
            string query = "select * from Accounts";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountTable.DataSource = ds.Tables[0];
            con.Close();
        }

        public void setUsername(string user)
        {
            this.username = user;
        }

        public void setPassword(string pass)
        {
            this.password = pass;
        }


        public string getAdmin(string user)
        {
            for (int i = 0; i < AccountTable.Rows.Count; i++)
            {
                string name = AccountTable.Rows[i].Cells["Username"].FormattedValue.ToString();
                if (name == user)
                {
                    admin = AccountTable.Rows[i].Cells["Admin"].FormattedValue.ToString();
                    break;
                }
            }
            return admin;
        }
    }
}
