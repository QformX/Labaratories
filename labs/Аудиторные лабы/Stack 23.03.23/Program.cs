using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().Replace(" ", "");

            if (IsQueueRight(text))
            {
                Console.WriteLine("Прав"); 
            }
            else
            {
                Console.WriteLine("НеПрав"); 
            }

            Console.ReadLine();
        }

        private static bool IsQueueRight(string text)
        {
            Stack<char> que_void = new Stack<char>();

            bool ans = true;

            foreach (var item in text)
            {
                if (item == '{' || item == '(' || item == '[')
                {
                    que_void.Push(item);
                }
                else if (que_void.Count() != 0)
                {
                    if (item == '}' && que_void.Peek() != '{')
                    {
                        return ans = false;
                    }
                    else if (item == ']' && que_void.Peek() != '[')
                    {
                        return ans = false;
                    }
                    else if (item == ')' && que_void.Peek() != '(')
                    {
                        return ans = false;
                    }
                    else
                    {
                        que_void.Pop();
                    }
                }
                else
                {
                    return ans = false;
                }
            }
            return ans;
        }

        static void Print(Stack<char> que)
        {
            foreach (var item in que)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
