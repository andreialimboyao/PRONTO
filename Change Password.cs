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
    public partial class Change_Password : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alvin Luiz\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");

        string username, password, password1, oldpass, opass;

        public Change_Password()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                ChangePassOld.UseSystemPasswordChar = false;
                ChangePassNew.UseSystemPasswordChar = false;
                ChangePassConfirm.UseSystemPasswordChar = false;

            }
            else
            {
                ChangePassOld.UseSystemPasswordChar = true;
                ChangePassNew.UseSystemPasswordChar = true;
                ChangePassConfirm.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassOld_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void ChangePassNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void ChangePassConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            User_Home home = new User_Home();
            home.setUsername(this.username);
            home.setPassword(this.password);
            home.Show();
            this.Hide();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            this.opass = ChangePassOld.Text;
            this.password = ChangePassNew.Text;
            this.password1 = ChangePassConfirm.Text;

            if (this.opass == "" || this.password == "" || this.password1 == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (this.oldpass != this.opass)
            {
                MessageBox.Show("Old Password is incorrect");
            }
            else if (this.password.Length < 8 && this.password1.Length < 8)
            {
                MessageBox.Show("Password should be greater than 7 characters");
            }
            else if (this.password != this.password1)
            {
                MessageBox.Show("Password does not match");
            }
            else if (this.opass == this.password)
            {
                MessageBox.Show("This is already you password.");
            }
            else
            {
                con.Open();
                string query = "update Accounts set  Password='" + this.password + "'where UserName= '" + this.username + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully");
                con.Close();
                ChangePassOld.Clear();
                ChangePassNew.Clear();
                ChangePassConfirm.Clear();
            }

        }

        public void setUsername(string user)
        {
            this.username = user;
        }

        public void setPassword(string pass)
        {
            this.oldpass = pass;
        }

    }
}
