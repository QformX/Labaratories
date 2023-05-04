using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main()
        {
            GenArray<string> strArr = new GenArray<string>(4);
            GenArray<int> intArr = new GenArray<int>(4);
            GenArray<bool> boolArr = new GenArray<bool>(4);

            for (int i = 0; i < 5; i++)
            {
                strArr.Add("Привет");
                intArr.Add(5);
                boolArr.Add(true);
            }

            strArr.Delete();
            strArr.Delete();

            boolArr.Delete();

            Console.WriteLine(intArr.GetByIndex(3));

            strArr.Show();
            intArr.Show();
            boolArr.Show();

            Console.ReadKey();


        }
    }

    class GenArray<T>
    {
        int n = 0;
        int count = 0;
        int countOfAdds = 0;
        List<T> list;
        
        public GenArray(int n)
        {
            this.n = n;
            this.count = n - 1;
            list = new List<T>(n);
        }

        public void Add(T value)
        {
            if (countOfAdds < n)
            {
                list.Add(value);
                countOfAdds++;
            }
            else Console.WriteLine("Больше низя");
        }

        public void Delete()
        {
            if (count >= 0)
            {
            list[count] = default(T);
            count--;
            }
        }

        public T GetByIndex(int index)
        {
            if (index <= n) return list[index];

            return default(T);
        }

        public int GetLength()
        {
            return n;
        }

        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
