using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pronto
{
    public partial class HistoryOrder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");
        string username;
        string password;
        public HistoryOrder()
        {
            InitializeComponent();
        }

        private void HistoryOrder_Load(object sender, EventArgs e)
        {
            populateHistory();
        }

        public void populateHistory()
        {
            con.Open();
            string query = "select * from Overall_Transactions where Username = '" + this.username + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderHistory.DataSource = ds.Tables[0];
            con.Close();
        }

        private void OrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            User_Home uh = new User_Home();
            uh.setUsername(this.username);
            uh.Show();
            this.Hide();
        }

        public void setUsername(string user)
        {
            this.username = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
