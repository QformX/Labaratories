using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayMethods
{
    internal class HashTable
    {
        public void Start()
        {
            string[] butt = new string[7] { "Создать список", "Clear", "Найти по ключу", "Удалить пару", "Поиск по значению", "Выдать ключи", "Выдать значения" };
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
                    FindKey();
                }
                else if (ind == 3)
                {
                    RemovePair();
                }
                else if (ind == 4)
                {
                    FindItem();
                }
                else if (ind == 5)
                {
                    PrintKeys();
                }
                else if (ind == 6)
                {
                    PrintValues();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        public static Hashtable Create()
        {
            Console.Clear();
            Hashtable ht = new Hashtable();

            Console.WriteLine("Введите количество пар для ввода: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите ключ и значение: ");
                try
                {
                    ht.Add(Console.ReadLine(), Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("An element with this Key already exists.");
                }
            }

            return ht;
        }

        public static void Clear()
        {
            var ht = Create();

            ht.Clear();

            Console.WriteLine("Операция выполнена, словарь пуст");
            Console.ReadKey();
        }

        public static void FindKey()
        {
            Console.Clear();
            var ht = Create();
            Console.WriteLine("Введите ключ, который необходимо проверить: ");
            if (ht.ContainsKey(Console.ReadLine()) == true)
            {
                Console.WriteLine("Ключ присутствует");
            }
            else
            {
                Console.WriteLine("Ключ отсутствует");
            }
            Console.ReadKey();
        }

        public static void RemovePair()
        {
            Console.Clear();
            var ht = Create();
            Console.WriteLine("Введите ключ, который необходимо удалить");
            ht.Remove(Console.ReadLine());
            Console.ReadKey();
        }

        public static void FindItem()
        {
            Console.Clear();
            var ht = Create();

            Console.WriteLine("Введите ключ, который необходимо проверить: ");
            if (ht.ContainsValue(Console.ReadLine()) == true)
            {
                Console.WriteLine("Объект присутствует");
            }
            else
            {
                Console.WriteLine("Объект отсутствует");
            }
            Console.ReadKey();
        }

        public static void PrintKeys()
        {
            Console.Clear();
            var ht = Create();
            ICollection C = ht.Keys;
            string output = "";
            foreach (var str in C)
            {
                output += Convert.ToString(str) + '\n';
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }

        public static void PrintValues()
        {
            Console.Clear();
            var ht = Create();
            ICollection C = ht.Values;
            string output = "";
            foreach (var str in C)
            {
                output += Convert.ToString(str) + '\n';
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
