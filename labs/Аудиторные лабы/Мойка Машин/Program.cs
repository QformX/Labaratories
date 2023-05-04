using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        delegate void delWash(Garage gar);

        static void Main()
        {
            delWash washing = Washer.Wash;

            Console.WriteLine("VVEDITE KOL-VO MASHIN");
            int n = int.Parse(Console.ReadLine());

            Garage gar = new Garage(n);

            washing(gar);
            
            Console.ReadLine();
        }
    }

    class Car
    {
        string Mark;
        string Sign;

        public Car(string Mark = "Unmarked", string Sign = "Unsigned")
        {
            this.Mark = Mark;
            this.Sign = Sign;
        }

        public string GetMark()
        {
            return Mark;
        }
    }

    class Washer
    {
        List<Car> cars;

        public Washer(List<Car> cars)
        {
            this.cars = cars;
        }

        public static void Wash(Garage gar)
        {
            for (int i = 0; i < gar.GetLength(); i++)
            {
                Car car = gar.TakeCar();
                Console.WriteLine("Машина {0} пoмыта!!!!", car.GetMark());
                gar.ReturnCar(car);  
            }
        }
    }

    class Garage
    {
        Queue<Car> gc_cars = new Queue<Car>();

        public Garage(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("MARKA: ");
                string mark = Console.ReadLine();
                Console.Write("NOMER: ");
                string sign = Console.ReadLine();

                Car car = new Car(mark, sign);

                gc_cars.Enqueue(car);
            }

            Console.WriteLine("GARAJ ZAPOLNEN");
        }

        public Car TakeCar()
        {
            return gc_cars.Dequeue();
        }

        public void ReturnCar(Car car)
        {
            gc_cars.Enqueue(car);
        }
        
        public int GetLength()
        {
            return gc_cars.Count;
        }
    }
}
