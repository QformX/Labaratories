using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            Console.WriteLine("Введите кол-во элементов коллекции");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите элемент ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            Requests(list, e => e == e);

            Console.WriteLine("После удаления нечётных элементов");

            Requests(list, e => e % 2 != 0);

            Console.ReadKey();
        }
        static void Requests(List<int> list, Predicate<int> del)
        {
            list = list.FindAll(del);
            var plus_m = from i in list where i > 0 select i;
            Console.WriteLine("Положительные");
            foreach (var i in plus_m) { Console.WriteLine(i); }
            var minus_summ = (from i in list where i < 0 select i).Sum();
            Console.WriteLine("Сумма отрицательных -- {0}", minus_summ);
            var count = (from i in list where i % 5 == 0 select i).Count();
            Console.WriteLine("Количество чисел кратных 5 -- {0}", count);
        }
    }
}
