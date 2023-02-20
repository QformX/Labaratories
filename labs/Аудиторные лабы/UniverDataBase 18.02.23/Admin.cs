using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Admin : Human
    {
        string Post;
        List<Order> Orders;
        
        public Admin(string SecondName, string FirstName, string DadName, string DateBirth, string Post, List<Order>Orders) : base(SecondName, FirstName, DadName, DateBirth)
        {
            this.Post = Post;
            this.Orders = Orders;
        }
    }
}
