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

        String input1 = String.Empty;
        String input2 = String.Empty;
        String operator1 = String.Empty;
        String operator2 = String.Empty;
        bool usingInput2 = false;
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
            
            if (double.TryParse(input1, out parseResult)){
                txtInputOutput.Text = "";
                result = parseResult;
                result = Math.Sqrt(result);
                input1 = result.ToString();
                txtInputOutput.Text = input1;
            }
            else
            {
                txtInputOutput.Text = "0";
                Console.WriteLine("Cannot do operation");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (usingInput2 == false)
            {
                txtInputOutput.Text = "";
                input1 += "9";
                txtInputOutput.Text = input1;
            }
            else
            {
                txtInputOutput.Text = "";
                input2 += "9";
                txtInputOutput.Text = input2;
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            double parseResult = 0;
            
            if (double.TryParse(input1, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result = Math.Pow(result, 2);
                input1 = result.ToString();
                txtInputOutput.Text = input1;
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

            if (double.TryParse(input1, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result = 1 / result;
                input1 = result.ToString();
                txtInputOutput.Text = input1;
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
            if (input1.Any())
            {
                input1 = input1.Remove(input1.Length - 1);
                txtInputOutput.Text = input1;
            }
            if (!input1.Any())
            {

                txtInputOutput.Text = "0";

            }

           
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double parseResult1 = 0;
            double parseResult2 = 0;

            switch (operator1)
            {

                case ("*"):
                    

                    if (double.TryParse(input1, out parseResult1) && double.TryParse(input2, out parseResult2))
                    {
                        txtInputOutput.Text = "";
                        result = parseResult1 * parseResult2;
                        input1 = result.ToString();
                        txtInputOutput.Text = input1;
                    }
                    else
                    {
                        txtInputOutput.Text = "0";
                        Console.WriteLine("Cannot do operation");
                    }

                    break;

                case ("/"):
                    

                    if (double.TryParse(input1, out parseResult1) && double.TryParse(input2, out parseResult2))
                    {
                        txtInputOutput.Text = "";
                        result = parseResult1 / parseResult2;
                        input1 = result.ToString();
                        txtInputOutput.Text = input1;
                    }
                    else
                    {
                        txtInputOutput.Text = "0";
                        Console.WriteLine("Cannot do operation");
                    }

                    break;

                case ("-"):
                 

                    if (double.TryParse(input1, out parseResult1) && double.TryParse(input2, out parseResult2))
                    {
                        txtInputOutput.Text = "";
                        result = parseResult1 - parseResult2;
                        input1 = result.ToString();
                        txtInputOutput.Text = input1;
                    }
                    else
                    {
                        txtInputOutput.Text = "0";
                        Console.WriteLine("Cannot do operation");
                    }

                    break;

                case ("+"):
                  

                    if (double.TryParse(input1, out parseResult1) && double.TryParse(input2, out parseResult2))
                    {
                        txtInputOutput.Text = "";
                        result = parseResult1 + parseResult2;
                        input1 = result.ToString();
                        txtInputOutput.Text = input1;
                    }
                    else
                    {
                        txtInputOutput.Text = "0";
                        Console.WriteLine("Cannot do operation");
                    }

                    break;


                   

            }

            usingInput2 = false;
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "0";
            operator1 = "";
            operator2 = "";
            input1 = "";
            input2 = "";
            usingInput2 = false;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "8";
            txtInputOutput.Text = input1;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "7";
            txtInputOutput.Text = input1;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "4";
            txtInputOutput.Text = input1;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "5";
            txtInputOutput.Text = input1;
        }

        private void One_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "1";
            txtInputOutput.Text = input1;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "2";
            txtInputOutput.Text = input1;
        }

        private void ChangeSign_Click(object sender, EventArgs e)
        {
            double parseResult = 0;

            if (double.TryParse(input1, out parseResult))
            {
                txtInputOutput.Text = "";
                result = parseResult;
                result *= -1;
                input1 = result.ToString();
                txtInputOutput.Text = input1;
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
            input1 += "0";
            txtInputOutput.Text = input1;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!input1.Contains("."))
            {
                txtInputOutput.Text = "";
                input1 += ".";
                txtInputOutput.Text = input1;
            }
        }

        private void Three_Click(object sender, EventArgs e)
        {
            txtInputOutput.Text = "";
            input1 += "3";
            txtInputOutput.Text = input1;
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
            input1 += "6";
            txtInputOutput.Text = input1;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            usingInput2 = true;

            if (!operator1.Any())
            {
                operator1 += "*";

            }
            else
            {

                Equals_Click(sender, e);
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {

        }
    }
}
