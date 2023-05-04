using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Sale_form : Form
    {


        private string sale_indentify;
        public Sale_form()
        {
            InitializeComponent();
        }

        public Sale_form(string sale_name)
        {
            this.sale_indentify = sale_name;
            InitializeComponent();
        }
        public string SaleNameLabel
        {
            get { return sale_name.Text; }
            set { sale_name.Text = value; }
        }

        private void button3_Click(object sender, EventArgs e)//exit button
        {
            if (MessageBox.Show("Are you sure to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }
        private void Sale_form_Load(object sender, EventArgs e)
        {
            sale_name.Text = sale_indentify.ToUpper();
            timer1.Start();

            FileStream fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Product_lsv.Items.Clear();
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] arr = line.Split(';');
                if (arr.Length == 3 && arr[2] == "On Sale")
                {
                    product_list_cbb.Items.Add(arr[0]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }
        private void button4_Click(object sender, EventArgs e)//Add item
        {
            if (numericUpDown1.Value == 0)//check if the buyer buy at least 1 product
            {
                MessageBox.Show("You need to buy at least 1 to add!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (product_list_cbb.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose wanted product!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem lvi = new ListViewItem(product_list_cbb.SelectedItem.ToString());
                lvi.SubItems.Add(numericUpDown1.Value.ToString());

                //find the price of the product
                FileStream fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] arr = line.Split(';');

                    if (arr[0] == product_list_cbb.SelectedItem.ToString())
                    {
                        decimal quantity = numericUpDown1.Value;
                        decimal price = Convert.ToDecimal(arr[1]);
                        decimal pay = quantity * price;

                        lvi.SubItems.Add(pay.ToString());

                        tempTotal_lbl.Text = (Convert.ToDecimal(tempTotal_lbl.Text) + pay).ToString();
                    }
                    line = sr.ReadLine();
                }
                sr.Close();

                Product_lsv.Items.Add(lvi);
                numericUpDown1.Value = 0;
                product_list_cbb.Text = "Choose here";
                price_lbl.Text = "";
            }

    }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Delete chosen product
            foreach (ListViewItem item in Product_lsv.Items)
                if (item.Selected)
                {
                    tempTotal_lbl.Text = (Convert.ToDecimal(tempTotal_lbl.Text) - Convert.ToDecimal(item.SubItems[2].Text)).ToString();
                    Product_lsv.Items.Remove(item);
                }
        }

        private void button1_Click(object sender, EventArgs e)//pay
        {
            // reference to the Sale_form
            Sale_form saleForm = new Sale_form();


            decimal pay = Convert.ToDecimal(tempTotal_lbl.Text);
            if (pay == 0)
            {
                MessageBox.Show("You have not bought anything to pay", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pay_form form = new pay_form(pay);
                this.Hide();
                form.ShowDialog();

                FileStream fs = new FileStream("sale_record.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(Product_lsv.Items[1]);

                this.Show();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)//update price 
        {
            FileStream fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            numericUpDown1.Value = 1;
            while (line != null)
            {
                string[] arr = line.Split(';');
                if (arr.Length == 3 && arr[0] == product_list_cbb.SelectedItem.ToString())
                {
                    price_lbl.Text = arr[1];
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {  
            //open up the pay form
            pay_form f2 = new pay_form();
            this.Hide();
            f2.ShowDialog();

            string date = time_lbl.Text;
            // creating the file "ReportData.txt" for writing
            StreamWriter writer = new StreamWriter("ReportData.txt", true);

            // Iterating through each item in the list view
            foreach (ListViewItem item in Product_lsv.Items)
            {
                // Writing each column value separated by a comma
                writer.Write(item.SubItems[0].Text + ";");
                writer.Write(item.SubItems[1].Text + ";");
                writer.Write(item.SubItems[2].Text + ";");
                writer.WriteLine(date);
            }
            // Close the file
            writer.Flush();
            writer.Close();

            this.Show();
        }
    }


        
       
}
