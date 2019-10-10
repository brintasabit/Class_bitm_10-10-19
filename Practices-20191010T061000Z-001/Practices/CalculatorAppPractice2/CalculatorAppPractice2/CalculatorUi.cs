using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        Calculator calculator=new Calculator();
        private void AddButton_Click(object sender, EventArgs e)
        {
            calculator.fNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.sNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(calculator.Add());
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calculator.fNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.sNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(calculator.Substract());

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.fNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.sNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(calculator.Multiply());

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calculator.fNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calculator.sNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(calculator.Divide());

        }
    }
}
