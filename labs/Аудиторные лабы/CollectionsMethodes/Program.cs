namespace ArrayMethods
{
    internal class Program
    {
        static void Main()
        {
            string[] butt = new string[7] { "Массивы", "Список", "Хэш-таблица", "ArrayList", "Очередь", "Stack", "SortedList" };
            Menu menu = new Menu(butt, "Меню", "");
            do
            {
                int ind = menu.Choice();

                if (ind == 0)
                {
                    ArrayMet arr = new ArrayMet();
                    arr.ArrayMethod();
                }
                else if (ind == 1)
                {
                    ListMet ls = new ListMet();
                    ls.Start();
                }
                else if (ind == 2)
                {
                    HashTable ht = new HashTable();
                    ht.Start();
                }
                else if (ind == 3)
                {
                    ArrLst al = new ArrLst();
                    al.Start();
                }
                else if (ind == 4)
                {
                    Queue_ que = new Queue_();
                    que.Start();
                }
                else if (ind == 5)
                {
                    Stack_ stk = new Stack_();
                    stk.Start();
                }
                else if (ind == 6)
                {
                    SortList sl = new SortList();
                    sl.Start();
                }
                else if (ind == 7)
                {
                    Azbuka dic = new Azbuka();
                    dic.Start();
                }
                else if (ind == 100)
                {
                    Environment.Exit(0);
                }
            } while (true);

            //CopyMet();
            //ReverseMet();
            //SortMet();
            //RankMet();
            //ClearMet();
            //BinarySearchMet();
            //IndexOfMet();
            //ExistMet();
            //TrueForAllMet();
            //FindMet();
        }
    }
}
