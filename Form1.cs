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
        String operator1 = String.Empty;
        String operator2 = String.Empty;
        double result = 0;
        

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
            double parseResult = 0;
            
            if (double.TryParse(input, out parseResult)){
                txtInputOutput.Text = "";
                result = parseResult;
                result = Math.Sqrt(result);
                input = result.ToString();
                txtInputOutput.Text = input;
            }
            else
            {
                txtInputOutput.Text = "0";
                Console.WriteLine("Cannot do operation");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "9";
            txtInputOutput.Text = input;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            double parseResult = 0;
            
            if (double.TryParse(input, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result = Math.Pow(result, 2);
                input = result.ToString();
                txtInputOutput.Text = input;
            }
            else
            {
                txtInputOutput.Text = "0";
                Console.WriteLine("Cannot do operation");
            }
        }

        private void SquareYButton_Click(object sender, EventArgs e)
        {

        }

        private void Fraction_Click(object sender, EventArgs e)
        {
            double parseResult = 0;

            if (double.TryParse(input, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result = 1 / result;
                input = result.ToString();
                txtInputOutput.Text = input;
            }
            else
            {
                txtInputOutput.Text = "0";
                Console.WriteLine("Cannot do operation");
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {

        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (input.Any())
            {
                input = input.Remove(input.Length - 1);
                txtInputOutput.Text = input;
            }
            if (!input.Any())
            {

                txtInputOutput.Text = "0";

            }

           
        }

        private void Equals_Click(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "0";
            operator1 = "";
            operator2 = "";
            input = "";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "8";
            txtInputOutput.Text = input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "7";
            txtInputOutput.Text = input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "4";
            txtInputOutput.Text = input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "5";
            txtInputOutput.Text = input;
        }

        private void One_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "1";
            txtInputOutput.Text = input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "2";
            txtInputOutput.Text = input;
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            double parseResult = 0;

            if (double.TryParse(input, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result *= -1;
                input = result.ToString();
                txtInputOutput.Text = input;
            }
            else
            {
                txtInputOutput.Text = "0";
                Console.WriteLine("Cannot do operation");
            }
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "0";
            txtInputOutput.Text = input;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!input.Contains("."))
            {
                txtInputOutput.Text = "";
                input += ".";
                txtInputOutput.Text = input;
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "3";
            txtInputOutput.Text = input;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            
        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void Six_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input += "6";
            txtInputOutput.Text = input;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }
    }
}
