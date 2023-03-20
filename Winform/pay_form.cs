using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class pay_form : Form
    {
        private decimal total_price;
        public pay_form()
        {
            InitializeComponent();
        }
        public pay_form(decimal total_price)
        {
            InitializeComponent();
            this.total_price = total_price;
        }

        private void pay_form_Load(object sender, EventArgs e)
        {
            total_lbl.Text= total_price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += "0";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            cash_lbl.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)//delete all button
        {
            cash_lbl.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)//Back button
        {
            string s = cash_lbl.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else 
            {
                s = "";
            }
            cash_lbl.Text = s;
        }

        private void cash_lbl_TextChanged(object sender, EventArgs e)
        {
            if(cash_lbl.Text.Length > 0)
            {
                decimal change = (Convert.ToDecimal(cash_lbl.Text) - Convert.ToDecimal(total_lbl.Text));
                if (change >= 0)
                {
                    change_lbl.Text = change.ToString();
                }
                else
                {
                    change_lbl.Text = "";
                }
            }
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add5_Click(object sender, EventArgs e)
        {
            if(cash_lbl.Text.Length== 0)
            {
                cash_lbl.Text = (5).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 5).ToString();

            }
        }

        private void button_add10_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (10).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 10).ToString();

            }
        }

        private void button_add20_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (20).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 20).ToString();

            }
        }

        private void button_add50_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (50).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 50).ToString();

            }
        }

        private void button_add100_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (100).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 100).ToString();

            }
        }

        private void button_add200_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (200).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 200).ToString();

            }
        }

        private void button_add500_Click(object sender, EventArgs e)
        {
            if (cash_lbl.Text.Length == 0)
            {
                cash_lbl.Text = (500).ToString();
            }
            else
            {
                cash_lbl.Text = (Convert.ToDecimal(cash_lbl.Text) + 500).ToString();

            }
        }

        private void button21_Click(object sender, EventArgs e)//Enter button
        {
            if(change_lbl.Text == "")
            {
                MessageBox.Show("Payment required!");
            }
            else
            {             
                if (MessageBox.Show("Do you want receipt?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                }
            }
            
        }
    }
}
