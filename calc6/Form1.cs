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
        public string Action;
        public string Number1;
        public bool flag;

        public Form1()
        {
            flag = false;
            InitializeComponent();
        }

        private void DigitClick(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                // textBox1.Text = "0";
            }

            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void MathOpsClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Action = button.Text;
            Number1 = textBox1.Text;
            textBox1.Text += button.Text;
            flag = true;
        }

        private void ClearClick(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        

        private void ResultClick(object sender, EventArgs e)
        {
            double doubleN1, doubleN2, result = 0;
            doubleN1 = Convert.ToDouble(Number1);
            doubleN2 = Convert.ToDouble(textBox1.Text.Substring(Number1.Length+1));
            result = 0;

            if (Action == "+")
                result = doubleN1 + doubleN2;
            if (Action == "-")
                result = doubleN1 - doubleN2;
            if (Action == "*")
                result = doubleN1 * doubleN2;
            if (Action == "/")
                result = doubleN1 / doubleN2;
            if (Action == "%")
                result = (doubleN1 * doubleN2) / 100;

            Action = "=";
            flag = true;
            textBox1.Text = result.ToString();

        }

        private void ReverseClick(object sender, EventArgs e)
        {
            double double_number, result = 0;
            double_number = Convert.ToDouble(textBox1.Text);
            result = 1 / double_number;
            textBox1.Text = result.ToString();
        }

        private void SquareRootClick(object sender, EventArgs e)
        {
            double double_number, result = 0;
            double_number = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(double_number);
            textBox1.Text = result.ToString();
        }

        private void InverseClick(object sender, EventArgs e)
        {
            double double_number, result;
            double_number = Convert.ToDouble(textBox1.Text);
            result = -double_number;
            textBox1.Text = result.ToString();
        }

        private void CommaClick(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

    } 
}