namespace Pronto
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.lbl_reminder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReceiptPickup = new System.Windows.Forms.Label();
            this.ReceiptDropoff = new System.Windows.Forms.Label();
            this.ReceiptDeliveryOption = new System.Windows.Forms.Label();
            this.ReceiptCourier = new System.Windows.Forms.Label();
            this.ReceiptTotalPayment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reminder
            // 
            this.lbl_reminder.BackColor = System.Drawing.Color.White;
            this.lbl_reminder.Location = new System.Drawing.Point(35, 463);
            this.lbl_reminder.Name = "lbl_reminder";
            this.lbl_reminder.Size = new System.Drawing.Size(257, 75);
            this.lbl_reminder.TabIndex = 32;
            this.lbl_reminder.Text = "Please wait for your courier ____________________________________________________" +
    "______________________________________________________________________\r\n\r\n\r\n\r\n\r\n" +
    "";
            this.lbl_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total Payment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Payment Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Delivery Option:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Drop-off:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pick-up:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "ORDER COMPLETE";
            // 
            // ReceiptPickup
            // 
            this.ReceiptPickup.BackColor = System.Drawing.Color.White;
            this.ReceiptPickup.Location = new System.Drawing.Point(122, 153);
            this.ReceiptPickup.Name = "ReceiptPickup";
            this.ReceiptPickup.Size = new System.Drawing.Size(170, 40);
            this.ReceiptPickup.TabIndex = 33;
            this.ReceiptPickup.Text = "________________________________________________________________________________";
            this.ReceiptPickup.Click += new System.EventHandler(this.ReceiptPickup_Click);
            // 
            // ReceiptDropoff
            // 
            this.ReceiptDropoff.BackColor = System.Drawing.Color.White;
            this.ReceiptDropoff.Location = new System.Drawing.Point(122, 199);
            this.ReceiptDropoff.Name = "ReceiptDropoff";
            this.ReceiptDropoff.Size = new System.Drawing.Size(170, 47);
            this.ReceiptDropoff.TabIndex = 34;
            this.ReceiptDropoff.Text = "______________________________________________________________________\r\n+++++++++" +
    "+++++++\r\n\r\n";
            // 
            // ReceiptDeliveryOption
            // 
            this.ReceiptDeliveryOption.AutoEllipsis = true;
            this.ReceiptDeliveryOption.AutoSize = true;
            this.ReceiptDeliveryOption.BackColor = System.Drawing.Color.White;
            this.ReceiptDeliveryOption.Location = new System.Drawing.Point(168, 256);
            this.ReceiptDeliveryOption.Name = "ReceiptDeliveryOption";
            this.ReceiptDeliveryOption.Size = new System.Drawing.Size(117, 20);
            this.ReceiptDeliveryOption.TabIndex = 35;
            this.ReceiptDeliveryOption.Text = "__________________";
            // 
            // ReceiptCourier
            // 
            this.ReceiptCourier.AutoSize = true;
            this.ReceiptCourier.BackColor = System.Drawing.Color.White;
            this.ReceiptCourier.Location = new System.Drawing.Point(111, 416);
            this.ReceiptCourier.Name = "ReceiptCourier";
            this.ReceiptCourier.Size = new System.Drawing.Size(111, 20);
            this.ReceiptCourier.TabIndex = 36;
            this.ReceiptCourier.Text = "_________________";
            // 
            // ReceiptTotalPayment
            // 
            this.ReceiptTotalPayment.AutoSize = true;
            this.ReceiptTotalPayment.BackColor = System.Drawing.Color.White;
            this.ReceiptTotalPayment.Location = new System.Drawing.Point(168, 368);
            this.ReceiptTotalPayment.Name = "ReceiptTotalPayment";
            this.ReceiptTotalPayment.Size = new System.Drawing.Size(111, 20);
            this.ReceiptTotalPayment.TabIndex = 37;
            this.ReceiptTotalPayment.Text = "_________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(48, 29);
            this.Back.TabIndex = 38;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Courier:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(168, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "_________________";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 656);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ReceiptTotalPayment);
            this.Controls.Add(this.ReceiptCourier);
            this.Controls.Add(this.ReceiptDeliveryOption);
            this.Controls.Add(this.ReceiptDropoff);
            this.Controls.Add(this.ReceiptPickup);
            this.Controls.Add(this.lbl_reminder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_reminder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReceiptPickup;
        private System.Windows.Forms.Label ReceiptDropoff;
        private System.Windows.Forms.Label ReceiptDeliveryOption;
        private System.Windows.Forms.Label ReceiptCourier;
        private System.Windows.Forms.Label ReceiptTotalPayment;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}