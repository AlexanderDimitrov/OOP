using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop("HP 250 G4",
            "HP",
            "Intel Core i3-4005U (2-ядрен, 1.70 GHz)",
            "8 GB DDR3 1600Mhz",
            "AMD Radeon R5 M330 (2gb ddr)",
            "1TB SSD HDD (5400rPM/m)",
            "15.6-инчов (39.62 см) - 1366x768, матов",
            new Battery(BatteryType.NiCad, 3, 2550),
            4.5,
            819
            );

        Laptop laptop2 = new Laptop();



        Console.WriteLine(laptop);
        Console.WriteLine(laptop2);
    }
}

