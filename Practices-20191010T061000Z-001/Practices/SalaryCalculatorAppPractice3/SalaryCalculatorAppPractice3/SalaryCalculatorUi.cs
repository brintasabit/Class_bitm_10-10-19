using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        Salary salary=new Salary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            salary.Name = employeeNameTextBox.Text;
            salary.basic = Convert.ToDouble(basicAmountTextBox.Text);
            salary.medical = Convert.ToDouble(medicalAllowanceTextBox.Text);
            salary.home = Convert.ToDouble(homeRentTextBox.Text);
            MessageBox.Show(
                salary.Name +" "+ "your salary is: " 
                            + salary.tSalary());
        }
    }
}
