using System;

namespace Problem_1.Point_3D
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            var point = new Point3D(a, b, c);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartingPoint);



         
        }
    }
}
