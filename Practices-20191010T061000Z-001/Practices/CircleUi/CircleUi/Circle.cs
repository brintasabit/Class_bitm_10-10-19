using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleUi
{
    class Circle
    {
        public double radius;
        public double result;

        public double Diameter()
        {
            result = radius * 2;
            return result;
        }
        public double Perimeter()
        {
            double diameter = Diameter();
            result = diameter * 3.14;
            return result;
        }
        public double Area()
        {
            result = (radius*2) * 3.14;
            return result;
        }
    }
}
