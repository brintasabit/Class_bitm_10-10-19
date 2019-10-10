using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {
        public double fNumber;
        public double sNumber;
        public double result;

        public double Add()
        {
            result = fNumber + sNumber;
            return result;
        }
        public double Substract()
        {
            result = fNumber - sNumber;
            return result;
        }
        public double Multiply()
        {
            result = fNumber * sNumber;
            return result;
        }
        public double Divide()
        {
            result = fNumber / sNumber;
            return result;
        }

    }
}
