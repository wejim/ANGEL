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
    public partial class Payroll : UserControl
    {
        getting_salary salary = new getting_salary();
        double sss = 0;
        double pagibig = 0;
        double tax = 0;
        double philhealth = 0;
        double overtime = 0;
        double hours = 0;
        double rate = 0;
        double overhours = 0;
        double overrate = 0;
        public Payroll()
        {
            InitializeComponent();
        }
       

        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void rbFulltime_CheckedChanged(object sender, EventArgs e)
        {
            //getting the fulltime gross salary
            if(rbFulltime.Checked == true)
            {
                hours = 8;
                rate = 150;
                salary.getfulltime = hours * rate;
                cbovertime.Show();
                lblober.Show();
                lblover.Show();
                txthrs.Show();

            }
            else
            {
                hours = 0;
                rate = 0;
                salary.getfulltime = hours * rate;
                cbovertime.Hide();
                lblober.Hide();
                lblover.Hide();
                txthrs.Hide();
            }
            txtgross.Text = Convert.ToString(salary.getgross());
        }

        private void rbParttime_CheckedChanged(object sender, EventArgs e)
        {
            //gettinf the parttime gross salary
            if(rbParttime.Checked== true)
            {
                hours = 4;
                rate = 80;
                salary.getparttime = hours * rate;
            }
            else
            {
                hours = 0;
                rate = 0;
                salary.getparttime = hours * rate;
            }
            txtgross.Text = Convert.ToString(salary.getgross());
        }

        private void txthrs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                overtime = Convert.ToDouble(txthrs.Text) * 45;
                overhours = Convert.ToDouble(txthrs.Text);
                overrate = 45;
                salary.getovertime = overtime;
                txtgross.Text = Convert.ToString(salary.getgross());
            }
            catch
            {
                MessageBox.Show("Please input numbers only", "INFORMATION");
            }
        }

        private void cbovertime_CheckedChanged(object sender, EventArgs e)
        {
            if(cbovertime.Checked== true)
            {
                txthrs.Enabled = true;
            }
        }

        private void cbSss_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSss.Checked == true)
            {
                sss = 100;
                salary.getsss = sss;
            }
            else
            {
                sss = 0;
                salary.getsss = sss;
            }
        }

        private void cbPagibig_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPagibig.Checked == true)
            {
                pagibig = 200;
                salary.getpagibig = pagibig;
            }
            else
            {
                pagibig = 0;
                salary.getpagibig = pagibig;
            }

        }

        private void cbTax_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTax.Checked == true)
            {
                tax = salary.getgross() * .10;
                salary.gettax = tax;
            }
            else
            {
                tax = 0;
                salary.gettax = tax;
            }
        }

        private void cbPhilhealth_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPhilhealth.Checked == true)
            {
                philhealth = 300;
                salary.getphilhealth = philhealth;
            }
            else
            {
                philhealth = 0;
                salary.getphilhealth = philhealth;
            }
        }

        private void btnOverall_Click(object sender, EventArgs e)
        {
            txtnetpay.Text = Convert.ToString(salary.getnetpay());
        }
    }
}
