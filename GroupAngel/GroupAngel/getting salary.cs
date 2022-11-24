using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAngel
{
    class getting_salary
    { 
        private double overtime;
        private double sss;
        private double partime;
        private double fulltime;
        private double pagibig; 
        private double philhealth; 
        private double tax;

        public double getovertime
        {
            get { return overtime; }
            set { overtime = value; }
        }
        public double getsss
        {
            get { return sss; }
            set { sss = value; }
        }
        public double getfulltime
        {
            get { return fulltime; }
            set { fulltime = value; }
        }
        public double getparttime
        {
            get { return partime; }
            set { partime = value; }
        }
        public double getpagibig
        {
            get { return pagibig; }
            set { pagibig = value; }
        }
        public double gettax
        {
            get { return tax; }
            set { tax = value; }
        }
        public double getphilhealth
        {
            get { return philhealth; }
            set { philhealth = value; }
        }

        public double getgross()
        {
            return getovertime + getfulltime + getparttime;
        }
        public double getnetpay()
        {
            return getgross() - getovertime - getpagibig - getphilhealth - getsss - gettax;
        }


    }
}
