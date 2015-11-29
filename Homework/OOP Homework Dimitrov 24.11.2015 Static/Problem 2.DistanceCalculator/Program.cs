using System;
using Problem_2.DCalculator.Model;

namespace Problem_2.DCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X:");
            double entryX = double.Parse(Console.ReadLine());
            Console.Write("Enter Y:");
            double entryY = double.Parse(Console.ReadLine());
            Console.Write("Enter Z:");
            double entryZ = double.Parse(Console.ReadLine());
            Console.Write("Enter X1:");
            double entryX1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Y1:");
            double entryZ1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Z1:");
            double entryY1 = double.Parse(Console.ReadLine());

            var a = new Point3D(entryX, entryY, entryZ);
            var b = new Point3D(entryX1, entryY1, entryZ1);

            Console.WriteLine($"{DistanceCalculator.DistanceBetweenPoint3D(a, b):F8}");
        }
    }
}
