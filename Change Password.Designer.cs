namespace Pronto
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            this.ChangePassOld = new System.Windows.Forms.TextBox();
            this.ChangePassNew = new System.Windows.Forms.TextBox();
            this.ChangePassConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePassOld
            // 
            this.ChangePassOld.Location = new System.Drawing.Point(53, 346);
            this.ChangePassOld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangePassOld.Name = "ChangePassOld";
            this.ChangePassOld.Size = new System.Drawing.Size(215, 27);
            this.ChangePassOld.TabIndex = 2;
            this.ChangePassOld.UseSystemPasswordChar = true;
            this.ChangePassOld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangePassOld_KeyPress);
            // 
            // ChangePassNew
            // 
            this.ChangePassNew.Location = new System.Drawing.Point(53, 434);
            this.ChangePassNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangePassNew.Name = "ChangePassNew";
            this.ChangePassNew.Size = new System.Drawing.Size(215, 27);
            this.ChangePassNew.TabIndex = 3;
            this.ChangePassNew.UseSystemPasswordChar = true;
            this.ChangePassNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangePassNew_KeyPress);
            // 
            // ChangePassConfirm
            // 
            this.ChangePassConfirm.Location = new System.Drawing.Point(53, 495);
            this.ChangePassConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangePassConfirm.Name = "ChangePassConfirm";
            this.ChangePassConfirm.Size = new System.Drawing.Size(215, 27);
            this.ChangePassConfirm.TabIndex = 4;
            this.ChangePassConfirm.UseSystemPasswordChar = true;
            this.ChangePassConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChangePassConfirm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Old Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Confirm New Password:";
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(112, 579);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(89, 50);
            this.ChangePassword.TabIndex = 9;
            this.ChangePassword.Text = "Confirm";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change Password";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(53, 530);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(132, 24);
            this.ShowPassword.TabIndex = 11;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(52, 376);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(-1, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(48, 29);
            this.Back.TabIndex = 12;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePassConfirm);
            this.Controls.Add(this.ChangePassNew);
            this.Controls.Add(this.ChangePassOld);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ChangePassOld;
        private System.Windows.Forms.TextBox ChangePassNew;
        private System.Windows.Forms.TextBox ChangePassConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}