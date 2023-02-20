using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student : Human
    {
        List<int> Marks;
        List<string> Disciplines;

        public Student(string SecondName, string FirstName, string DadName, string DateBirth, List<int> Marks, List<string> Disciplines) : base(SecondName, FirstName, DadName, DateBirth)
        {
            this.Marks = Marks;
            this.Disciplines = Disciplines;
        }
    }
}
