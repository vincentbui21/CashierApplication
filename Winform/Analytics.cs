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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
  
        private void Import_btn_Click(object sender, EventArgs e)
        {
   
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }
    }
    }
