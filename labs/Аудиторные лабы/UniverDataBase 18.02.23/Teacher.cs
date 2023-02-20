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
    }
}
