using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class SortList
    {
        public void Start()
        {
            string[] butt = new string[6] { "Создать список", "Найти ключ", "Удалить по индексу", "Поиск элемента", "Индекс ключа", "Индекс объекта" };
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
                    FindKey();
                }
                else if (ind == 2)
                {
                    RemoveInd();
                }
                else if (ind == 3)
                {
                    IsObjExist();
                }
                else if (ind == 4)
                {
                    IndOfKey();
                }
                else if (ind == 5)
                {
                    IndOfObj();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        static SortedList<int, string> Create()
        {
            SortedList<int, string> sl = new SortedList<int, string>();

            Console.WriteLine("Введите количество элементов списка");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sl.Add(2 * i + i, Console.ReadLine());
            }

            return sl;
        }

        static void FindKey()
        {
            Console.Clear();
            var sl = Create();

            Console.WriteLine("Введите ключ, который необходимо проверить: ");
            if (sl.ContainsKey(int.Parse(Console.ReadLine())) == true)
            {
                Console.WriteLine("Ключ присутствует");
            }
            else
            {
                Console.WriteLine("Ключ отсутствует");
            }
            Console.ReadKey();
        }

        static void RemoveInd()
        {
            Console.Clear();

            var sl = Create();

            Console.WriteLine("Введите ключ, который необходимо удалить");
            if (sl.Remove(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Удаление произведено успешно");
                Print(sl);
            }
            else
            {
                Console.WriteLine("Ключ не найден");
            }

            Console.ReadKey();
        }

        static void IsObjExist()
        {
            Console.Clear();

            var sl = Create();

            Console.WriteLine("Введите объект, который необходимо проверить: ");
            if (sl.ContainsValue(Console.ReadLine()) == true)
            {
                Console.WriteLine("Объект присутствует");
            }
            else
            {
                Console.WriteLine("Объект отсутствует");
            }
            Console.ReadKey();
        }

        static void IndOfKey()
        {
            Console.Clear();

            var sl = Create();

            Console.WriteLine("Введите ключ: ");
            int index = sl.IndexOfKey(int.Parse(Console.ReadLine()));
            Console.WriteLine("Индекс ключа: " + index);
            Console.ReadKey();
        }

        static void IndOfObj()
        {
            Console.Clear();

            var sl = Create();

            Console.WriteLine("Введите элемент: ");
            int index = sl.IndexOfValue(Console.ReadLine());
            Console.WriteLine("Индекс значения: " + index);
            Console.ReadKey();
        }

        static void Print(SortedList<int, string> sl)
        {
            foreach (var item in sl)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
