using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Components ram1 = new Components("2GB RAM", 20);
            Components ram2 = new Components("6GB RAM", 60);

            Components hdd1 = new Components("1TB HHD", 350);
            Components hdd2 = new Components("250GB HDD", 131);
            Components hdd3 = new Components("2TB SSD", 640);

            Components gpu1 = new Components("No Info", 0);
            Components gpu2 = new Components("ATI Radeon HD 5500", 65);
            Components gpu3 = new Components("NVidia GTX Titan", 650);

            Components cpu1 = new Components("Intel Core i3 2.4 GHz", 65);
            Components cpu2 = new Components("Intel Core i7 4.0 GHz", 315);
            Components cpu3 = new Components("Intel Core i5 3.2 GHz", 135);

            Components motherboard = new Components("Motherboard :AMD",200);
            Components motherboard2 = new Components("Motherboard Intel", 500);

            Computer PC1 = new Computer("PC1", new List<Components>() { ram2, hdd1, gpu1, cpu1,motherboard2 });
            Computer PC2 = new Computer("PC2", new List<Components>() { ram1, hdd2, gpu2, cpu2,motherboard });
            Computer PC3 = new Computer("PC4", new List<Components>() { ram1, hdd3, gpu3, cpu3,motherboard });
            Computer PC4 = new Computer("UnknownTrash");

            List<Computer> myList = new List<Computer>() { PC1, PC2, PC3, PC4 };
            myList = myList.OrderBy(pr => pr.Price).ToList();
            foreach (var pc in myList)
            {
                Console.WriteLine(pc.ToString());
            }
            
            
           
        }
    }
}
