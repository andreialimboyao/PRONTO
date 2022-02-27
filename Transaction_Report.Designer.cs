namespace Pronto
{
    partial class Transaction_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Report));
            this.Back = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.TabControl();
            this.MonthlyTransactions = new System.Windows.Forms.TabPage();
            this.PickMonth = new System.Windows.Forms.ComboBox();
            this.MonthlyTrans = new System.Windows.Forms.DataGridView();
            this.ExportMonthly = new System.Windows.Forms.Button();
            this.Weekly = new System.Windows.Forms.TabPage();
            this.PickMonth1 = new System.Windows.Forms.ComboBox();
            this.PickWeek = new System.Windows.Forms.ComboBox();
            this.WeeklyTransactions = new System.Windows.Forms.DataGridView();
            this.ExportWeekly = new System.Windows.Forms.Button();
            this.Daily = new System.Windows.Forms.TabPage();
            this.PickMonth2 = new System.Windows.Forms.ComboBox();
            this.PickDay = new System.Windows.Forms.ComboBox();
            this.ExportDaily = new System.Windows.Forms.Button();
            this.DailyTransactions = new System.Windows.Forms.DataGridView();
            this.Transactions.SuspendLayout();
            this.MonthlyTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyTrans)).BeginInit();
            this.Weekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyTransactions)).BeginInit();
            this.Daily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Back, "Back");
            this.Back.Name = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Transactions
            // 
            resources.ApplyResources(this.Transactions, "Transactions");
            this.Transactions.Controls.Add(this.MonthlyTransactions);
            this.Transactions.Controls.Add(this.Weekly);
            this.Transactions.Controls.Add(this.Daily);
            this.Transactions.Name = "Transactions";
            this.Transactions.SelectedIndex = 2;
            this.Transactions.SelectedIndexChanged += new System.EventHandler(this.Transactions_SelectedIndexChanged);
            // 
            // MonthlyTransactions
            // 
            this.MonthlyTransactions.Controls.Add(this.PickMonth);
            this.MonthlyTransactions.Controls.Add(this.MonthlyTrans);
            this.MonthlyTransactions.Controls.Add(this.ExportMonthly);
            resources.ApplyResources(this.MonthlyTransactions, "MonthlyTransactions");
            this.MonthlyTransactions.Name = "MonthlyTransactions";
            this.MonthlyTransactions.UseVisualStyleBackColor = true;
            this.MonthlyTransactions.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // PickMonth
            // 
            this.PickMonth.FormattingEnabled = true;
            this.PickMonth.Items.AddRange(new object[] {
            resources.GetString("PickMonth.Items"),
            resources.GetString("PickMonth.Items1"),
            resources.GetString("PickMonth.Items2"),
            resources.GetString("PickMonth.Items3"),
            resources.GetString("PickMonth.Items4"),
            resources.GetString("PickMonth.Items5"),
            resources.GetString("PickMonth.Items6"),
            resources.GetString("PickMonth.Items7"),
            resources.GetString("PickMonth.Items8"),
            resources.GetString("PickMonth.Items9"),
            resources.GetString("PickMonth.Items10"),
            resources.GetString("PickMonth.Items11")});
            resources.ApplyResources(this.PickMonth, "PickMonth");
            this.PickMonth.Name = "PickMonth";
            this.PickMonth.SelectedIndexChanged += new System.EventHandler(this.PickMonth_SelectedIndexChanged);
            // 
            // MonthlyTrans
            // 
            this.MonthlyTrans.BackgroundColor = System.Drawing.Color.White;
            this.MonthlyTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.MonthlyTrans, "MonthlyTrans");
            this.MonthlyTrans.Name = "MonthlyTrans";
            this.MonthlyTrans.RowHeadersVisible = false;
            // 
            // ExportMonthly
            // 
            resources.ApplyResources(this.ExportMonthly, "ExportMonthly");
            this.ExportMonthly.Name = "ExportMonthly";
            this.ExportMonthly.UseVisualStyleBackColor = true;
            this.ExportMonthly.Click += new System.EventHandler(this.ExportMonthly_Click);
            // 
            // Weekly
            // 
            this.Weekly.Controls.Add(this.PickMonth1);
            this.Weekly.Controls.Add(this.PickWeek);
            this.Weekly.Controls.Add(this.WeeklyTransactions);
            this.Weekly.Controls.Add(this.ExportWeekly);
            resources.ApplyResources(this.Weekly, "Weekly");
            this.Weekly.Name = "Weekly";
            this.Weekly.UseVisualStyleBackColor = true;
            // 
            // PickMonth1
            // 
            this.PickMonth1.FormattingEnabled = true;
            this.PickMonth1.Items.AddRange(new object[] {
            resources.GetString("PickMonth1.Items"),
            resources.GetString("PickMonth1.Items1"),
            resources.GetString("PickMonth1.Items2"),
            resources.GetString("PickMonth1.Items3"),
            resources.GetString("PickMonth1.Items4"),
            resources.GetString("PickMonth1.Items5"),
            resources.GetString("PickMonth1.Items6"),
            resources.GetString("PickMonth1.Items7"),
            resources.GetString("PickMonth1.Items8"),
            resources.GetString("PickMonth1.Items9"),
            resources.GetString("PickMonth1.Items10"),
            resources.GetString("PickMonth1.Items11")});
            resources.ApplyResources(this.PickMonth1, "PickMonth1");
            this.PickMonth1.Name = "PickMonth1";
            this.PickMonth1.SelectedIndexChanged += new System.EventHandler(this.PickMonth1_SelectedIndexChanged);
            // 
            // PickWeek
            // 
            this.PickWeek.FormattingEnabled = true;
            this.PickWeek.Items.AddRange(new object[] {
            resources.GetString("PickWeek.Items"),
            resources.GetString("PickWeek.Items1"),
            resources.GetString("PickWeek.Items2"),
            resources.GetString("PickWeek.Items3")});
            resources.ApplyResources(this.PickWeek, "PickWeek");
            this.PickWeek.Name = "PickWeek";
            this.PickWeek.SelectedIndexChanged += new System.EventHandler(this.PickWeek_SelectedIndexChanged);
            // 
            // WeeklyTransactions
            // 
            this.WeeklyTransactions.BackgroundColor = System.Drawing.Color.White;
            this.WeeklyTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.WeeklyTransactions, "WeeklyTransactions");
            this.WeeklyTransactions.Name = "WeeklyTransactions";
            this.WeeklyTransactions.RowHeadersVisible = false;
            // 
            // ExportWeekly
            // 
            resources.ApplyResources(this.ExportWeekly, "ExportWeekly");
            this.ExportWeekly.Name = "ExportWeekly";
            this.ExportWeekly.UseVisualStyleBackColor = true;
            this.ExportWeekly.Click += new System.EventHandler(this.ExportWeekly_Click);
            // 
            // Daily
            // 
            this.Daily.Controls.Add(this.PickMonth2);
            this.Daily.Controls.Add(this.PickDay);
            this.Daily.Controls.Add(this.ExportDaily);
            this.Daily.Controls.Add(this.DailyTransactions);
            resources.ApplyResources(this.Daily, "Daily");
            this.Daily.Name = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // PickMonth2
            // 
            this.PickMonth2.FormattingEnabled = true;
            this.PickMonth2.Items.AddRange(new object[] {
            resources.GetString("PickMonth2.Items"),
            resources.GetString("PickMonth2.Items1"),
            resources.GetString("PickMonth2.Items2"),
            resources.GetString("PickMonth2.Items3"),
            resources.GetString("PickMonth2.Items4"),
            resources.GetString("PickMonth2.Items5"),
            resources.GetString("PickMonth2.Items6"),
            resources.GetString("PickMonth2.Items7"),
            resources.GetString("PickMonth2.Items8"),
            resources.GetString("PickMonth2.Items9"),
            resources.GetString("PickMonth2.Items10"),
            resources.GetString("PickMonth2.Items11")});
            resources.ApplyResources(this.PickMonth2, "PickMonth2");
            this.PickMonth2.Name = "PickMonth2";
            this.PickMonth2.SelectedIndexChanged += new System.EventHandler(this.PickMonth2_SelectedIndexChanged);
            // 
            // PickDay
            // 
            this.PickDay.FormattingEnabled = true;
            this.PickDay.Items.AddRange(new object[] {
            resources.GetString("PickDay.Items"),
            resources.GetString("PickDay.Items1"),
            resources.GetString("PickDay.Items2"),
            resources.GetString("PickDay.Items3"),
            resources.GetString("PickDay.Items4"),
            resources.GetString("PickDay.Items5"),
            resources.GetString("PickDay.Items6"),
            resources.GetString("PickDay.Items7"),
            resources.GetString("PickDay.Items8"),
            resources.GetString("PickDay.Items9"),
            resources.GetString("PickDay.Items10"),
            resources.GetString("PickDay.Items11"),
            resources.GetString("PickDay.Items12"),
            resources.GetString("PickDay.Items13"),
            resources.GetString("PickDay.Items14"),
            resources.GetString("PickDay.Items15"),
            resources.GetString("PickDay.Items16"),
            resources.GetString("PickDay.Items17"),
            resources.GetString("PickDay.Items18"),
            resources.GetString("PickDay.Items19"),
            resources.GetString("PickDay.Items20"),
            resources.GetString("PickDay.Items21"),
            resources.GetString("PickDay.Items22"),
            resources.GetString("PickDay.Items23"),
            resources.GetString("PickDay.Items24"),
            resources.GetString("PickDay.Items25"),
            resources.GetString("PickDay.Items26"),
            resources.GetString("PickDay.Items27"),
            resources.GetString("PickDay.Items28"),
            resources.GetString("PickDay.Items29"),
            resources.GetString("PickDay.Items30")});
            resources.ApplyResources(this.PickDay, "PickDay");
            this.PickDay.Name = "PickDay";
            this.PickDay.SelectedIndexChanged += new System.EventHandler(this.PickDay_SelectedIndexChanged);
            // 
            // ExportDaily
            // 
            resources.ApplyResources(this.ExportDaily, "ExportDaily");
            this.ExportDaily.Name = "ExportDaily";
            this.ExportDaily.UseVisualStyleBackColor = true;
            this.ExportDaily.Click += new System.EventHandler(this.ExportDaily_Click);
            // 
            // DailyTransactions
            // 
            this.DailyTransactions.BackgroundColor = System.Drawing.Color.White;
            this.DailyTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DailyTransactions, "DailyTransactions");
            this.DailyTransactions.Name = "DailyTransactions";
            this.DailyTransactions.RowHeadersVisible = false;
            // 
            // Transaction_Report
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction_Report";
            this.Load += new System.EventHandler(this.Transaction_Report_Load);
            this.Transactions.ResumeLayout(false);
            this.MonthlyTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyTrans)).EndInit();
            this.Weekly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyTransactions)).EndInit();
            this.Daily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView Monthly;
        private System.Windows.Forms.TabControl Transactions;
        private System.Windows.Forms.TabPage MonthlyTransactions;
        private System.Windows.Forms.TabPage Weekly;
        private System.Windows.Forms.TabPage Daily;
        private System.Windows.Forms.DataGridView MonthlyTrans;
        private System.Windows.Forms.Button ExportMonthly;
        private System.Windows.Forms.Button ExportWeekly;
        private System.Windows.Forms.DataGridView DailyTransactions;
        private System.Windows.Forms.ComboBox PickMonth;
        private System.Windows.Forms.ComboBox PickMonth1;
        private System.Windows.Forms.ComboBox PickWeek;
        private System.Windows.Forms.DataGridView WeeklyTransactions;
        private System.Windows.Forms.ComboBox PickMonth2;
        private System.Windows.Forms.ComboBox PickDay;
        private System.Windows.Forms.Button ExportDaily;
    }
}