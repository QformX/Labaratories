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

            int countP = (from item in list
                         where item > 0
                         select item).Count();

            int countO = (from item in list
                          where item < 0
                          select item).Count();

            int sum = (from item in list
                       where item % 2 == 0
                       select item).Sum();

            Console.WriteLine("Количество положительных элементов = {0}", countP);
            Console.WriteLine("Количество отрицательных элементов = {0}", countO);
            Console.WriteLine("Сумма чётных элементов = {0}", sum);

            Console.ReadKey();
        }
    }
}
