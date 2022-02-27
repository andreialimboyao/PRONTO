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
    public partial class Order_Form : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Isaiah\OneDrive\Desktop\PRONTO FINAL\Pronto.mdf;Integrated Security=True");

        string username, senderProvince, receiverProvince, courier, option, senderCity, receiverCity, a, b, deliveryfee, schedulereceipt;
        int basefare, weight, c;
        double distance, receiverLatitude, senderLatitude, senderLongitude, receiverLongitude, totalPrice, income;
        double[] latitude = new double[] { 14.7566, 14.4445, 14.5547, 14.6681, 14.5794, 14.5995, 14.6507, 14.4081, 14.6732, 14.4793, 14.5378, 14.5764, 14.5454, 14.6760, 14.6019, 14.5176, 14.7011 };
        double[] longitude = new double[] { 121.0450, 120.9939, 121.0244, 120.9658, 121.0359, 120.9842, 121.1029, 121.0415, 120.9350, 121.0198, 121.0014, 121.0851, 121.0687, 121.0437, 121.0355, 121.0509, 120.9830 };
        int[] ninjaVanInside = new int[] { 50, 175, 200, 225, 250, 275 };
        string[] provinceArray = new string[] { "Metro Manila", "Luzon", "Visayas", "Mindanao" };
        string[] cityArray = new string[] { "Caloocan", "Las Piñas", "Makati", "Malabon", "Mandaluyong", "Manila", "Marikina", "Muntinlupa", "Navotas", "Parañaque", "Pasay", "Pasig", "Pateros", "Quezon City", "San Juan", "Taguig", "Valenzuela" };

        int availablesameManila = 0, availablestandardManila = 0, availableLuzon = 0, availableVisayas = 0, availableMindanao = 0;
        //2 drivers per area where each driver can handle 3 transactions each;

        string[] city_low = new string[] { "Manila", "San Juan", "Mandaluyong", "Makati", "Pasay", "Pateros", "Pasig", "Taguig " };
        string[] city_medium1 = new string[] {"Valenzuela", "Caloocan", "Malabon", "Navotas"};
        string[] city_medium2 = new string[] { "Quezon City", "Marikina"};
        string[] city_medium3 = new string[] { "Parañaque", "Las Piñas", "Muntinlupa"};

        public Order_Form()
        {
            InitializeComponent();
        }

        //********************************************************EVENT************************************************************************
        private void DeliveryOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryOptions.SelectedIndex == 0)
            {
                this.option = "Same Day Delivery";
                SenderArea.SelectedItem = "Metro Manila";
                SenderArea.Enabled = false;
                ReceiverArea.SelectedItem = "Metro Manila";
                ReceiverArea.Enabled = false;
            }
            else
            {
                this.option = "Standard Delivery";
                SenderArea.Enabled = true;
                ReceiverArea.Enabled = true;
            }
        }

        private void SenderArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SenderArea.SelectedIndex == 0)
            {
                panel3.Visible = true;
            }
            else
            {
                SenderCity.SelectedIndex = -1;
                panel3.Visible = false;
            }
            this.senderProvince = provinceArray[SenderArea.SelectedIndex];
        }

        private void SenderNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiverNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SenderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ReceiverNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SenderCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SenderArea.SelectedIndex == 0)
            {
                senderLatitude = latitude[SenderCity.SelectedIndex];
                senderLongitude = longitude[SenderCity.SelectedIndex];
                this.senderCity = cityArray[SenderCity.SelectedIndex];
            }
           
        }

        private void ReceiverCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReceiverArea.SelectedIndex == 0)
            {
                receiverLatitude = latitude[ReceiverCity.SelectedIndex];
                receiverLongitude = longitude[ReceiverCity.SelectedIndex];
            }
            this.receiverCity = cityArray[ReceiverCity.SelectedIndex];
        }

        private void ReceiverArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReceiverArea.SelectedIndex == 0)
            {
                panel4.Visible = true;
            }
            else
            {
                ReceiverCity.SelectedIndex = -1;
                panel4.Visible = false;
            }
            this.receiverProvince = provinceArray[ReceiverArea.SelectedIndex];
        }

        private void PaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaymentMethod.SelectedIndex == 0)
            {
                panel2.Visible = true;
            }
            
            else
            {
                panel2.Visible = false;
            }
        }

        private void PackageWeight_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pronto weight pricing
            if (DeliveryOptions.SelectedIndex == 0 && SenderArea.SelectedIndex == 0 && ReceiverArea.SelectedIndex == 0 || //if same day metromanila<->metromanila
               DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 0 && ReceiverArea.SelectedIndex == 0) //if standard metromanila<->metromanila
            {
                if (PackageWeight.SelectedIndex == 0)
                {
                    this.weight = 49;
                }
                else if (PackageWeight.SelectedIndex == 1)
                {
                    this.weight = 169;
                }
                else if (PackageWeight.SelectedIndex == 2)
                {
                    this.weight = 189;
                }
                else if (PackageWeight.SelectedIndex == 3)
                {
                    this.weight = 209;
                }
                else if (PackageWeight.SelectedIndex == 4)
                {
                    this.weight = 229;
                }
                else if (PackageWeight.SelectedIndex == 5)
                {
                    this.weight = 249;
                }
            }

            else if (DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 1 && ReceiverArea.SelectedIndex == 1 || //if standard Luzon<->Luzon
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 1 && ReceiverArea.SelectedIndex == 0 || //if standard Luzon<->MetroManila
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 2 && ReceiverArea.SelectedIndex == 2 || //if standard Visayas<->Visayas
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 3 && ReceiverArea.SelectedIndex == 3) //if standard Mindanao<->Mindanao
            {
                if (PackageWeight.SelectedIndex == 0)
                {
                    this.weight = 149;
                }
                else if (PackageWeight.SelectedIndex == 1)
                {
                    this.weight = 399;
                }
                else if (PackageWeight.SelectedIndex == 2)
                {
                    this.weight = 459;
                }
                else if (PackageWeight.SelectedIndex == 3)
                {
                    this.weight = 519;
                }
                else if (PackageWeight.SelectedIndex == 4)
                {
                    this.weight = 579;
                }
                else if (PackageWeight.SelectedIndex == 5)
                {
                    this.weight = 639;
                }
            }

            //ninjavan Standard Delivery (within Metro Manila)
            else if (DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 0 && ReceiverArea.SelectedIndex == 0) //if standard MM <-> MM
            {
                if (PackageWeight.SelectedIndex == 0)
                {
                    this.weight = 50;
                }
                else if (PackageWeight.SelectedIndex == 1)
                {
                    this.weight = 175;
                }
                else if (PackageWeight.SelectedIndex == 2)
                {
                    this.weight = 200;
                }
                else if (PackageWeight.SelectedIndex == 3)
                {
                    this.weight = 225;
                }
                else if (PackageWeight.SelectedIndex == 4)
                {
                    this.weight = 250;
                }
                else if (PackageWeight.SelectedIndex == 5)
                {
                    this.weight = 275;
                }
            }

            //ninjavan Standard Delivery Pricing (Outside Metro Manila)
            else if (DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 0 && ReceiverArea.SelectedIndex == 2 || //if standard metromanila<->Visayas
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 0 && ReceiverArea.SelectedIndex == 3 || //if standard metromanila<->Mindanao
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 1 && ReceiverArea.SelectedIndex == 2 || //if standard Luzon<->Visayas
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 1 && ReceiverArea.SelectedIndex == 3 || //if standard Luzon<->Mindanao
                DeliveryOptions.SelectedIndex == 1 && SenderArea.SelectedIndex == 2 && ReceiverArea.SelectedIndex == 3) //if standard Mindanao<->Visayas
            {
                if (PackageWeight.SelectedIndex == 0)
                {
                    this.weight = 150;
                }
                else if (PackageWeight.SelectedIndex == 1)
                {
                    this.weight = 440;
                }
                else if (PackageWeight.SelectedIndex == 2)
                {
                    this.weight = 520;
                }
                else if (PackageWeight.SelectedIndex == 3)
                {
                    this.weight = 600;
                }
                else if (PackageWeight.SelectedIndex == 4)
                {
                    this.weight = 680;
                }
                else if (PackageWeight.SelectedIndex == 5)
                {
                    this.weight = 760;
                }
            }
        }

        private void Order_Form_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void FormPlaceOrder_Click(object sender, EventArgs e)
        {
            placeOrder();
            Receipt r = new Receipt();
            r.setUsername(this.username);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (this.username == "guest")
            {
                StartingPage start = new StartingPage();
                start.Show();
                this.Hide();
            }
            else
            {
                User_Home home = new User_Home();
                home.setUsername(this.username);
                home.Show();
                this.Hide();
            }
   
        }

        //********************************************************PUBLIC VOID************************************************************************

        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setVisible()
        {
            panel3.Visible = false;
        }

        public void updateInfo(string name, string contact, string address, string area, string city)
        {
            SenderAddress.Text = address;
            SenderName.Text = name;
            SenderNumber.Text = contact;
            SenderArea.SelectedItem = area;
            SenderCity.SelectedItem = city;
        }


        /// pronto base fare basis for sameday delivery.
        void base_Fare()
        {
            if(SenderCity.SelectedIndex != -1 && ReceiverCity.SelectedIndex != -1)
            {
                senderCity = SenderCity.SelectedItem.ToString();
                receiverCity = ReceiverCity.SelectedItem.ToString();
            }
            if (senderCity == receiverCity)
            {
                basefare = 50;
            }
            else if (city_low.Contains(senderCity) && city_low.Contains(receiverCity))
            {
                basefare = 75;
            }
            else if (city_medium1.Contains(senderCity) && city_medium1.Contains(receiverCity))
            {
                basefare = 150;
            }
            else if (city_medium1.Contains(senderCity) && city_medium1.Contains(receiverCity))
            {
                basefare = 150;
            }
            else if (city_medium2.Contains(senderCity) && city_medium2.Contains(receiverCity))
            {
                basefare = 150;
            }
            else if (city_medium3.Contains(senderCity) && city_medium3.Contains(receiverCity))
            {
                basefare = 150;
            }
            else if (city_low.Contains(senderCity) && city_medium1.Contains(receiverCity) ||
                     city_medium1.Contains(senderCity) && city_low.Contains(receiverCity))
            {
                basefare = 250;
            }
            else if (city_low.Contains(senderCity) && city_medium2.Contains(receiverCity) ||
                     city_medium2.Contains(senderCity) && city_low.Contains(receiverCity))
            {
                basefare = 250;
            }
            else if (city_low.Contains(senderCity) && city_medium3.Contains(receiverCity) ||
                     city_medium3.Contains(senderCity) && city_low.Contains(receiverCity))
            {
                basefare = 250;
            }
            else if (city_medium1.Contains(senderCity) && city_medium2.Contains(receiverCity) ||
                     city_medium2.Contains(senderCity) && city_medium1.Contains(receiverCity))
            {
                basefare = 250;
            }
            else if (city_medium1.Contains(senderCity) && city_medium3.Contains(receiverCity) ||
                     city_medium3.Contains(senderCity) && city_medium1.Contains(receiverCity))
            {
                basefare = 350;
            }
            else if (city_medium2.Contains(senderCity) && city_medium3.Contains(receiverCity) ||
                     city_medium3.Contains(senderCity) && city_medium2.Contains(receiverCity))
            {
                basefare = 350;
            }
        }

        void distanceKm()
        {
            double dLat = (Math.PI / 180) * (receiverLatitude - senderLatitude);
            double dLon = (Math.PI / 180) * (receiverLongitude - senderLongitude);


            // convert to radians
            senderLatitude = (Math.PI / 180) * senderLatitude;
            receiverLatitude = (Math.PI / 180) * receiverLatitude;

            // apply formulae
            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Pow(Math.Sin(dLon / 2), 2) *
                       Math.Cos(senderLatitude) *
                       Math.Cos(receiverLatitude);
            double rad = 6371;
            double c = 2 * Math.Asin(Math.Sqrt(a));
            this.distance = Math.Round(rad * c, 2);
        }

        void placeOrder()
        {
            this.c = 0;
            
            if (SenderCity.SelectedIndex != -1 && ReceiverCity.SelectedIndex != -1)
            {
                this.a = SenderAddress.Text + ", " + SenderCity.SelectedItem.ToString() + " " + SenderArea.SelectedItem.ToString();
                this.b = ReceiverAddress.Text + ", " + ReceiverCity.SelectedItem.ToString() + " " + ReceiverArea.SelectedItem.ToString();
                if (SenderArea.SelectedIndex != 0 || ReceiverArea.SelectedIndex !=0)
                {
                    this.c++;
                }
            }
            else if (SenderCity.SelectedIndex != -1 && ReceiverCity.SelectedIndex == -1)
            {
                this.a = SenderAddress.Text + ", " + SenderCity.SelectedItem.ToString() + " " + SenderArea.SelectedItem.ToString();
                this.b = ReceiverAddress.Text + ", " + ReceiverArea.SelectedItem.ToString();
                if (SenderArea.SelectedIndex != 0 || ReceiverArea.SelectedIndex == 0)
                {
                    this.c++;
                }
            }
            else if (SenderCity.SelectedIndex == -1 && ReceiverCity.SelectedIndex != -1)
            {
                this.a = SenderAddress.Text + ", " + SenderArea.SelectedItem.ToString();
                this.b = ReceiverAddress.Text + ", " + ReceiverCity.SelectedItem.ToString() + ", " + ReceiverArea.SelectedItem.ToString();
                if (SenderArea.SelectedIndex == 0 || ReceiverArea.SelectedIndex != 0)
                {
                    this.c++;
                }
            }
            else if (SenderCity.SelectedIndex == -1 && ReceiverCity.SelectedIndex == -1)
            {
                this.a = SenderAddress.Text + ", " + SenderArea.SelectedItem.ToString();
                this.b = ReceiverAddress.Text + ", " + ReceiverArea.SelectedItem.ToString();
                if (SenderArea.SelectedIndex == 0 || ReceiverArea.SelectedIndex == 0)
                {
                    this.c++;
                }
            }


            if (SenderAddress.Text != "" && SenderName.Text != "" && SenderNumber.Text != "" && ReceiverName.Text != "" &&
                ReceiverNumber.Text != "" && DeliveryOptions.SelectedIndex != -1 && PackageOptions.SelectedIndex != -1 &&
                PackageWeight.SelectedIndex != -1 && PaymentMethod.SelectedIndex != -1 && SenderArea.SelectedIndex != -1 &&
                ReceiverArea.SelectedIndex != -1)
            {
                if (DeliveryOptions.SelectedIndex == 0 && ReceiverCity.SelectedIndex == -1 || DeliveryOptions.SelectedIndex == 1 && ReceiverCity.SelectedIndex == -1 && ReceiverArea.SelectedIndex == 0)
                {
                    this.c++;
                    MessageBox.Show("Please complete the form");
                }
                else if (PaymentMethod.SelectedIndex == 0)
                {
                    if (!PaymentSender.Checked && !PaymentReceiver.Checked)
                    {
                        MessageBox.Show("Please complete the form");
                        this.c++;
                    }
                    else
                    {
                        this.c = 0;
                    }
                }
                
                else
                {
                    this.c = 0;
                }
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }

            int d = 0;
            if (this.c == 0)
            {
                const string message = "Are you sure about the details in this transaction?";
                const string caption = "Confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the yes button was pressed ...
                if (result == DialogResult.Yes)
                {
                    //courier and delivery computation
                    if (this.option == "Standard Delivery")
                    {
                        this.totalPrice = this.weight;

                        if (SenderArea.SelectedItem.ToString() == ReceiverArea.SelectedItem.ToString()) // if same area
                        {
                            //counter
                            if (SenderArea.SelectedItem.ToString() == "Metro Manila")
                            {
                                schedulereceipt = "Standard Delivery - Metro Manila";
                                if (this.availablestandardManila != 0)
                                {
                                    this.courier = "Pronto Delivery Services";
                                    this.income = totalPrice;
                                    this.availablestandardManila--;
                                }
                                else
                                {
                                    this.courier = "NinjaVan PH";
                                    this.income = this.totalPrice * 0.10;
                                    if (PaymentMethod.SelectedIndex == 0)
                                    {
                                        MessageBox.Show("Sorry! Due to shortage of available drivers, Pronto can only allow" +
                                            "other online payment methods for this delivery.");
                                        d++;
                                    }
                                }
                            }
                            else if (SenderArea.SelectedItem.ToString() == "Luzon")
                            {
                                this.schedulereceipt = "Standard Delivery - Province";
                                if (availableLuzon != 0)
                                {
                                    this.courier = "Pronto Delivery Services";
                                    this.income = totalPrice;
                                    this.availableLuzon--;
                                }
                                else
                                {
                                    this.courier = "NinjaVan PH";
                                    this.income = totalPrice * 0.10;
                                    if (PaymentMethod.SelectedIndex == 0)
                                    {
                                        MessageBox.Show("Sorry! Due to shortage of available drivers, Pronto can only allow" +
                                            "other online payment methods for this delivery.");
                                        d++;
                                    }
                                }
                            }
                            else if (SenderArea.SelectedItem.ToString() == "Visayas")
                            {
                                this.schedulereceipt = "Standard Delivery - Province";
                                if (availableVisayas != 0)
                                {
                                    this.courier = "Pronto Delivery Services";
                                    this.income = totalPrice;
                                    this.availableVisayas--;
                                }
                                else
                                {
                                    this.courier = "NinjaVan PH";
                                    this.income = totalPrice * 0.10;
                                    if (PaymentMethod.SelectedIndex == 0)
                                    {
                                        MessageBox.Show("Sorry! Due to shortage of available drivers, Pronto can only allow" +
                                            "other online payment methods for this delivery.");
                                        d++;
                                    }
                                }
                            }
                            else if (SenderArea.SelectedItem.ToString() == "Mindanao")
                            {
                                this.schedulereceipt = "Standard Delivery - Province";
                                if (this.availableLuzon != 0)
                                {
                                    this.courier = "Pronto Delivery Services";
                                    this.income = totalPrice;
                                    this.availableMindanao--;
                                }
                                else
                                {
                                    this.courier = "NinjaVan PH";
                                    this.income = this.totalPrice * 0.10;
                                    if (PaymentMethod.SelectedIndex == 0)
                                    {
                                        MessageBox.Show("Sorry! Due to shortage of available drivers, Pronto can only allow" +
                                            "other online payment methods for this delivery.");
                                        d++;
                                    }
                                }
                            }
                            
                        }
                        else if (SenderArea.SelectedItem.ToString() != ReceiverArea.SelectedItem.ToString())//if different area
                        {
                            this.schedulereceipt = "Standard Delivery - Province";
                            this.courier = "NinjaVan PH";
                            this.income = this.totalPrice * 0.10;
                            if (PaymentMethod.SelectedIndex == 0)
                            {
                                MessageBox.Show("Sorry! Pronto only accepts other online payment methods for inter-island deliveries. Please try again.");
                                d++;
                            }
                        }

                    }
                    else if (this.option == "Same Day Delivery")
                    {
                        this.schedulereceipt = "Same Day Delivery";
                        if (availablesameManila != 0)
                        {
                            this.courier = "Pronto Delivery Services";
                            base_Fare();
                            this.totalPrice = this.basefare + this.weight;
                            this.income = this.totalPrice;
                            this.availablesameManila--;
                        }
                        else
                        {
                            this.courier = "Mr. Speedy";
                            distanceKm();
                            this.totalPrice = 50 + (6 * this.distance) + 10 + 40;
                            this.income = this.totalPrice * 0.10;
                            if (PaymentMethod.SelectedIndex == 0)
                            {
                                MessageBox.Show("Sorry! Due to shortage of available drivers, Pronto can only allow" +
                                    "other online payment methods for this delivery. Please change your payment method.");
                                d++;
                            }
                        }
                    }

                    this.deliveryfee = this.totalPrice.ToString();

                    if (d == 0)
                    {
                        //TODO: INPUT totalprice and income in SQL. Dalawang column. Income and delivery fee.

                        //payment method rerouting
                        if (PaymentMethod.SelectedIndex == 0) //COD
                        {
                            Receipt r = new Receipt();
                            r.receipt(this.a, this.b, DeliveryOptions.SelectedItem.ToString(),
                                PaymentMethod.SelectedItem.ToString(), this.username, this.deliveryfee,
                                this.schedulereceipt, this.courier);
                            r.Show();
                            this.Hide();
                        }
                        else if (PaymentMethod.SelectedIndex == 1)
                        {
                            frm_gcash gcash = new frm_gcash();
                            gcash.receipt(this.a, this.b, DeliveryOptions.SelectedItem.ToString(),
                                PaymentMethod.SelectedItem.ToString(), this.username, this.deliveryfee,
                                this.schedulereceipt, this.courier);
                            gcash.Show();
                            this.Hide();
                        }
                        else if (PaymentMethod.SelectedIndex == 2)
                        {
                            frm_paymaya paymaya = new frm_paymaya();
                            paymaya.receipt(this.a, this.b, DeliveryOptions.SelectedItem.ToString(),
                                PaymentMethod.SelectedItem.ToString(), this.username, this.deliveryfee,
                                this.schedulereceipt, this.courier);
                            paymaya.Show();
                            this.Hide();
                        }
                        else if (PaymentMethod.SelectedIndex == 3)
                        {
                            frm_cardlink card = new frm_cardlink();
                            card.receipt(this.a, this.b, DeliveryOptions.SelectedItem.ToString(),
                                PaymentMethod.SelectedItem.ToString(), this.username, this.deliveryfee,
                                this.schedulereceipt, this.courier);
                            card.Show();
                            this.Hide();
                        }
                    }
                    
                }
                
                if (d == 0)
                {
                    con.Open();
                    string date = DateTime.Now.ToString("MM-dd-yyyy");
                    string month = date.Substring(0,2);
                    string day = date.Substring(3, 2);
                    int dayInt = Int32.Parse(day);
                    int week;
                    if (dayInt > 0 && dayInt < 8)
                    {
                        week = 1;
                    }
                    else if (dayInt > 7 && dayInt < 15)
                    {
                        week = 2;
                    }
                    else if (dayInt > 14 && dayInt < 22)
                    {
                        week = 3;
                    }
                    else
                    {
                        week = 4;
                    }
                    SqlCommand cmd = new SqlCommand("insert into Overall_Transactions(Date,Username" +
                        ",Sendername,Senderphone,Receivername,Receiverphone,Pick_up,Drop_off,Courier," +
                        "TypeofDelivery,Weight,PaymentMethod,Deliveryfee,Income,Month,Day, Week) " +
                        "values('" + date + "','" + this.username + "','" +
                        SenderName.Text + "','" + SenderNumber.Text + "','" + ReceiverName.Text + "','" +
                        ReceiverNumber.Text + "','" + a + "','" + b + "','" + this.courier + "','" +
                        DeliveryOptions.SelectedItem.ToString() + "','" + PackageWeight.SelectedItem.ToString() + "','" +
                        PaymentMethod.SelectedItem.ToString() + "','" + this.totalPrice + "','" + this.income + "','" + month + "','" + day + "','" + week + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }  
        }

    }
}

  
