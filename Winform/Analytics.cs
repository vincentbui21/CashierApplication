using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;

namespace Winform
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();

        }

        private void AnalyticsOption_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Create a new drop-down menu
            ToolStripDropDownMenu dropDownMenu = new ToolStripDropDownMenu();

            // Create some menu items
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Sales");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Top Product");


            // Add the menu items to the drop-down menu
            dropDownMenu.Items.Add(menuItem1);
            dropDownMenu.Items.Add(menuItem2);

        }
        private void Filter_btn1_Click(object sender, EventArgs e)
        {
            // Get the selected date range
            DateTime startDate = dateTimePicker_A.Value;
            DateTime endDate = dateTimePicker_B.Value;

            // Get the selected analytics option
            string analyticsOption = AnalyticsOption.SelectedItem.ToString();

            // Read the data from the text file
            string[] lines = File.ReadAllLines("ReportData.txt");

            // Prepare data for the chart
            Dictionary<string, Tuple<int, decimal>> chartData = new Dictionary<string, Tuple<int, decimal>>();

            foreach (string line in lines)
            {
                string[] items = line.Split(';');

                // Check if the date falls within the selected range
                DateTime date = DateTime.Parse(items[3]);
                if (date >= startDate && date <= endDate)
                {
                    string legend = items[0];
                    int quantity = int.Parse(items[1]);
                    decimal sales = decimal.Parse(items[2]);

                    if (analyticsOption == "Sales")
                    {
                        // Sum up values for items with the same legend
                        if (chartData.ContainsKey(legend))
                        {
                            Tuple<int, decimal> existingData = chartData[legend];
                            quantity += existingData.Item1;
                            sales += existingData.Item2;
                        }

                        chartData[legend] = new Tuple<int, decimal>(quantity, sales);
                    }
                    else if (analyticsOption == "Top Product")
                    {
                        // Use the second item as the value
                        decimal value = decimal.Parse(items[1]);

                        // Sum up values for items with the same legend
                        if (chartData.ContainsKey(legend))
                        {
                            value += chartData[legend].Item2;
                        }

                        chartData[legend] = new Tuple<int, decimal>(0, value);
                    }
                }
            }

            // Clear the chart
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Add data to the chart
            Series series = chart1.Series.Add(analyticsOption);
            series.ChartType = SeriesChartType.Column;

            foreach (string legend in chartData.Keys)
            {
                Tuple<int, decimal> data = chartData[legend];
                if (analyticsOption == "Sales")
                {
                    series.Points.AddXY(legend, data.Item2);
                }
                else if (analyticsOption == "Top Product")
                {
                    series.Points.AddXY(legend, data.Item2);
                }
            }

            // Set chart title
            chart1.Titles.Add(analyticsOption);
        }
    }
}