using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animall.Prop
{
    public class Frog:Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine($"|{"Frog",-20}|{"Kwak"}|");
        }
        public override string ToString()
        {
            string separator = "+" + new string('-', 15) + "+" + new string('-', 50) + "+";
            StringBuilder output = new StringBuilder();
            output.AppendLine(separator);
            output.AppendLine($"|{"Animal :Cat",-15}|{"Name: "}{this.Name}|{"Age: "}{this.Age}|{"Gender: "}{this.Gender}");
            output.AppendLine(separator);
            return output.ToString();
        }
    }
}
