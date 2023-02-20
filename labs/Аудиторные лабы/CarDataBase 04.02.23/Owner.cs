using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Data_Base
{
    internal class Owner
    {
        string name;
        string b_year;
        string s_year;

        public Owner(string name, string b_year, string s_year)
        {
            this.name = name;
            this.b_year = b_year;
            this.s_year = s_year;
        }
    }
}
