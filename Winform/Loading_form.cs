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
    public partial class Loading_form : Form
    {
        public Loading_form()
        {
            InitializeComponent();
        }

        private void Loading_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value <100) {
                progressBar1.Value += 4;

                label2.Text= progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                Login_form form= new Login_form();
                this.Hide();
                form.ShowDialog();
                Application.Exit();
            }
        }

        
    }
}
