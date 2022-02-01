using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassCalcTurner
{
  

    public partial class Form1 : Form
    {

        String input = String.Empty;
        double num1 = 0;
        double num2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInputOutput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            num1 = double.Parse(input);
            num1 = Math.Sqrt(num1);
            input = num1.ToString();
            txtInputOutput.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "9";
            txtInputOutput.Text = input;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input = Math.Pow(Int32.Parse(input), 2).ToString();
            txtInputOutput.Text = input;
        }

        private void SquareYButton_Click(object sender, EventArgs e)
        {

        }

        private void Fraction_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void Del_Click(object sender, EventArgs e)
        {

        }

        private void Equals_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void Eight_Click(object sender, EventArgs e)
        {

        }

        private void Seven_Click(object sender, EventArgs e)
        {

        }

        private void Four_Click(object sender, EventArgs e)
        {

        }

        private void Five_Click(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {

        }

        private void Two_Click(object sender, EventArgs e)
        {

        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {

        }

        private void Decimal_Click(object sender, EventArgs e)
        {

        }

        private void Three_Click(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void Six_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }
    }
}
