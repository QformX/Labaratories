using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayMethods
{
    internal class ArrLst
    {
        public void Start()
        {
            string[] butt = new string[8] { "Создать список", "Reverse", "GetRange", "Remove Index", "Find Last Index", "Insert", "Find Object", "Sort" };
            Menu menu = new Menu(butt, "Массивы", "");
            do
            {
                int ind = menu.Choice();

                if (ind == 0)
                {
                    Create();
                }
                else if (ind == 1)
                {
                    Reverse();
                }
                else if (ind == 2)
                {
                    PrintRange();
                }
                else if (ind == 3)
                {
                    RemoveInd();
                }
                else if (ind == 4)
                {
                    FindLastInd();
                }
                else if (ind == 5)
                {
                    Insrt();
                }
                else if (ind == 6)
                {
                    FindObj();
                }
                else if (ind == 7)
                {
                    Sort();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        public static ArrayList Create()
        {
            Console.Clear();
            var al = new ArrayList();

            Console.WriteLine("Введите кол-во элементов");

            int ind = int.Parse(Console.ReadLine());

            for (int i = 0; i < ind; i++)
            {
                Console.Write($"Элемент {i+1}:");
                string tmp = Console.ReadLine();
                al.Add(tmp);
            }

            return al;
        }

        public static void Reverse()
        {
            Console.Clear();

            var al = Create();

            al.Reverse();

            PrintAL(al);
            Console.ReadKey();
        }

        public static void PrintRange()
        {
            Console.Clear();

            var al = Create();

            Console.WriteLine("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов после индекса: ");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Элементы, удовлетворяющие указанным условиям: ");

            PrintAL(al.GetRange(index, kolvo));

            Console.ReadKey();
        }

        public static void RemoveInd()
        {
            Console.Clear();
            var al = Create();
            Console.WriteLine("Введите индекс элемента, который необходимо удалить");
            int index = Convert.ToInt32(Console.ReadLine());
            al.RemoveAt(index);
            Console.WriteLine("Операция выполнена. Новый вид листа: ");
            PrintAL(al);

            Console.ReadKey();
        }

        public static void FindLastInd()
        {
            Console.Clear();

            var al = Create();

            Console.WriteLine("Введите, что необходимо найти: ");
            string object1 = Console.ReadLine();
            Console.WriteLine("Индекс необходимого элемента: ");
            int index = al.LastIndexOf(object1);
            Console.WriteLine(index);

            Console.ReadKey();
        }

        public static void Insrt()
        {
            Console.Clear();

            var al = Create();

            Console.WriteLine("Введите индекс, с которого ввести элемент: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, которое необходимо ввести: ");
            string object1 = Console.ReadLine();
            al.Insert(index, object1);
            Console.WriteLine("Операция выполнена. Новый лист: ");
            PrintAL(al);
            Console.ReadKey();
        }

        public static void FindObj()
        {
            Console.Clear();

            var al = Create();

            Console.WriteLine("Введите, что необходимо найти: ");
            string object1 = Console.ReadLine();
            if (al.Contains(object1))
            {
                Console.WriteLine("Элемент содержится");
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
            Console.ReadKey();
        }

        public static void Sort()
        {
            Console.Clear();

            var al = Create();

            al.Sort();

            PrintAL(al);

            Console.ReadKey();
        }

        public static void PrintAL(ArrayList al)
        {
            Console.WriteLine(String.Join(", ", al.ToArray()));
        }
    }
}
