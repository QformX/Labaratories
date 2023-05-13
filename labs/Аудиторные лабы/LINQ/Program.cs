using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            Console.Write("Введите кол-во элементов:\t");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Элементе номер {0}:\t", i + 1);
                list.Add(int.Parse(Console.ReadLine()));
            }

            int countP = list.Where(e => e > 0).Count();
            int countO = list.Where(e => e < 0).Count();
            int sum = list.Where(e => e % 2 == 0).Sum();

            Console.WriteLine("Количество положительных элементов = {0}", countP);
            Console.WriteLine("Количество отрицательных элементов = {0}", countO);
            Console.WriteLine("Сумма чётных элементов = {0}", sum);

            Console.ReadKey();
        }
    }
}
