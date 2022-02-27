namespace Pronto
{
    partial class frm_gcash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gcash));
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbox_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.btn_verify = new System.Windows.Forms.Button();
            this.btn_resendcode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Orange;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_confirm.Location = new System.Drawing.Point(73, 537);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(203, 44);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Visible = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Merchant: Pronto Delivery Services";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 267);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 27);
            this.textBox1.TabIndex = 14;
            // 
            // txtbox_code
            // 
            this.txtbox_code.Location = new System.Drawing.Point(136, 396);
            this.txtbox_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_code.Name = "txtbox_code";
            this.txtbox_code.Size = new System.Drawing.Size(181, 27);
            this.txtbox_code.TabIndex = 15;
            this.txtbox_code.Visible = false;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(14, 400);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(126, 20);
            this.lbl_code.TabIndex = 11;
            this.lbl_code.Text = "Verification Code:";
            this.lbl_code.Visible = false;
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_verify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_verify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_verify.Location = new System.Drawing.Point(214, 317);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(104, 44);
            this.btn_verify.TabIndex = 18;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // btn_resendcode
            // 
            this.btn_resendcode.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_resendcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_resendcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_resendcode.Location = new System.Drawing.Point(214, 448);
            this.btn_resendcode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_resendcode.Name = "btn_resendcode";
            this.btn_resendcode.Size = new System.Drawing.Size(104, 44);
            this.btn_resendcode.TabIndex = 19;
            this.btn_resendcode.Text = "Resend Code";
            this.btn_resendcode.UseVisualStyleBackColor = false;
            this.btn_resendcode.Visible = false;
            this.btn_resendcode.Click += new System.EventHandler(this.btn_resendcode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Input your GCash phone number, then click verify.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_gcash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_resendcode);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.txtbox_code);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_gcash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_gcash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbox_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Button btn_resendcode;
        private System.Windows.Forms.Label label3;
    }
}

