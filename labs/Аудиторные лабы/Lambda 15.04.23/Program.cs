using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        delegate int Answer(int a, int b, int c);

        static void Main()
        {
            Answer summ = (a, b, c) => a + b + c;
            Answer multply = (a, b, c) => a * b * c;
            Answer medium = (a, b, c) => summ(a, b, c)/3;
            Answer max = (a, b, c) =>
                {
                    int max_ = a;
                    if (b > max_) max_ = b;
                    if (c > max_) max_ = c;
                    return max_;
                };
            Answer min = (a, b, c) =>
            {
                int min_ = a;
                if (b < min_) min_ = b;
                if (c < min_) min_ = c;
                return min_;
            };

            Console.WriteLine("1 + 2 + 3 = " + summ(1, 2, 3));
            Console.WriteLine("1 * 2 * 3 = " + multply(1, 2, 3));
            Console.WriteLine("Среднее арифметическое чисел 1, 2, 3 равно " + medium(1, 2, 3));
            Console.WriteLine("Максимальный элемент среди чисел 1, 2, 3 равен " + max(1, 2, 3));
            Console.WriteLine("Минимальный элемент среди чисел 1, 2, 3 равен " + min(1, 2, 3));
            Console.ReadKey();
        }
    }
}
