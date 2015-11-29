using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_2.Animall.Prop;


namespace Problem_2.Animall
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10]
            {   new Dog("Tony Montana", 2, "male"),
                
                new Kitten("Dimitrichka", 3),
                new Tomcat("Pesho", 1),
                new Frog("Ceco", 3, "male"),
                new Dog("Kiril", 13, "male"),
                new Dog("Petra", 15, "female"),
                new Cat("Evelin", 1, "female"),
                new Cat("Jenata", 4, "female"),
                new Tomcat("Pesho", 5),
                new Kitten("Marta", 6) };

            animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("{0}",new string('-',30));
            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"|{group.AnimalName}'s average age is: {group.AverageAge}"));
            Console.WriteLine("{0}", new string('-', 30));
        }
    }                  //$"|{"Animal :Cat",-15}|{"Name: "}{this.Name}|{"Age: "}{this.Age}|{"Gender: "}{this.Gender}"
}
