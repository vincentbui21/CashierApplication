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
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Winform
{
    public partial class Product_management : Form
    {
        public Product_management()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter valid data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else
            {
                for (int i = 0; i <= listView1.Items.Count; i++)
                {
                    int ii = 0;
                    if (i== listView1.Items.Count)//if reach the end of the itemdata file without find the same product name then add the product
                    {
                        //Write item into file
                        FileStream fs = new FileStream("itemdata.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);

                        string holder = (textBox1.Text).ToUpper() + ";" + Convert.ToString(textBox2.Text) + ";" + "On Sale";

                        sw.WriteLine(holder);
                        sw.Flush();
                        sw.Close();

                        //Display item list in Listview
                        fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        listView1.Items.Clear();
                        comboBox1.Items.Clear();
                        string line = sr.ReadLine();

                        while (line != null)
                        {
                            string[] arr = line.Split(';');
                            if (arr.Length == 3)
                            {
                                ListViewItem lvi = new ListViewItem(arr[0]);
                                lvi.SubItems.Add(arr[1].ToString());
                                lvi.SubItems.Add(arr[2]);

                                listView1.Items.Add(lvi);
                                comboBox1.Items.Add(arr[0]);

                            }
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        break;
                    }
                    else if (textBox1.Text.ToUpper() != listView1.Items[i].SubItems[ii].Text)
                    {
                        ii++;
                        continue;
                    }
                    else if(textBox1.Text.ToUpper() == listView1.Items[i].SubItems[ii].Text)//check if item has already been added
                    {
                        MessageBox.Show($"{textBox1.Text} has already been added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                }
                
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Product_management_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button2;//Press enter will perform button 2 clicked
            //Display items in Listview
            FileStream fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            listView1.Items.Clear();
            string line = sr.ReadLine();

            while (line != null)
            {
                string[] arr = line.Split(';');
                if (arr.Length == 3)
                {
                    ListViewItem lvi = new ListViewItem(arr[0]);
                    lvi.SubItems.Add(arr[1].ToString());
                    lvi.SubItems.Add(arr[2]);

                    listView1.Items.Add(lvi);
                    comboBox1.Items.Add(arr[0]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            { //user will be able to leave the price of the product blank
                MessageBox.Show("Please input valid data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //get info from the user
                string product_name = comboBox1.SelectedItem.ToString();
                string product_price = textBox3.Text;
                string product_status = comboBox2.SelectedItem.ToString();

                // if user choose "Discontinue" => change it in the file
                string tempfile = Path.GetTempFileName();

                using (var sr = new StreamReader("itemdata.txt"))
                using (var sw = new StreamWriter(tempfile))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[]arr = line.Split(';');
                        if(arr.Length==3)
                        {
                            if (arr[0]==product_name && product_status == "Discontinue")
                            {
                                arr[2] = "Discontinue";
                                string holder = arr[0] + ";" + arr[1] + ";" + arr[2];
                                sw.WriteLine(holder);
                            }
                            else if (arr[0]==product_name && product_price != "")
                            {
                                arr[1] = product_price;
                                string holder = arr[0] + ";" + arr[1] + ";" + arr[2];
                                sw.WriteLine(holder);
                            }
                            else if (arr[0] == product_name && product_status == "On Sale")
                            {
                                arr[2] = "On Sale";
                                string holder = arr[0] + ";" + arr[1] + ";" + arr[2];
                                sw.WriteLine(holder);
                            }
                            else
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                File.Delete("itemdata.txt");
                File.Move(tempfile, "itemdata.txt");
            }

            FileStream fs = new FileStream("itemdata.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader srr = new StreamReader(fs);
            listView1.Items.Clear();
            comboBox1.Items.Clear();
            string linee = srr.ReadLine();

            while (linee != null)
            {
                string[] arr = linee.Split(';');
                if (arr.Length == 3)
                {
                    ListViewItem lvi = new ListViewItem(arr[0]);
                    lvi.SubItems.Add(arr[1].ToString());
                    lvi.SubItems.Add(arr[2]);

                    listView1.Items.Add(lvi);
                    comboBox1.Items.Add(arr[0]);
                }
                linee = srr.ReadLine();
            }
            srr.Close();
        }

        private void DragDrop_pnl_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false)==true) 
            {
                e.Effect = DragDropEffects.All;            
            }
        }

        private void DragDrop_pnl_DragDrop(object sender, DragEventArgs e)
        {
            //take dropped items and store in array
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            //open file item data and the dropped file
            FileStream fItem = new FileStream("itemdata.txt", FileMode.Open, FileAccess.Read);
            StreamReader srItem = new StreamReader(fItem);
            foreach (string files in droppedFiles)
            {
              FileStream f = new FileStream(files, FileMode.Open, FileAccess.Read);
              StreamReader sr = new StreamReader(f);
              string linef = sr.ReadLine();
              string lineItem = srItem.ReadLine();

              while(linef != null)
                {
                    string[] arrf = linef.Split(';');
                    while(lineItem != null)
                    {
                        string[] arrItem = lineItem.Split(';');
                        if (arrf[0].ToUpper() == arrItem[0].ToUpper())
                        {
                            if(MessageBox.Show($"{arrf[0]} has been added before!\n" +
                                $"Do you want to continue without {arrf[0]}", "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                MessageBox.Show("OK");//need to upgrade more _ 12/3/2023
                            }
                        }
                    }

                }
             
               



            }
        }

        private void DragDrop_pnl_DragOver(object sender, DragEventArgs e)
        {
            DragDrop_pnl.BackColor= Color.IndianRed;
        }

        private void DragDrop_pnl_DragLeave(object sender, EventArgs e)
        {
            DragDrop_pnl.BackColor = Color.LightCoral;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
