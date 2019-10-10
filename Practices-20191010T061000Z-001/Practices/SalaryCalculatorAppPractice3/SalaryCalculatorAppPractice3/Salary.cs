using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    public class Salary
    {
        public string Name { get; set; }
        public double basic;
        public double home;
        public double medical;
        public double totalSalary;
        public double tSalary()
        {
            totalSalary = basic + home + medical;
            return totalSalary;
        }
    }
}
