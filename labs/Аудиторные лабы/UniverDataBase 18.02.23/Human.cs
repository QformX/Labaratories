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

        public string GetFIO { get { return SecondName; } }

        public static Human MakeNewHuman()
        {
            Console.Write("Фамилия\t");
            var a = Console.ReadLine();
            Console.Write("Имя\t");
            var b = Console.ReadLine();
            Console.Write("Отчество\t");
            var c = Console.ReadLine();
            Console.Write("Дата рождения\t");
            var d = Console.ReadLine();

            Human hmn = new Human(a, b, c, d);
            return hmn;
        }
    }
}
