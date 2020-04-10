using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task6
{
    
    public partial class Form1 : Form
    {
        string text1="";
        char simb = ' ';
        bool clear = false;
        List<string> g = new List<string>();
        void Dey()
        {
            g.Add(text1);
            if(simb != ' ')
            {
                if (text1 == "")
                {
                    text1 = textBox1.Text;
                    clear = true;
                }
                else
                {
                    switch (simb)
                    {
                        case '+':
                            text1 = Convert.ToString(Convert.ToDouble(text1) + Convert.ToDouble(textBox1.Text));
                            break;
                        case '-':
                            text1 = Convert.ToString(Convert.ToDouble(text1) - Convert.ToDouble(textBox1.Text));
                            break;
                        case '*':
                            text1 = Convert.ToString(Convert.ToDouble(text1) * Convert.ToDouble(textBox1.Text));
                            break;
                        case '/':
                            text1 = Convert.ToString(Convert.ToDouble(text1) / Convert.ToDouble(textBox1.Text));
                            break;

                    }
                    textBox1.Text = text1;
                    clear = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "1";
            else
                textBox1.Text = "1";
            clear = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "6";
            else
                textBox1.Text = "6";
            clear = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "7";
            else
                textBox1.Text = "7";
            clear = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "8";
            else
                textBox1.Text = "8";
            clear = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "9";
            else
                textBox1.Text = "9";
            clear = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            simb = '+';
            Dey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "4";
            else
                textBox1.Text = "4";
            clear = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "5";
            else
                textBox1.Text = "5";
            clear = false;
        }

        private void minus_Click(object sender, EventArgs e)
        {

            simb = '-';
            Dey();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "2";
            else
                textBox1.Text = "2";
            clear = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "3";
            else
                textBox1.Text = "3";
            clear = false;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Dey();
            simb = '*';
            
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            text1 = "";
            simb = ' ';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (clear == false)
                textBox1.Text += "0";
            else
                textBox1.Text = "0";
            clear = false;
        }

        private void point_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void div_Click(object sender, EventArgs e)
        {
            Dey();
            simb = '/';
            

        }

        private void ecvi_Click(object sender, EventArgs e)
        {
            Dey();
            simb = ' ';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
