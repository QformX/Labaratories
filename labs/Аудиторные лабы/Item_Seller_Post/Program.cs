namespace ItemSellerPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var posts = new List<Post>();
            CreatePosts(posts);
            Console.WriteLine("Фильтрация поставок по дате. Введите дату:");
            string date = Console.ReadLine();
            Responce1(posts, date);
            Console.WriteLine("Фильтрация поставок по товару. Введите товар:");
            string item = Console.ReadLine();
            Responce2(posts, item);
            Console.WriteLine("Фильтрация поставок по поставщику. Введите поставщика:");
            string seller = Console.ReadLine();
            Responce3(posts, seller);
            Console.ReadKey();
        }

        static void CreatePosts(List<Post> posts)
        {
            Console.WriteLine("Введите количество поставок:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите id поставки");
                int idP = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во товаров");
                int countP = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату поставки");
                string dateP = Console.ReadLine();
                posts.Add(new Post(idP, countP, dateP, Item.CreateItem(), Seller.CreateItem()));
            }
        }

        static void Responce1(List<Post> posts, string date)
        {
            var filter = from post in posts
                         where post.GetPostDate() == date
                         select post;
            foreach (var item in filter)
            {
                Console.WriteLine(item.GetItemName() + " " + item.GetSellerName() + " " + item.GetCount());
            }
        }
        static void Responce2(List<Post> posts, string f_name)
        {
            var filter = from post in posts
                         where post.GetItemName() == f_name
                         select post;
            foreach (var item in filter)
            {
                Console.WriteLine(item.GetSellerName());
            }
        }

        static void Responce3(List<Post> posts, string f_name)
        {
            var filter = from post in posts
                         where post.GetSellerName() == f_name
                         select post;
            foreach (var item in filter)
            {
                Console.WriteLine(item.GetItemName());
            }
        }
    }

    class Item
    {
        public int Id;
        public string Name;

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static Item CreateItem()
        {
            Console.WriteLine("Введите id товара");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();

            return new Item(id, name);
        }
    }

    class Seller
    {
        public int Id;
        public string CompName;

        public Seller(int id, string compName)
        {
            Id = id;
            CompName = compName;
        }

        public static Seller CreateItem()
        {
            Console.WriteLine("Введите id поставщика");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();

            return new Seller(id, name);
        }
    }

    class Post
    {
        int Id;
        int Count;
        string Date;
        Item Item;
        Seller Seller;

        public Post(int id, int count, string date, Item item, Seller seller)
        {
            Id = id;
            Count = count;
            Date = date;
            Item = item;
            Seller = seller;
        }

        public string GetItemName()
        {
            return Item.Name;
        }

        public string GetSellerName()
        {
            return Seller.CompName;
        }

        public string GetPostDate()
        {
            return Date;
        }

        public int GetCount()
        {
            return Count;
        }
    }
}