using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Winform
{
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
            PopulateTableWithData();
        }
        private void PopulateTableWithData()
        {
            // path to itemdata.txt file
            string filePath = "C:\\Users\\edark\\source\\repos\\Cash_Register\\CashierApplication\\Winform\\bin\\Debug\\itemdata.txt";

            try
            {
                //a StreamReader object for reading
                StreamReader reader = new StreamReader(filePath);

                // Looping through each line of the file
                while (!reader.EndOfStream)
                {
                    // Read the line and split it into separate values
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    // Add a new row to the table
                    tableLayoutPanel1.RowCount++;

                    // Loop through each value in the line and add it to the table
                    for (int i = 0; i < values.Length; i++)
                    {
                        // Create a new label with the value
                        Label label = new Label();
                        label.Text = values[i];

                        // Add the label to the appropriate cell in the table
                        tableLayoutPanel1.Controls.Add(label, i, tableLayoutPanel1.RowCount - 1);
                    }
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
