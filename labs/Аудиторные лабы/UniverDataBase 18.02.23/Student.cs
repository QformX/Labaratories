using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student : Human
    {
        Dictionary<string, int> journal;

        public Student(string SecondName, string FirstName, string DadName, string DateBirth, Dictionary<string, int> journal) : base(SecondName, FirstName, DadName, DateBirth)
        {
            this.journal = journal;
        }

        public bool IsHaveTaxes()
        {
            bool result = false;
            foreach (var item in journal)
            {
                if (item.Value == 0)
                {
                    result = true;
                    return result;
                }
            }

            return result;
        }

        public bool IsHaveTaxesOn(string dspln)
        {
            foreach (var item in journal)
            {
                if (item.Value == 2 && item.Key == dspln)
                {
                    return true;
                }
            }

            return false;
        }

        public Dictionary<string, int> GetJornal => journal;
        public static Student MakeNewStudent()
        {
            Console.Write("Фамилия\t");
            var a = Console.ReadLine();
            Console.Write("Имя\t");
            var b = Console.ReadLine();
            Console.Write("Отчество\t");
            var c = Console.ReadLine();
            Console.Write("Дата рождения\t");
            var d = Console.ReadLine();
            Console.WriteLine("Кол-во дисциплин");
            int k = Int32.Parse(Console.ReadLine());
            Dictionary<string, int> jrnl = new Dictionary<string, int>();
            for (int j = 0; j < k; j++)
            {
                Console.Write("Дисциплина / оценка\t");
                string[] tmp = Console.ReadLine().Split();
                string dspln = tmp[0];
                int mark = Int32.Parse(tmp[1]);
                jrnl.Add(dspln, mark);
            }

            Student stnt = new Student(a, b, c, d, jrnl);
            return stnt;
        }
    }
}
