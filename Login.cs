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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");
        string username, password, admin;

        public Login()
        {
            InitializeComponent();
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            StartingPage start = new StartingPage();
            start.Show();
            this.Hide();
            
        }
        private void UserLogin_Click(object sender, EventArgs e)
        {
            
            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Accounts where Username= '" + Username.Text + "' and Password = '" + Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                this.username = Username.Text;
                this.password = Password.Text;
                User_Home home = new User_Home();
                home.populate();
                this.admin = home.getAdmin(this.username);
                home.setUsername(this.username);
                home.setPassword(this.password);
                if (this.admin == "no")
                {
                    con.Close();
                    home.Show();
                    this.Hide();
                }
                else
                { 
                    con.Close();
                    frm_ownerhome oh = new frm_ownerhome();
                    oh.Show();
                    this.Hide();
                }
                

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                Username.Clear();
                Password.Clear();
            }
            con.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        public void clearText()
        {
            Username.Clear();
            Password.Clear();
        }
    }
}
