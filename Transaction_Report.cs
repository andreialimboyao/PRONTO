using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace Pronto
{
    public partial class Transaction_Report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");


        string day, month, date, monthlyMonth, weeklyMonth, weeklyWeek, dailyMonth, dailyDay;
        int weeklyCounter = 0, dailyCounter = 0, weeklyCounter1 = 0, dailyCounter1 = 0;
        public Transaction_Report()
        {
            InitializeComponent();
        }


        private void PickMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = PickMonth.SelectedIndex + 1;
            if (month.ToString().Length == 1)
            {
                this.monthlyMonth = "0" + month.ToString();
            }
            else
            {
                this.monthlyMonth = month.ToString();
            }
            populateMonthly();
        }

        private void PickMonth1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.weeklyCounter = 1;
            int month = PickMonth1.SelectedIndex + 1;
            if (month.ToString().Length == 1)
            {
                this.weeklyMonth = "0" + month.ToString();
            }
            else
            {
                this.weeklyMonth = month.ToString();
            }
            if (this.weeklyCounter1 == 1 && this.weeklyCounter == 1)
            {
                populateWeekly();
            }
        }

        private void ExportWeekly_Click(object sender, EventArgs e)
        {
            if (PickMonth1.SelectedIndex != -1 && PickWeek.SelectedIndex != -1)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Weekly Report";
                for (int i = 1; i < WeeklyTransactions.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = WeeklyTransactions.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < WeeklyTransactions.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < WeeklyTransactions.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = WeeklyTransactions.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else if (PickMonth1.SelectedIndex == -1 && PickWeek.SelectedIndex != -1)
            {
                MessageBox.Show("Select a month");
            }
            else if (PickMonth1.SelectedIndex != -1 && PickWeek.SelectedIndex == -1)
            {
                MessageBox.Show("Select a week");
            }
            else
            {
                MessageBox.Show("Select a week and a month");
            }
        }

        private void Transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ExportDaily_Click(object sender, EventArgs e)
        {

            if (PickMonth2.SelectedIndex != -1 && PickDay.SelectedIndex != -1)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Daily Report";
                for (int i = 1; i < DailyTransactions.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = DailyTransactions.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DailyTransactions.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DailyTransactions.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DailyTransactions.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else if (PickMonth2.SelectedIndex == -1 && PickDay.SelectedIndex != -1)
            {
                MessageBox.Show("Select a month");
            }
            else if (PickMonth2.SelectedIndex != -1 && PickDay.SelectedIndex == -1)
            {
                MessageBox.Show("Select a day");
            }
            else
            {
                MessageBox.Show("Select a day and a month");
            }

        }

        private void PickWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.weeklyCounter1 = 1;
            this.weeklyWeek = PickWeek.SelectedItem.ToString().Substring(5,1);
            if (this.weeklyCounter1 == 1 && this.weeklyCounter == 1)
            {
                populateWeekly();
            }
        }


        private void PickMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dailyCounter = 1;
            int month = PickMonth2.SelectedIndex + 1;
            if (month.ToString().Length == 1)
            {
                this.dailyMonth = "0" + month.ToString();
            }
            else
            {
                this.dailyMonth = month.ToString();
            }
            if (this.dailyCounter1 == 1 && this.dailyCounter == 1)
            {
                populateDaily();
            }
        }

        private void PickDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dailyCounter1 = 1;
            int day = PickDay.SelectedIndex + 1;
            if (day.ToString().Length == 1)
            {
                this.dailyDay = "0" + day.ToString();
            }
            else
            {
                this.dailyDay = day.ToString();
            }
            if (this.dailyCounter1 == 1 && this.dailyCounter == 1)
            {
                populateDaily();
            }
        }


        private void Transaction_Report_Load(object sender, EventArgs e)
        {
            this.date = DateTime.Now.ToString("MM-dd-yyyy");
            this.month = date.Substring(0, 2);
            this.day = date.Substring(3, 2);
        }

        private void Back_Click(object sender, EventArgs e)
        {         
            frm_ownerhome oh = new frm_ownerhome();
            oh.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ExportMonthly_Click(object sender, EventArgs e)
        {  
            if (PickMonth.SelectedIndex != -1)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Worksheet)workbook.Sheets["Sheet1"];
                worksheet = (Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Monthly Report";
                for (int i = 1; i < MonthlyTrans.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = MonthlyTrans.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < MonthlyTrans.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < MonthlyTrans.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = MonthlyTrans.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a month");
            }
            
        }

        void populateDaily()
        {
            con.Open();
            string query = "select * from Overall_Transactions where Month= '" + this.dailyMonth + "' and Day = '" + this.dailyDay + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DailyTransactions.DataSource = ds.Tables[0];
            con.Close();

        }
        void populateMonthly()
        {
            con.Open();
            string query = "select * from Overall_Transactions where Month = '" + this.monthlyMonth + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MonthlyTrans.DataSource = ds.Tables[0];
            con.Close();


        }

        void populateWeekly()
        {
            con.Open();
            string query = "select * from Overall_Transactions where Month = '" + this.weeklyMonth + "' and Week = '" + this.weeklyWeek + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            WeeklyTransactions.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
