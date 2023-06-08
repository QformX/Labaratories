namespace HashSetMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            Add(numbers);

            AddRepeatItem(numbers);

            ContainsMet(numbers);

            UnionWith(numbers);

            IntersectWithMet(numbers);

            ExceptWith(numbers);

            ClearMet(numbers);

            Console.ReadKey();
        }

        private static void ClearMet(HashSet<int> numbers)
        {
            numbers.Clear();
            Console.WriteLine("\nМетод Clear:");
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void ExceptWith(HashSet<int> numbers)
        {
            HashSet<int> numbers4 = new HashSet<int>() { 5 };
            numbers.ExceptWith(numbers4);
            Console.WriteLine("\nМетод ExceptWith:");
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void IntersectWithMet(HashSet<int> numbers)
        {
            HashSet<int> numbers3 = new HashSet<int>() { 2, 5, 6 };
            numbers.IntersectWith(numbers3);
            Console.WriteLine("\nМетод IntersectWith:");
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void UnionWith(HashSet<int> numbers)
        {
            HashSet<int> numbers2 = new HashSet<int>() { 2, 4, 5 };
            numbers.UnionWith(numbers2);
            Console.WriteLine("\nМетод UnionWith:");
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void ContainsMet(HashSet<int> numbers)
        {
            bool contains1 = numbers.Contains(1);
            bool contains4 = numbers.Contains(4);
            Console.WriteLine("\nМетод Contains:");
            Console.WriteLine("HashSet содержит число 1: " + contains1);
            Console.WriteLine("HashSet содержит число 4: " + contains4);
        }

        private static void AddRepeatItem(HashSet<int> numbers)
        {
            numbers.Add(2);
            Console.WriteLine("\nПытаемся добавить повторяющийся элемент 2 в HashSet:");
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void Add(HashSet<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Console.WriteLine("HashSet содержит: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}