namespace Pronto
{
    partial class StartingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartLogin = new System.Windows.Forms.Button();
            this.StartSignup = new System.Windows.Forms.Button();
            this.StartGuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartLogin
            // 
            this.StartLogin.Location = new System.Drawing.Point(104, 310);
            this.StartLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartLogin.Name = "StartLogin";
            this.StartLogin.Size = new System.Drawing.Size(106, 64);
            this.StartLogin.TabIndex = 1;
            this.StartLogin.Text = "Login";
            this.StartLogin.UseVisualStyleBackColor = true;
            this.StartLogin.Click += new System.EventHandler(this.StartLogin_Click);
            // 
            // StartSignup
            // 
            this.StartSignup.Location = new System.Drawing.Point(104, 399);
            this.StartSignup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartSignup.Name = "StartSignup";
            this.StartSignup.Size = new System.Drawing.Size(106, 64);
            this.StartSignup.TabIndex = 2;
            this.StartSignup.Text = "Sign up";
            this.StartSignup.UseVisualStyleBackColor = true;
            this.StartSignup.Click += new System.EventHandler(this.StartSignup_Click);
            // 
            // StartGuest
            // 
            this.StartGuest.BackColor = System.Drawing.Color.Orange;
            this.StartGuest.Location = new System.Drawing.Point(104, 488);
            this.StartGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartGuest.Name = "StartGuest";
            this.StartGuest.Size = new System.Drawing.Size(106, 64);
            this.StartGuest.TabIndex = 3;
            this.StartGuest.Text = "Order as Guest";
            this.StartGuest.UseVisualStyleBackColor = false;
            this.StartGuest.Click += new System.EventHandler(this.StartGuest_Click);
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 656);
            this.Controls.Add(this.StartGuest);
            this.Controls.Add(this.StartSignup);
            this.Controls.Add(this.StartLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartLogin;
        private System.Windows.Forms.Button StartSignup;
        private System.Windows.Forms.Button StartGuest;
    }
}