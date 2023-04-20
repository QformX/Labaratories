using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class OpHandler
    {
        public void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public void Substract(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public void Divide(double a, double b)
        {
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Деление на ноль");
            }
        }
    }
}
