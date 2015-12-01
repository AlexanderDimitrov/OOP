using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Shapes.Prop;

namespace Problem1.Shapes
{

    public static class ProgramMain
    {
        public static void Main()
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(50.6, 92.3),
                new Circle(.66),
                new Rectangle(3, 5),
               
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name,-10} [Area: {shape.CalculateArea():F2} | Perimiter: {shape.CalculatePerimeter():F2}]");
            }
        }
    }

}
