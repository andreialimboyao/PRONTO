namespace Pronto
{
    partial class User_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPlaceOrder = new System.Windows.Forms.Button();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AccountTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPlaceOrder
            // 
            this.MenuPlaceOrder.BackColor = System.Drawing.Color.Orange;
            this.MenuPlaceOrder.Location = new System.Drawing.Point(46, 244);
            this.MenuPlaceOrder.Name = "MenuPlaceOrder";
            this.MenuPlaceOrder.Size = new System.Drawing.Size(188, 32);
            this.MenuPlaceOrder.TabIndex = 2;
            this.MenuPlaceOrder.Text = "Place Order";
            this.MenuPlaceOrder.UseVisualStyleBackColor = false;
            this.MenuPlaceOrder.Click += new System.EventHandler(this.MenuPlaceOrder_Click);
            // 
            // OrderHistory
            // 
            this.OrderHistory.BackColor = System.Drawing.Color.Orange;
            this.OrderHistory.Location = new System.Drawing.Point(46, 283);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(188, 32);
            this.OrderHistory.TabIndex = 3;
            this.OrderHistory.Text = "Order History";
            this.OrderHistory.UseVisualStyleBackColor = false;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.Orange;
            this.ChangePassword.Location = new System.Drawing.Point(46, 321);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(188, 32);
            this.ChangePassword.TabIndex = 4;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(46, 369);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(188, 32);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(89, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Main Menu";
            // 
            // AccountTable
            // 
            this.AccountTable.BackgroundColor = System.Drawing.Color.White;
            this.AccountTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountTable.Location = new System.Drawing.Point(-1, 244);
            this.AccountTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountTable.Name = "AccountTable";
            this.AccountTable.RowHeadersWidth = 51;
            this.AccountTable.Size = new System.Drawing.Size(290, 119);
            this.AccountTable.TabIndex = 7;
            this.AccountTable.Text = "dataGridView1";
            // 
            // User_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.MenuPlaceOrder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AccountTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Home";
            this.Load += new System.EventHandler(this.User_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MenuPlaceOrder;
        private System.Windows.Forms.Button OrderHistory;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AccountTable;
    }
}