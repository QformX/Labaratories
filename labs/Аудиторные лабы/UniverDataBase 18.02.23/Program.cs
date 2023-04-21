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
            Menu menu = new Menu(new string[]{"Создать управленца", "Ввести список студентов", "...", "Вывести приказы", "Список должников у преподавателя", "Список должников по предмету" }, "База данных университета", "Для выхода - Esc");
            Admin adm = null;
            List<Teacher> tchrs = new List<Teacher>();
            List<Student> stdnts = new List<Student>();
            do
            {
                int ind = menu.Choice();
                if (ind == 0)
                {
                    Console.Clear();
                    adm = Admin.MakeNewAdmin();
                }
                else if (ind == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Кол-во студентов");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        stdnts.Add(Student.MakeNewStudent());
                    }
                }
                else if (ind == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Кол-во преподавателей");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        tchrs.Add(Teacher.MakeNewTeacher());
                    }
                }
                else if (ind == 3)
                {
                    if (adm != null) adm.FilterOrders();
                    else Console.WriteLine("Не создан управленец!");
                }
                else if (ind == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Напишите фамилию преподавателя");
                    FilterTaxes(Console.ReadLine(), tchrs, stdnts);
                }
                else if (ind == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Название дисциплины");
                    GetTaxes(stdnts, Console.ReadLine());
                }
                else if (ind == 100)
                {
                    Environment.Exit(0);
                }
            } while (true);

        }

        static void FilterTaxes(string sn, List<Teacher> t, List<Student> s)
        {
            
            foreach (var item in t)
            {
                if (sn == item.GetFIO)
                {
                    foreach (var disc in item.GetDisciplines)
                    {
                        foreach (var st in s)
                        {
                            if (st.IsHaveTaxesOn(disc))
                            {
                                Console.WriteLine(st.GetFIO + " | " + disc);
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        static void GetTaxes(List<Student> students, string disc)
        {
            Console.WriteLine($"Долги по {disc} имеют следующие студенты:");
            foreach (var student in students)
            {
                if (student.IsHaveTaxesOn(disc))
                {
                    Console.WriteLine(student.GetFIO);
                }
            }
            Console.ReadKey();
        }

    }
}
