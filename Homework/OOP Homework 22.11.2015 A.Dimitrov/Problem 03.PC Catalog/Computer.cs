using System;
using System.Collections.Generic;
using System.Text;
class Computer
{
    private string name;
    private List<Components> components = new List<Components>();
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

    public decimal Price
    {
        get { return this.price; }
        private set
        {
            this.price = value;
        }
    }

    public Components[] Components { get; set; }

    public Computer(string name) : this(name, null) { }
    public Computer(string name, List<Components> components)
    {
        this.Name = name;
        if (components != null)
        {
            for (int i = 0; i < components.Count; i++)
            {
                this.components.Add(components[i]);
            }
            this.Price = CalcPrice(components);
        }
    }

    private decimal CalcPrice(List<Components> components)
    {
        decimal total = 0.0m;
        foreach (var comp in components)
        {
            total += comp.Price;
        }
        return total;
    }

    override public string ToString()
    {

        string separator = "+" + new string('-', 25) + "+" + new string('-', 50) + "+";
        StringBuilder output = new StringBuilder();
        output.Append("Computer Name: ");
        output.AppendLine(this.Name);
        output.AppendLine(separator);
        foreach (var component in this.components)
        {
            output.AppendLine(component.ToString());
            output.AppendLine(separator);
        }
        output.AppendLine($"|{"Total Computer Price",-25}:{this.price.ToString(),-50}");
        output.AppendLine(separator);
        return output.ToString();
    }

}

