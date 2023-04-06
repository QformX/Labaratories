using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class Program
    {
        static void Main(string[] args)
        {
            Third mathOp = new Third();
            Func<double, double, double>[] op = { mathOp.Add, mathOp.Substract, mathOp.Multiply, mathOp.Divide };
            Console.WriteLine("Выберите операцию");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = op[choice - 1](a, b);
            Console.WriteLine("Ответ {0}", result);
            Console.ReadKey();
        }
        
    }
}
