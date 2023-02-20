using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Human
    {
        string SecondName { get; set; }
        string FirstName;
        string DadName;
        int[] DateBirth;

        public Human(string SecondName, string FirstName, string DadName, string DateBirth)
        {
            this.SecondName = SecondName;
            this.FirstName = FirstName;
            this.DadName = DadName;
            this.DateBirth = Array.ConvertAll(DateBirth.Split('.'), int.Parse);
        }

        public void Info()
        {
            Console.WriteLine(SecondName);
            Console.WriteLine(FirstName);
            Console.WriteLine(DadName);
        }
    }
}
