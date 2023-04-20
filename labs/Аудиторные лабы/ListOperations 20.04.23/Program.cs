using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            OpHandler oper = new OpHandler();

            Operations op = new Operations();

            op.SomeOperation += oper.Sum;
            op.SomeOperation += oper.Substract;
            op.SomeOperation += oper.Multiply;
            op.SomeOperation += oper.Divide;

            Console.WriteLine("Введите two чиселс");
            double[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

            op.OnSomeOperation(ab[0], ab[1]);
            Console.ReadKey();
        }
    }
}
