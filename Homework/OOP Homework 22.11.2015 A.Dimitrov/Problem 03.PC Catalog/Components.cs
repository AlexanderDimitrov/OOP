using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Components
{
    private string name;
    private string details;
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty!");
            }
            this.name = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set { this.details = value; }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0.0m)
            {
                throw new ArgumentException("Price must be positive!");
            }
            this.price = value;
        }
    }

    public Components(string name, decimal price, string details)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public Components(string name, decimal price) : this(name, price, null) { }

    public override string ToString()
    {
        return String.Format("|{0,-25}|Component Price: {1}", this.Name, this.Price);
        //output.AppendLine($"|{"Price",-20}|{this.price.ToString(),-50}|");
    }

}

