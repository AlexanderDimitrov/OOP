using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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

    public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen, Battery batteryType, double batteryLife, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.BatteryType = batteryType;
        this.BatteryLife = batteryLife;
        this.Price = price;
    }


   
    public Laptop(string model, string screen, Battery battery, double batteryLife, decimal price)
           : this(model, null, null, null, null, null, screen, battery, batteryLife, price)
    {
    }

    public Laptop(string model, decimal price)
        : this(model, null, null, 0, price)
    {
    }

    public Laptop()
    {
    }


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
            this.processor = value;
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
    public string Hdd
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
        string separator = "+" + new string('-', 20) + "+" + new string('-', 50) + "+";
        StringBuilder output = new StringBuilder();
        output.AppendLine(separator);

        if (this.Manufacturer != null)
        {
            output.AppendLine($"|{"Manufacturer",-20}|{this.manufacturer,-50}|");
            output.AppendLine(separator);
        }
        if (this.processor != null)
        {
            output.AppendLine($"|{"Processor",-20}|{this.processor,-50}|");
            output.AppendLine(separator);
        }
        if (this.Ram != null)
        {
            output.AppendLine($"|{"RAM",-20}|{this.ram,-50}|");
            output.AppendLine(separator);
        }
        if (this.GraphicsCard != null)
        {
            output.AppendLine($"|{"GPU",-20}|{this.graphicsCard,-50}|");
            output.AppendLine(separator);
        }
        if (this.Hdd != null)
        {
            output.AppendLine($"|{"HDD",-20}|{this.hdd,-50}|");
            output.AppendLine(separator);
        }
        if (this.Screen != null)
        {
            output.AppendLine($"|{"Screen",-20}|{this.screen,-50}|");
            output.AppendLine(separator);
        }
        if (this.BatteryType != null)
        {
            output.AppendLine($"|{"Battery Type",-20}|{this.batteryType,-50}|");
            output.AppendLine(separator);
        }
        output.AppendLine($"|{"Price",-20}|{this.price,-50}|");
        output.AppendLine(separator);

        return output.ToString();
    }
}

