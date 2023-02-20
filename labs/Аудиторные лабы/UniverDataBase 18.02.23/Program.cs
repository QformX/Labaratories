using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            var admins = new List<Admin>();
            var teachers = new List<Teacher>();
            var students = new List<Student>();

            Console.WriteLine("Сколько администраторов?");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                admins.Add(MakeNewAdmin());
            }

            Console.WriteLine("Сколько преподавателей?");
            int k = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                teachers.Add(MakeNewTeacher());
            }

            admins[0].Info();
            Console.ReadKey();
        }

        static Admin MakeNewAdmin()
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();
            Console.WriteLine("Кол-во приказов");
            int k = Int32.Parse(Console.ReadLine());
            List<Order> orders = new List<Order>();
            for (int j = 0; j < k; j++)
            {
                var a1 = Console.ReadLine();
                var a2 = Int32.Parse(Console.ReadLine());
                var a3 = Console.ReadLine();
                var a4 = Console.ReadLine();
                Order ord = new Order(a1, a2, a3, a4);
                orders.Add(ord);
            }

            Admin admin = new Admin(a, b, c, d, e, orders);
            return admin;
        }

        static Teacher MakeNewTeacher()
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            var d = Console.ReadLine();
            var e = Console.ReadLine();
            Console.WriteLine("Кол-во дисциплин");
            int k = Int32.Parse(Console.ReadLine());
            List<string> dsplns = new List<string>();
            for (int j = 0; j < k; j++)
            {
                dsplns.Add(Console.ReadLine());
            }

            Teacher tchr = new Teacher(a, b, c, d, e, dsplns);
            return tchr;
        }
    }
}
