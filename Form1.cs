using System;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        string currentOperator = "";
        double result = 0;
        string[] finalArray;
        public Form1()
        {
            InitializeComponent();
        }
        private void Digit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBox1.Text += button.Text;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentOperator = "";
            result = 0;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "+":
                    currentOperator = "+";
                    textBox1.Text += "+";
                    break;
                case "-":
                    currentOperator = "-";
                    textBox1.Text += "-";
                    break;
                case "/":
                    currentOperator = "/";
                    textBox1.Text += "/";
                    break;
                case "*":
                    currentOperator = "*";
                    textBox1.Text += "*";
                    break;
                case ".":
                    textBox1.Text += ".";
                    break;
            }
        }
        private void PeformCalculation(TextBox display, string operatorCurrent)
        {
            finalArray = display.Text.Split(operatorCurrent);

            if(operatorCurrent == "+")
            {
                result = double.Parse(finalArray[0]) + double.Parse(finalArray[1]);
            }

            else if (operatorCurrent == "-")
            {
                result = double.Parse(finalArray[0]) - double.Parse(finalArray[1]);
            }
            else if(operatorCurrent == "*")
            {
                result = double.Parse(finalArray[0]) * double.Parse(finalArray[1]);
            }
            else if(operatorCurrent == "/")
            {
                result = double.Parse(finalArray[0]) / double.Parse(finalArray[1]);

                if(double.Parse(finalArray[1]) == 0)
                {
                    MessageBox.Show("Can't divide by zero!");
                }
            }

            display.Clear();

            display.Text = result.ToString(); 
        }

        private void Equal_Click_1(object sender, EventArgs e)
        {

            try
            {
                PeformCalculation(textBox1, currentOperator);
            }

            catch (Exception)
            {
                if (finalArray != null)
                {
                    MessageBox.Show("Press \"Clear Calculations\" button");
                }
            }
        }
    }
}
