using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayMethods
{
    internal class ListMet
    {
        public void Start()
        {
            string[] butt = new string[9] { "Создать список", "Clear", "Удалить по индексу", "Поиск элемента", "Удалить элемент", "Reverse", "Sort", "Insert", "GetRange" };
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
                     Clear();
                }
                else if (ind == 2)
                {
                    DelIndex();
                }
                else if (ind == 3)
                {
                    FindItem();
                }
                else if (ind == 4)
                {
                    DelItem();
                }
                else if (ind == 5)
                {
                    Reverse();
                }
                else if (ind == 6)
                {
                    SortLs();
                }
                else if (ind == 7)
                {
                    Insrt();
                }
                else if (ind == 8)
                {
                    PrintFrom();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        public static List<int> Create()
        {
            Console.Clear();

            List<int> ls = new List<int>();

            Console.WriteLine("Введите количество элементов списка: ");
            int kolvo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kolvo; i++)
            {
                ls.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return ls;
        }

        public static void Clear()
        {
            Console.Clear();

            List<int> ls = new List<int>();

            ls.Clear();

            Console.WriteLine("Операция выполнена");
            Console.ReadKey();
        }

        public static void DelIndex()
        {
            Console.Clear();

            var ls = Create();

            Console.WriteLine("Введите индекс объекта, который необходимо удалить: ");
            int index = Convert.ToInt32(Console.ReadLine());
            ls.RemoveAt(index);
            Console.WriteLine("Операция выполнена. Новый вид листа: ");

            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }

            Console.ReadKey();
        }

        public static void FindItem()
        {
            var ls = Create();

            Console.WriteLine("Введите название элемента: ");
            int item = Convert.ToInt32(Console.ReadLine());

            if (ls.Contains(item))
            {
                Console.WriteLine("Элемент есть в списке");
            }
            else
            {
                Console.WriteLine("Элемент отсутствует");
            }

            Console.ReadKey();
        }

        public static void DelItem()
        {
            var ls = Create();

            Console.WriteLine("Введите объект, который необходимо удалить (если в списке несколько одинаковых элементов, то удаляется только первый из них): ");
            int object1 = Convert.ToInt32(Console.ReadLine());
            if (ls.Remove(object1) == true)
            {
                Console.WriteLine("Операция выполнена. Новый вид листа: ");
                for (int i = 0; i < ls.Count; i++)
                {
                    Console.WriteLine(ls[i]);
                }

            }
            else
            {
                Console.WriteLine("Такого элемента нет в списке, попробуйте еще раз.");
            }

            Console.ReadKey();
        }

        public static void Reverse()
        {
            var ls = Create();

            ls.Reverse();
            
            Console.WriteLine("Операция выполнена. Новый вид листа: ");
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
            Console.ReadKey();
        }

        public static void SortLs()
        {
            var ls = Create();

            Console.WriteLine("Отсортированный список: ");
            ls.Sort();
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
            Console.ReadKey();
        }

        public static void Insrt()
        {
            var ls = Create();

            Console.WriteLine("Введите индекс, с которого хотите добавить элемент в лист: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элемент, который хотите добавить в лист: ");
            int object1 = Convert.ToInt32(Console.ReadLine());
            ls.Insert(index, object1);
            Console.WriteLine("Операция выполнена. Новый вид листа: ");
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
            Console.ReadKey();
        }

        public static void PrintFrom()
        {
            var ls = Create();

            Console.WriteLine("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Элементы, удовлетворяющие указанным условиям: ");
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine(ls.GetRange(index, count)[j]);
            }
            Console.ReadKey();
        }


    }
}
