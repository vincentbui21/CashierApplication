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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            string filePath = "ReportData.txt";

            // Read all lines from the file
            string[] lines = System.IO.File.ReadAllLines(filePath);

            // Loop through each line and split it by semicolon
            foreach (string line in lines)
            {
                string[] items = line.Split(';');

                // Create a new row in the table layout panel
                int rowIndex = Sales_table.RowCount++;
                Sales_table.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Loop through the first 3 items and add them to the row
                for (int i = 0; i < 3; i++)
                {
                    // If there are no more items in the line, break out of the loop
                    if (i >= items.Length)
                    {
                        break;
                    }

                    // Create a new label and set its text to the item
                    Label label = new Label();
                    label.Text = items[i];

                    // Add the label to the table layout panel at the current row and column
                    Sales_table.Controls.Add(label, i, rowIndex);
                }

            }
        }
    }
}
