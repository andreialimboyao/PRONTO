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
    public partial class Sign_up : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");

        string name, contact, address, city, province, user, pass, pass1;
        string[] provinceArray = new string[] { "Metro Manila", "Luzon", "Visayas", "Mindanao" };
        string[] cityArray = new string[] { "Caloocan", "Las piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela" };

        

        public Sign_up()
        {
            InitializeComponent();
        }

        private void SignupNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SignupPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void SignupConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && !Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void SignupShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (SignupShowpassword.Checked)
            {
                SignupPassword.UseSystemPasswordChar = false;
                SignupConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                SignupPassword.UseSystemPasswordChar = true;
                SignupConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //********************************************************EVENT************************************************************************
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SignupPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void Back_Click(object sender, EventArgs e)
        {
            StartingPage start = new StartingPage();
            start.Show();
            this.Hide();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void SignupCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SignupArea.SelectedIndex == 0)
            {
                this.city = cityArray[SignupCity.SelectedIndex];
            }
        }

        private void SignupArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SignupArea.SelectedIndex == 0)
            {
                panel2.Visible = true;
            }
            else
            {
                SignupCity.SelectedIndex = -1;
                panel2.Visible = false;
            }
            this.province = provinceArray[SignupArea.SelectedIndex];
        }

        private void btnSignupCreate_Click(object sender, EventArgs e)
        {
            this.address = SignupAddress.Text;
            this.user = SignupUsername.Text;
            this.pass = SignupPassword.Text;
            this.pass1 = SignupConfirmPassword.Text;
            this.name = SignupName.Text;
            this.contact = SignupNumber.Text;

            if (this.name != "" && this.contact != "" && this.address != "" && this.province != "" && this.user != "" && this.pass != "" && this.pass1 != "")
            {
                if (pass.Length > 7 && pass1.Length > 7)
                {
                    if ( this.pass != this.pass1)
                    {
                        MessageBox.Show("Password does not match");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Accounts(Name,Username,Phone,Address,Password,Area,City,Admin) values('" + this.name + "','" + this.user + "','" + this.contact + "','" + this.address + "','" + this.pass + "','" + this.province + "','" + this.city + "','" + "no" + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully");
                        con.Close();
                        StartingPage starting = new StartingPage();
                        starting.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password should be greater than 7 characters");
                }
            }
            else
            {
                MessageBox.Show("Incomplete information");
            }
        }
    }
}
