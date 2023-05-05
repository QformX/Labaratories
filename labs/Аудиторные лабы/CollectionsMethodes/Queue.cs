using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Queue_
    {
        public void Start()
        {
            string[] butt = new string[7] { "Создать список", "Пропустить", "Отфильтровать", "Соединить 2 очереди", "Разделить на под очереди", "Reverse", "Достать и удалить" };
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
                    Skip();
                }
                else if (ind == 2)
                {
                    Filter();
                }
                else if (ind == 3)
                {
                    Sum();
                }
                else if (ind == 4)
                {
                    Split();
                }
                else if (ind == 5)
                {
                    Reverse();
                }
                else if (ind == 6)
                {
                    GetNDel();
                }
                else if (ind == 100)
                {
                    break;
                }

            } while (true);
        }

        static Queue<string> Create()
        {
            Console.Write("Введите количество элеметов: ");
            int n = int.Parse(Console.ReadLine());
            Queue<string> que = new Queue<string>(n);

            for (int i = 0; i < n; i++)
            {
                que.Enqueue(Console.ReadLine());
            }

            return que;
        }

        static void Skip()
        {
            Console.Clear();

            var que = Create().SkipWhile(e => e.Length < 5);

            //Если в начале очереди стоят элементы, длина которых меньше 5, то они пропускаются, позже такие элементы допускаются

            Print(que);
        }

        static void Filter()
        {
            Console.Clear();

            var que = Create().Where(x => x.Length < 5);

            //Все элементы, длина которых меньше 5 пропускаются

            Print(que);
        }

        static void Sum()
        {
            Console.Clear();

            var que = Create();

            var tmp = Create();

            Print(tmp.Concat(que));
        }

        static void Split()
        {
            Console.Clear();

            var que = Create();

            foreach (var item in que.Chunk(3))
            {
                foreach (var elem in item)
                {
                    Console.WriteLine(elem);
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }

        static void Reverse()
        {
            Console.Clear();

            var que = Create();

            Print(que.Reverse());
        }

        static void GetNDel()
        {
            Console.Clear();

            var que = Create();

            Console.WriteLine(que.Dequeue());

            Console.ReadKey();
        }

        static void Print(IEnumerable<string> que)
        {
            int n = que.Count();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{que.ToArray()[i]} ");
            }

            Console.ReadKey();
        }
    }
}
