using System;


namespace Generic_List
{
    class Test
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list[4] = 19;
            Console.WriteLine(list);

            list.Add(-5);
            Console.WriteLine(list);

            Console.WriteLine("list[4] = " + list[4]);

            list.RemoveByIndex(list.Count - 1);
            Console.WriteLine(list);
            Console.WriteLine("{0}",new string('-',60));
            
            list.Insert(list.Count, 5);
            Console.WriteLine(list);
            Console.WriteLine("{0}", new string('-', 60));

            Console.WriteLine(list.GetIndexByValue(5));
            Console.WriteLine(list.IsContain(8));
            Console.WriteLine("{0}", new string('-', 60));

            Console.WriteLine("Highest = " + list.Max());
            Console.WriteLine("Lowest = " + list.Min());
            Console.WriteLine("{0}", new string('-', 60));

            list.RemoveAll();
            Console.WriteLine("After the List was Deleted = " + list);
            Console.WriteLine("{0}", new string('-', 60));

            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), true);
            



        }
    }
}
