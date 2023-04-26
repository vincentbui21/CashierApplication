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
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (listView1.Items[0].Selected)
            {
                Product_management f= new Product_management();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if((listView1.Items[1].Selected))
            { 
                MessageBox.Show("On progress, please wait!", "Chill out!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((listView1.Items[2].Selected))
            {
                Dashboard f = new Dashboard();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
        }
    }
}
