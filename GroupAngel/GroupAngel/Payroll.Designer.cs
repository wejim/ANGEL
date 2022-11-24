
namespace GroupAngel
{
    partial class Payroll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFulltime = new System.Windows.Forms.RadioButton();
            this.rbParttime = new System.Windows.Forms.RadioButton();
            this.cbovertime = new System.Windows.Forms.CheckBox();
            this.cbSss = new System.Windows.Forms.CheckBox();
            this.cbPagibig = new System.Windows.Forms.CheckBox();
            this.cbPhilhealth = new System.Windows.Forms.CheckBox();
            this.cbTax = new System.Windows.Forms.CheckBox();
            this.txthrs = new System.Windows.Forms.TextBox();
            this.lblover = new System.Windows.Forms.Label();
            this.lblober = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgross = new System.Windows.Forms.TextBox();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnOverall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnetpay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgross);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblober);
            this.groupBox1.Controls.Add(this.lblover);
            this.groupBox1.Controls.Add(this.txthrs);
            this.groupBox1.Controls.Add(this.cbovertime);
            this.groupBox1.Controls.Add(this.rbParttime);
            this.groupBox1.Controls.Add(this.rbFulltime);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTax);
            this.groupBox2.Controls.Add(this.cbPhilhealth);
            this.groupBox2.Controls.Add(this.cbPagibig);
            this.groupBox2.Controls.Add(this.cbSss);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(263, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DEDUCTIONS";
            // 
            // rbFulltime
            // 
            this.rbFulltime.AutoSize = true;
            this.rbFulltime.Location = new System.Drawing.Point(7, 34);
            this.rbFulltime.Name = "rbFulltime";
            this.rbFulltime.Size = new System.Drawing.Size(78, 20);
            this.rbFulltime.TabIndex = 0;
            this.rbFulltime.TabStop = true;
            this.rbFulltime.Text = "Fulltime";
            this.rbFulltime.UseVisualStyleBackColor = true;
            this.rbFulltime.CheckedChanged += new System.EventHandler(this.rbFulltime_CheckedChanged);
            // 
            // rbParttime
            // 
            this.rbParttime.AutoSize = true;
            this.rbParttime.Location = new System.Drawing.Point(7, 60);
            this.rbParttime.Name = "rbParttime";
            this.rbParttime.Size = new System.Drawing.Size(80, 20);
            this.rbParttime.TabIndex = 0;
            this.rbParttime.TabStop = true;
            this.rbParttime.Text = "Parttime";
            this.rbParttime.UseVisualStyleBackColor = true;
            this.rbParttime.CheckedChanged += new System.EventHandler(this.rbParttime_CheckedChanged);
            // 
            // cbovertime
            // 
            this.cbovertime.AutoSize = true;
            this.cbovertime.Location = new System.Drawing.Point(119, 36);
            this.cbovertime.Name = "cbovertime";
            this.cbovertime.Size = new System.Drawing.Size(85, 20);
            this.cbovertime.TabIndex = 1;
            this.cbovertime.Text = "Overtime";
            this.cbovertime.UseVisualStyleBackColor = true;
            this.cbovertime.Visible = false;
            this.cbovertime.CheckedChanged += new System.EventHandler(this.cbovertime_CheckedChanged);
            // 
            // cbSss
            // 
            this.cbSss.AutoSize = true;
            this.cbSss.Location = new System.Drawing.Point(16, 27);
            this.cbSss.Name = "cbSss";
            this.cbSss.Size = new System.Drawing.Size(54, 20);
            this.cbSss.TabIndex = 0;
            this.cbSss.Text = "SSS";
            this.cbSss.UseVisualStyleBackColor = true;
            this.cbSss.CheckedChanged += new System.EventHandler(this.cbSss_CheckedChanged);
            // 
            // cbPagibig
            // 
            this.cbPagibig.AutoSize = true;
            this.cbPagibig.Location = new System.Drawing.Point(16, 61);
            this.cbPagibig.Name = "cbPagibig";
            this.cbPagibig.Size = new System.Drawing.Size(80, 20);
            this.cbPagibig.TabIndex = 1;
            this.cbPagibig.Text = "Pag-ibig";
            this.cbPagibig.UseVisualStyleBackColor = true;
            this.cbPagibig.CheckedChanged += new System.EventHandler(this.cbPagibig_CheckedChanged);
            // 
            // cbPhilhealth
            // 
            this.cbPhilhealth.AutoSize = true;
            this.cbPhilhealth.Location = new System.Drawing.Point(16, 95);
            this.cbPhilhealth.Name = "cbPhilhealth";
            this.cbPhilhealth.Size = new System.Drawing.Size(92, 20);
            this.cbPhilhealth.TabIndex = 2;
            this.cbPhilhealth.Text = "Philhealth";
            this.cbPhilhealth.UseVisualStyleBackColor = true;
            this.cbPhilhealth.CheckedChanged += new System.EventHandler(this.cbPhilhealth_CheckedChanged);
            // 
            // cbTax
            // 
            this.cbTax.AutoSize = true;
            this.cbTax.Location = new System.Drawing.Point(17, 129);
            this.cbTax.Name = "cbTax";
            this.cbTax.Size = new System.Drawing.Size(78, 20);
            this.cbTax.TabIndex = 3;
            this.cbTax.Text = "Tax 10%";
            this.cbTax.UseVisualStyleBackColor = true;
            this.cbTax.CheckedChanged += new System.EventHandler(this.cbTax_CheckedChanged);
            // 
            // txthrs
            // 
            this.txthrs.Enabled = false;
            this.txthrs.Location = new System.Drawing.Point(152, 58);
            this.txthrs.Name = "txthrs";
            this.txthrs.Size = new System.Drawing.Size(52, 22);
            this.txthrs.TabIndex = 2;
            this.txthrs.Visible = false;
            this.txthrs.TextChanged += new System.EventHandler(this.txthrs_TextChanged);
            // 
            // lblover
            // 
            this.lblover.AutoSize = true;
            this.lblover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblover.Location = new System.Drawing.Point(93, 54);
            this.lblover.Name = "lblover";
            this.lblover.Size = new System.Drawing.Size(65, 28);
            this.lblover.TabIndex = 3;
            this.lblover.Text = "OVERTIME \r\nHOURS:";
            this.lblover.Visible = false;
            // 
            // lblober
            // 
            this.lblober.AutoSize = true;
            this.lblober.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblober.Location = new System.Drawing.Point(107, 90);
            this.lblober.Name = "lblober";
            this.lblober.Size = new System.Drawing.Size(112, 16);
            this.lblober.TabIndex = 4;
            this.lblober.Text = "Overtime Rate =45/hr";
            this.lblober.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fulltime Rate =150/hr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parttime  Rate =80/hr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gross Pay:";
            // 
            // txtgross
            // 
            this.txtgross.Location = new System.Drawing.Point(78, 130);
            this.txtgross.Name = "txtgross";
            this.txtgross.Size = new System.Drawing.Size(100, 22);
            this.txtgross.TabIndex = 8;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.txtnetpay);
            this.grp.Controls.Add(this.button1);
            this.grp.Controls.Add(this.btnOverall);
            this.grp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.Color.White;
            this.grp.Location = new System.Drawing.Point(3, 302);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(368, 77);
            this.grp.TabIndex = 2;
            this.grp.TabStop = false;
            this.grp.Text = "TOTAL";
            // 
            // btnOverall
            // 
            this.btnOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverall.Location = new System.Drawing.Point(6, 29);
            this.btnOverall.Name = "btnOverall";
            this.btnOverall.Size = new System.Drawing.Size(117, 31);
            this.btnOverall.TabIndex = 0;
            this.btnOverall.Text = "OVERALL PAY";
            this.btnOverall.UseVisualStyleBackColor = true;
            this.btnOverall.Click += new System.EventHandler(this.btnOverall_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(251, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // txtnetpay
            // 
            this.txtnetpay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetpay.Location = new System.Drawing.Point(129, 32);
            this.txtnetpay.Name = "txtnetpay";
            this.txtnetpay.Size = new System.Drawing.Size(100, 26);
            this.txtnetpay.TabIndex = 9;
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.grp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "Payroll";
            this.Size = new System.Drawing.Size(383, 430);
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtgross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblober;
        private System.Windows.Forms.Label lblover;
        private System.Windows.Forms.TextBox txthrs;
        private System.Windows.Forms.CheckBox cbovertime;
        private System.Windows.Forms.RadioButton rbParttime;
        private System.Windows.Forms.RadioButton rbFulltime;
        private System.Windows.Forms.CheckBox cbTax;
        private System.Windows.Forms.CheckBox cbPhilhealth;
        private System.Windows.Forms.CheckBox cbPagibig;
        private System.Windows.Forms.CheckBox cbSss;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.TextBox txtnetpay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOverall;
    }
}
