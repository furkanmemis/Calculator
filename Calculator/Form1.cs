using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Calculator : Form
    {
        
        public double result;
        public double temp;
        public string op;
        
        
        public Calculator()
        {
            InitializeComponent();

        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void plus_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "+";
            
        }

        private void sub_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "-";

        }

        private void mul_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "/";

        }

        private void point_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                textBox1.Text = "ERROR";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            temp = Convert.ToDouble(textBox1.Text);

            if(op == "+")
            {
                result += temp;
            }
            else if(op == "-")
            {
                result -= temp;
            }
            else if(op == "*")
            {
                result *= temp;
            }
            else if(op == "/")
            {
                if(temp == 0)
                {
                    textBox1.Text = "ERROR";
                }
                else
                {
                    result /= temp;
                }
            }
            else if(op == "mod")
            {
                result = result % temp;
            }
            else if(op == "pow")
            {
                double z = result;
                for(int i = 0; i < temp-1; i++)
                {
                    result = result * z;
                }
            }

            textBox1.Text = Convert.ToString(result);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "mod";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            result = 0;
            temp = 0;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "pow";
        }

        private void zz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
