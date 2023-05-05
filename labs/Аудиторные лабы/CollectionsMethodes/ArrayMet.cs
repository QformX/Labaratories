using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class ArrayMet
    {
        public void ArrayMethod()
        {
            string[] butt = new string[10] { "Copy", "Reverse", "Sort", "Rank", "Clear", "BinarySearch", "IndexOf", "Exist", "TrueForAll", "Find" };
            Menu menu = new Menu(butt, "Массивы", "");
            do
            {
                int ind = menu.Choice();

                if (ind == 0)
                {
                    CopyMet();
                }
                else if (ind == 1)
                {
                    ReverseMet();
                }
                else if (ind == 2)
                {
                    SortMet();
                }
                else if (ind == 3)
                {
                    RankMet();
                }
                else if (ind == 4)
                {
                    ClearMet();
                }
                else if (ind == 5)
                {
                    BinarySearchMet();
                }
                else if (ind == 6)
                {
                    IndexOfMet();
                }
                else if (ind == 7)
                {
                    ExistMet();
                }
                else if (ind == 8)
                {
                    TrueForAllMet();
                }
                else if (ind == 9)
                {
                    FindMet();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }
        static Array CreateArray(int n, Type type)
        {
            var arr = Array.CreateInstance(type, n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Элемент {0}", i);
                arr.SetValue(Console.ReadLine(), i);
            }
            return arr;
        }

        static void ReverseMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Перевёрнутый:");
            Array.Reverse(arr);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void FindMet()
        {
            Console.Clear();
            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            PrintL("Напишите объект, который необходимо найти");
            string tmp = Console.ReadLine();

            var u = Array.Find<string>((string[])arr, e => e == tmp);
            Print(u.ToString());

            Console.ReadKey();
        }

        static void TrueForAllMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Напишите букву:");
            string tmp = Console.ReadLine();

            PrintL($"Все элементы содержат букву {tmp}: {Array.TrueForAll<string>((string[])arr, e => e.ToLower().Contains(tmp))}");

            Console.ReadKey();
        }

        static void ExistMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Первый:");
            PrintArray(arr);

            Print("Напишите слово:");
            string tmp = Console.ReadLine();

            Print($"Массив содержит \"{tmp}\": {Array.Exists((string[])arr, e => e.ToLower().Equals(tmp))}");

            Console.ReadKey();
        }



        static void BinarySearchMet()
        {  
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Array.Sort(arr);
            Print("Отсортированный:");
            PrintArray(arr);

            Print("Элемент поиска:");
            var ind = Array.BinarySearch(arr, Console.ReadLine());
            Console.WriteLine(ind);

            Console.ReadKey();
        }

        static void IndexOfMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Элемент поиска:");
            PrintL(Array.IndexOf(arr, Console.ReadLine()).ToString());

            Console.ReadKey();
        }

        static void ClearMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Очищенный:");
            Array.Clear(arr, 0, arr.Length);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void SortMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Отсортированный:");
            Array.Sort(arr);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void RankMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));

            Print("Исходный:");
            PrintArray(arr);

            Print("Ранг:");
            PrintL(arr.Rank.ToString());

            Console.ReadKey();
        }

        static void CopyMet()
        {
            Console.Clear();

            PrintL("Кол-во элементов массива");

            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n, typeof(string));
            var arr_c = CreateArray(n, typeof(string));

            Array.Copy(arr, arr_c, arr.Length);
            Print("Исходный:");
            PrintArray(arr);

            Print("Копированный:");
            PrintArray(arr_c);

            Console.ReadKey();
        }

        static void PrintL(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Print(string txt)
        {
            Console.Write(txt + "\t");
        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                if (item != null)
                {
                    Print(item.ToString());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
