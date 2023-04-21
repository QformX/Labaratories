using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Teacher : Human
    {
        string Institution;
        List<string> Disciplines;

        public Teacher(string SecondName, string FirstName, string DadName, string DateBirth, string Institution, List<string> Disciplines) : base(SecondName, FirstName, DadName, DateBirth)
        {
            this.Institution = Institution;
            this.Disciplines = Disciplines;
        }

        public List<string> GetDisciplines { get { return this.Disciplines; } }

        public static Teacher MakeNewTeacher()
        {

            Console.Write("Фамилия\t");
            var a = Console.ReadLine();
            Console.Write("Имя\t");
            var b = Console.ReadLine();
            Console.Write("Отчество\t");
            var c = Console.ReadLine();
            Console.Write("Дата рождения\t");
            var d = Console.ReadLine();
            Console.Write("Кафедра\t");
            var e = Console.ReadLine();
            Console.Write("Кол-во дисциплин\t");
            int k = Int32.Parse(Console.ReadLine());
            List<string> dsplns = new List<string>();
            for (int j = 0; j < k; j++)
            {
                Console.Write("Название дисциплины\t");
                dsplns.Add(Console.ReadLine());
            }

            Teacher tchr = new Teacher(a, b, c, d, e, dsplns);
            return tchr;
        }

    }
}
