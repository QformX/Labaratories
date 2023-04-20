using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    delegate void Operation(double a, double b);
    

    class Operations
    {
        Operation[] op = new Operation[4];

        public event Operation SomeOperation
        {
            add
            {
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    if (op[i] == null)
                    {
                        op[i] = value;
                        break;
                    }
                    if (i == 4)
                    {
                        Console.WriteLine("Список заполнен");
                    }
                }
            }
            remove
            {
                int i = 0;
                for (i = 0; i < 4; i++)
                {
                    if (op[i] == value)
                    {
                        op[i] = null;
                        break;
                    }
                    if (i == 4)
                    {
                        Console.WriteLine("GG!!!");
                    }
                }
            }
        }

        public void OnSomeOperation(double a, double b)
        {
            for (int i = 0; i < 4; i++)
            {
                if (op[i] != null)
                {
                    op[i](a, b);
                }
            }
        }
    }
}
