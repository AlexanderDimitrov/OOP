using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.DCalculator.Model
{
    class DistanceCalculator

    {
  
       
        public static double DistanceBetweenPoint3D(Point3D a, Point3D b)
        {

            
            double distance = Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2);
            distance = Math.Sqrt(distance);
            return distance;
           
        }
    }
}

