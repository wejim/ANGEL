using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAngel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlUser.Show();
            if (cbrole.Text.ToLower() == "admin")
            {
                lblTitle.Text = "LOGIN AS ADMIN";
            }
            else if (cbrole.Text.ToLower() == "employee")
            {
                lblTitle.Text = "LOGIN AS employee";
            }
            else if (cbrole.Text.ToLower() == "hr")
            {
                lblTitle.Text = "LOGIN AS hr";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int attempt = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            //Restrictions to log in
            if (cbrole.Text.ToLower()=="admin" && txtPassword.Text =="admin" && txtUserName.Text == "admin")
            {
                frmload load = new frmload();
                load.role = "admin";
                load.Show();
                this.Hide();
            }
            else if (cbrole.Text.ToLower() == "employees" && txtPassword.Text == "employee" && txtUserName.Text == "employee")
            {
                frmload load = new frmload();
                load.role = "employee";
                load.Show();
                this.Hide();
            }
            else if (cbrole.Text.ToLower() == "hr" && txtPassword.Text == "hr" && txtUserName.Text == "hr")
            {
                frmload load = new frmload();
                load.role = "hr";
                load.Show();
                this.Hide();
            }
            {
                attempt--;
                MessageBox.Show("YOU ONLY HAVE " + attempt+ "ATTEMPTS LEFT", "NOTICE!!");
                if (attempt== 0)
                {
                    MessageBox.Show("LOG IN ATTEMPT REACHED", "NOTICE!!");
                }
                
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower()=="enter username")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToLower() == "enter password")
            {
                txtPassword.Clear();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
