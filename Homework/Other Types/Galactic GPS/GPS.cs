using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Galactic_GPS
{
    class GPS
    {
        static void Main(string[] args)
        {
            var sofiaLocation = new Location(83.220058, 89.22111, Planet.Mars);
            Console.WriteLine(sofiaLocation);
            
        }
    }
}
