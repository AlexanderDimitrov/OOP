using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("al",26, "EmailS@gmail.com");
            Person b = new Person("ev", 27);
           
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
