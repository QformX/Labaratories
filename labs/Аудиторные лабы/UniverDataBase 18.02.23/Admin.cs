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
            this.Orders = Orders ?? throw new ArgumentNullException(nameof(Orders));
        }

        public List<Order> GetOrders()
        {
            return Orders;
        }

        public static Admin MakeNewAdmin()
        {
            Console.Write("Фамилия\t");
            var a = Console.ReadLine();
            Console.Write("Имя\t");
            var b = Console.ReadLine();
            Console.Write("Отчество\t");
            var c = Console.ReadLine();
            Console.Write("Дата рождения\t");
            var d = Console.ReadLine();
            Console.Write("Должность\t");
            var e = Console.ReadLine();
            Console.WriteLine("Кол-во приказов");
            int k = Int32.Parse(Console.ReadLine());
            List<Order> orders = new List<Order>();
            for (int j = 0; j < k; j++)
            {
                Console.Write("Тип приказа\t");
                var a1 = Console.ReadLine();
                Console.Write("Номер приказа\t");
                var a2 = Int32.Parse(Console.ReadLine());
                Console.Write("Название приказа\t");
                var a3 = Console.ReadLine();
                Console.Write("Текст приказа\t");
                var a4 = Console.ReadLine();
                Order ord = new Order(a1, a2, a3, a4);
                orders.Add(ord);
            }

            Admin admin = new Admin(a, b, c, d, e, orders);
            return admin;
        }

        public void FilterOrders()
        {
            if (Orders.Count != 0)
            {
                do
                {
                    Menu menu = new Menu(new string[] { "Приказы для студентов", "Приказы для преподавателей", "Приказы для работников" }, "База данных университета", "Для выхода - Esc");
                    int ind = menu.Choice();

                    if (ind == 0)
                    {
                        Console.Clear();
                        foreach (var item in Orders)
                        {
                            if (item.GetPrefix() == "общий" || item.GetPrefix() == "студент")
                            {
                                item.PrintOrder();
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (ind == 1)
                    {
                        Console.Clear();
                        foreach (var item in Orders)
                        {
                            if (item.GetPrefix() == "преподаватель" || item.GetPrefix() == "общий")
                            {
                                item.PrintOrder();
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (ind == 2)
                    {
                        Console.Clear();
                        foreach (var item in Orders)
                        {
                            if (item.GetPrefix() == "работник" || item.GetPrefix() == "общий")
                            {
                                item.PrintOrder();
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (ind == 100)
                    {
                        break;
                    }
                } while (true);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Приказов нет");
                Console.ReadKey();
            }
        }
    }
}
