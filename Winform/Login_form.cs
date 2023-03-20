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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("SELECT A ROLE", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == ""|| tb_Pass.Text == "")
            {
                MessageBox.Show("Please enter Username or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cbb_role.SelectedItem== null)
            {
                MessageBox.Show("Please choose a role", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cbb_role.SelectedItem=="SALE")
            {
                Sale_form form = new Sale_form(tb_UserName.Text);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                Admin_form form = new Admin_form();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void Login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void Login_form_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode== Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor= Color.IndianRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCoral;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tb_UserName.Text = "Vincent";
            tb_Pass.Text = "12345";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) {
                tb_Pass.UseSystemPasswordChar = true;
            }
            else
            {
                tb_Pass.UseSystemPasswordChar = false;
            }
        }
    }
}
