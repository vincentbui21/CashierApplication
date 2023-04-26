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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ComponentFactory.Krypton.Toolkit.ColorEventArgs e)
        {
            Product_management f1 = new Product_management ();
            this.Hide();
            f1.ShowDialog();
            this.Show();
            StringReader reader = new StringReader(@"C:\Users\edark\source\repos\Cash_Register\CashierApplication\Winform\bin\Debug\itemdata.txt");
        }
    }
}
