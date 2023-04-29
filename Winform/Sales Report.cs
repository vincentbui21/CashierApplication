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

                    // If this is the third column, calculate the product of the second and third columns
                    if (i == 2)
                    {
                        // Get the values in the second and third columns
                        double value1 = double.Parse(Sales_table.GetControlFromPosition(1, rowIndex).Text);
                        double value2 = double.Parse(Sales_table.GetControlFromPosition(2, rowIndex).Text);

                        // Calculate the product
                        double product = value1 * value2;

                        // If there is already a label in the fourth column, update its text with the product
                        Label labelProduct = Sales_table.GetControlFromPosition(3, rowIndex) as Label;
                        if (labelProduct != null)
                        {
                            labelProduct.Text = product.ToString();
                        }
                        // If there is no label in the fourth column, create a new label and add it to the table layout panel
                        else
                        {
                            labelProduct = new Label();
                            labelProduct.Text = product.ToString();
                            Sales_table.Controls.Add(labelProduct, 3, rowIndex);
                        }
                    }
                }
            }
            double totalSales = 0;

            // Loop through each row in the Sales_table and get the value in the 4th column
            for (int i = 0; i < Sales_table.RowCount; i++)
            {
                Control control = Sales_table.GetControlFromPosition(3, i);
                if (control != null && control is Label)
                {
                    // If the control is a label, parse its text as a double and add it to the total sales
                    double sales = 0;
                    if (double.TryParse(control.Text, out sales))
                    {
                        totalSales += sales;
                    }
                }
            }

            // Set the text of the DailySales label to the total sales formatted as currency
            DailySales.Text = totalSales.ToString("C");

            // Set the default dates for the DateTimePicker controls
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(1);

            // Update the Sales_table and DailySales label
            UpdateSalesTable();

        }
        private void UpdateSalesTable()
        {
            // Clear the Sales_table
            Sales_table.Controls.Clear();

            // Add the headings to the first row
            Sales_table.ColumnStyles.Clear();
            Sales_table.RowStyles.Clear();
            Sales_table.ColumnCount = 4;
            Sales_table.RowCount = 1;
            Sales_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Sales_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Sales_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Sales_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            Sales_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            Sales_table.Controls.Add(new Label() { Text = "Item", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
            Sales_table.Controls.Add(new Label() { Text = "Quantity", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            Sales_table.Controls.Add(new Label() { Text = "Price", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, 0);
            Sales_table.Controls.Add(new Label() { Text = "Total", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, 0);

            // Initialize the daily, weekly, and monthly total variables
            double dailyTotal = 0;
            double weeklyTotal = 0;
            double monthlyTotal = 0;
            double yearlyTotal = 0;

            // Loop through the lines in the ReportData.txt file
            string[] lines = File.ReadAllLines("ReportData.txt");
            for (int i = 1; i < lines.Length; i++) // <-- start from the second row
            {
                string line = lines[i];
                string[] items = line.Split(';');

                // Parse the date from the fourth item
                DateTime date;
                if (!DateTime.TryParse(items[3], out date))
                {
                    // Invalid date format
                    MessageBox.Show($"Invalid date format in line {i + 1}: {items[3]}");
                    continue;
                }

                // Check if the date is within the selected range
                if (date >= dateTimePicker1.Value && date < dateTimePicker2.Value)
                {
                    // Check if the date is within the selected month
                    if (date.Month == dateTimePicker1.Value.Month)
                    {
                        // Add the items to the Sales_table
                        Sales_table.RowCount++;
                        Sales_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                        for (int j = 0; j < 3; j++)
                        {
                            Sales_table.Controls.Add(new Label() { Text = items[j], TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, j, Sales_table.RowCount - 1);
                        }

                        // Calculate the total and update the Sales_table
                        double quantity = double.Parse(items[1]);
                        double price = double.Parse(items[2]);
                        double itemTotal = quantity * price;
                        dailyTotal += itemTotal;
                        weeklyTotal += itemTotal;
                        monthlyTotal += itemTotal;
                        yearlyTotal += itemTotal;
                        Sales_table.Controls.Add(new Label() { Text = itemTotal.ToString("0.00"), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 3, Sales_table.RowCount - 1);
                    }
                }
            }

            // Update the DailySales, WeeklySales, and MonthlySales labels
            DailySales.Text = dailyTotal.ToString("0.00");
            WeeklySales.Text = weeklyTotal.ToString("0.00");
            MonthlySales.Text = monthlyTotal.ToString("0.00");
            YearlySales.Text = yearlyTotal.ToString("0.00");
       
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateSalesTable();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateSalesTable();
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            UpdateSalesTable();
        }
    }
  
}
