using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Order
    {
        string Prefix;
        int Number;
        string Name;
        string Text;

        public Order(string Prefix, int Number, string Name, string Text)
        {
            this.Prefix = Prefix;
            this.Number = Number;
            this.Name = Name;
            this.Text = Text;
        }
    }
}
