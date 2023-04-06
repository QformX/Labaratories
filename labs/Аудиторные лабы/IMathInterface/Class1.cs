using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Third : IMath
    {
        public double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Substract(double v1, double v2)
        {
            return v1 - v2;
        }

        public double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Divide(double v1, double v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            return v1 / v2;
        }
    }
}
