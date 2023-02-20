using RGR;

namespace Car_Data_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>();

            string[] buttons = { "Заполнить", "Один владелец", "Старше выбранного года", "Фильтр по модели", "Выход" };

            Menu menu = new Menu(buttons);

            while (true)
            {
                Console.Clear();
                int selIndex = menu.Choice();

                if (selIndex == 0)
                {
                    FillList(listCar);
                }
                else if(selIndex == 1)
                {
                    OneOwList(listCar);
                }
                else if(selIndex == 2)
                {
                    Console.Clear();
                    Console.Write("Введите год:\t");
                    YoungYear(listCar, Int32.Parse(Console.ReadLine()));
                }
                else if(selIndex == 3)
                {
                    Console.Clear();
                    Console.Write("Введите марку:\t");
                    SelModel(listCar, Console.ReadLine());
                }
                else if(selIndex == 4)
                {
                    Exit();
                }
            }
        }

        static string OneOw(Car car)
        {
            if (car.OwnersLen == 1)
            {
                return car.Model + car.Year.ToString();
            }

            return null;
        }

        static void FillList(List<Car> listCar)
        {
            Console.Clear();
            string carText;
            do
            {
                List<Owner> ownerList = new List<Owner>();
                carText = Console.ReadLine();
                if (carText != "Стоп")
                {
                    Console.WriteLine("Введите кол-во владельцев:");
                    int n = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string[] tags = Console.ReadLine().Split();
                        Owner owner = new Owner(tags[0], tags[1], tags[2]);
                        ownerList.Add(owner);
                    }
                    string[] tag = carText.Split();

                    Car car = new Car(tag[0], tag[1], tag[2], ownerList);
                    listCar.Add(car);
                }
            } while (carText != "Стоп");
        }

        static void OneOwList(List<Car> listCar)
        {
            Console.Clear();

            foreach (var item in listCar)
            {
                if (OneOw(item) != null)
                {
                    Console.WriteLine(OneOw(item));
                }
            }

            Back();
        }

        static void YoungYear(List<Car> listCar, int selYear)
        {
            Console.Clear();

            foreach (var item in listCar)
            {
                if (item.Year < selYear)
                {
                    Console.WriteLine(item.Model + item.Year.ToString());
                }
            }

            Back();
        }

        static void SelModel(List<Car> listCar, string selModel)
        {
            Console.Clear();
            foreach (var item in listCar)
            {
                if (item.Model == selModel)
                {
                    Console.WriteLine(item.Model + item.Year.ToString());
                }
            }

            Back();
        }

        static void Back()
        {
            ConsoleKey inputKey;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                inputKey = keyInfo.Key;

            } while (inputKey != ConsoleKey.Escape);
        }

        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}