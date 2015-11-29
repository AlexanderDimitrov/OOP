using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Laptop.Model
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery batteryType;
        private double batteryLife;
        public decimal price;


        //Declaring Constructors

        //Model
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Model"));
                }
                this.model = value;
            }
        }
        //Manufacturer
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Manufacturer"));
                }
                this.manufacturer = value;
            }
        }
        //Processor
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Processor"));
                }
                this.Processor = value;
            }
        }
        //RAM
        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "RAM"));
                }
                this.ram = value;
            }
        }
        //GraphicsCard
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Graphics Card"));
                }
                this.graphicsCard = value;
            }
            //HDD
        }
        public string Hhd
        {
            get { return this.hdd; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty));
                }
                this.hdd = value;
            }
        }
        //Sreen
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Screen"));

                }
                this.screen = value;
            }
        }
        //Battery
        public Battery BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        //BatteryLife
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(Constants.CantBeNegative, "Battery Life"));
                }
                this.batteryLife = value;

            }
            //Price
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(Constants.StringCantBeEmpty, "Price"));
                }
                this.price = value;
            }
        }
        //Override

        public override string ToString()
        {
            string separator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";
            StringBuilder output = new StringBuilder();
            output.AppendLine(separator);

            if (this.Manufacturer != null)
            {
                output.AppendLine($"|{"manufacturer",-15}|{this.manufacturer,-35}|");
                output.AppendLine(separator);
            }
            if (this.processor != null)
            {
                output.AppendLine($"|{"processor",-15}|{this.processor,-35}|");
                output.AppendLine(separator);
            }
            if (this.Ram != null)
            {
                output.AppendLine($"|{"RAM",-15}|{this.ram,-35}|");
                output.AppendLine(separator);
            }
            if (this.GraphicsCard != null)
            {
                output.AppendLine($"|{"GPU",-15}|{this.graphicsCard,-35}|");
                output.AppendLine(separator);
            }
            if (this.Hhd != null)
            {
                output.AppendLine($"|{"HDD",-15}|{this.hdd,-35}|");
                output.AppendLine(separator);
            }
            if (this.Screen != null)
            {
                output.AppendLine($"|{"Screen",-15}|{this.screen,-35}|");
                output.AppendLine(separator);
            }
            if (this.BatteryType != null)
            {
                output.AppendLine($"|{"Battery Type",-15}|{this.batteryType,-35}|");
                output.AppendLine(separator);
            }
            output.AppendLine($"|{"Price",-15}|{this.price,-35}|");
            output.AppendLine(separator);

            return output.ToString();
        }


    }
}


