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
    public partial class frmload : Form
    { public string role { get; set; }
        public frmload()
        {
            InitializeComponent();
        }
       int percent = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 10;
            panel2.Width += 5;
            percent ++;
            lblpercent.Text =Convert.ToString( percent)+"%";
            progressBar1.Value = percent;
            if(progressBar1.Value == 100)
            {
                timer.Stop();
                if(role == "admin")
                {
                    frmadmin admin = new frmadmin();
                    admin.Show();
                }
                else if(role == "employee")
                {
                    frmemployee emp = new frmemployee();
                    emp.Show();
                }
                else if (role == "hr")
                {
                    frmhr hr = new frmhr();
                    hr.Show();
                }
            }
        }

        private void frmload_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
