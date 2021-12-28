using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //this.label1.Text = "0";
            this.main_num_label.ResetText();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            //.......................................................
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            //.......................................................
            this.main_num_label.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            //.......................................................
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            //.......................................................
            this.main_num_label.Text = "";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "x";
            //.......................................................
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            //.......................................................
            this.main_num_label.Text = "";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "/";
            //.......................................................
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            //.......................................................
            this.main_num_label.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double fn, sn, r = 0;
            //..................................................
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label.Text, out sn);
            //..................................................
            if (this.operator_label.Text == "+")
            {
                r = fn + sn;
            }
            //..................................................
            else if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }
            //..................................................
            else if (this.operator_label.Text == "x")
            {
                r = fn * sn;
            }
            //..................................................
            else if (this.operator_label.Text == "/")
            {
                r = fn / sn;
            }
            //..................................................
            this.main_num_label.Text = r.ToString();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + ".";
        }
    }
}
