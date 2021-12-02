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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text)){
                try
                {
                    textBox1.Text = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Valid Expression");
                }
            }
        }
    }
}
