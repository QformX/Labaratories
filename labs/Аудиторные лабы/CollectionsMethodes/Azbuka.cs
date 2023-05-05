using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Azbuka
    {
        public void Start()
        {
            string[] butt = new string[6] { "Создать список", "Содержится ли данный ключ", "Содержится ли данный элемент", "Удалить по ключу", "Reverse", "Получить список объектов" };
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
                    IsKeyExist();
                }
                else if (ind == 2)
                {
                    IsValueExist();
                }
                else if (ind == 3)
                {
                    RemoveByKey();
                }
                else if (ind == 4)
                {
                    Reverse();
                }
                else if (ind == 5)
                {
                    GetValues();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        static Dictionary<int, string> Create()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            Console.WriteLine("Введите количество элементов");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dic.Add(i, Console.ReadLine());
            }

            return dic;
        }

        static void IsKeyExist()
        {
            Console.Clear();

            var dic = Create();

            int key = int.Parse(Console.ReadLine());

            if (dic.ContainsKey(key))
            {
                Console.WriteLine("Ключ содержится");
            } else Console.WriteLine("Ключ не содержится");

            Console.ReadKey();
        }

        static void IsValueExist()
        {
            Console.Clear();

            var dic = Create();

            string val = Console.ReadLine();

            if (dic.ContainsValue(val))
            {
                Console.WriteLine("Элемент содержится");
            }
            else Console.WriteLine("Элемент не содержится");

            Console.ReadKey();
        }

        static void RemoveByKey()
        {
            Console.Clear();

            var dic = Create();

            int key = int.Parse(Console.ReadLine());

            dic.Remove(key);

            Print(dic);

            Console.ReadKey();
        }

        static void Reverse()
        {
            Console.Clear();

            var dic = Create();

            dic.Reverse();

            Print(dic);

            Console.ReadKey();
        }

        static void GetValues()
        {
            Console.Clear();

            var dic = Create();

            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        static void Print(Dictionary<int, string> sl)
        {
            foreach (var item in sl)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
