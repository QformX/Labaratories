using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RGR
{
    internal class Menu
    {
        private string[] Buttons;
        private int SelectInd;
        private string Title;
        private string Padle;

        public Menu(string[] buttons, string title = "", string padle = "") 
        {
            Buttons = SetNormalLength(buttons);
            Title = title;
            Padle = padle;
        }

        public void Display()
        {
            int x = (Console.WindowWidth / 2) - (Title.Length / 2);
            int y = 0;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Title);

            for (int i = 0; i < Buttons.Length; i++)
            {
                string curButton = Buttons[i];
                x = (Console.WindowWidth/2) - (curButton.Length/2);
                y = (Console.WindowHeight / 2) - (Buttons.Length/2);
                Console.SetCursorPosition(x, y + i);

                if (i == SelectInd)
                {
                    BackgroundColor = ConsoleColor.DarkCyan;
                    ForegroundColor= ConsoleColor.Black;
                    Console.WriteLine($">> {curButton}");
                } else
                {
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"   {curButton}");
                }
            }
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.DarkCyan;

            x = (Console.WindowWidth / 2) - (Padle.Length / 2);
            y = Console.WindowHeight - 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Padle);

            ResetColor();
            Console.CursorVisible = false;
        }

        public int Choice()
        {
            ConsoleKey inputKey;

            do
            {

                Clear();
                Display();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                inputKey = keyInfo.Key;

                if (inputKey == ConsoleKey.UpArrow)
                {
                    SelectInd--;
                    if (SelectInd == -1)
                    {
                        SelectInd = Buttons.Length - 1;
                    }
                }
                else if (inputKey == ConsoleKey.DownArrow)
                {
                    SelectInd++;
                    if (SelectInd == Buttons.Length)
                    {
                        SelectInd = 0;
                    }
                }
                else if (inputKey == ConsoleKey.Escape)
                {
                    SelectInd = 100;
                    return SelectInd;
                }

            } while (inputKey != ConsoleKey.Enter);

            return SelectInd;
        }

        internal static string[] SetNormalLength(string[] array)
        {
            int max = 0;

            foreach (var item in array)
            {
                if (item.Length > max)
                {
                    max = item.Length; 
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                int count = array[i].Length;
                while (max - count > -1)
                {
                    array[i] = array[i] + " ";
                    count++;
                }
            }

            return array;
        }

    }
}
