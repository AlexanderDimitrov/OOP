using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem1.Shapes.Prop
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius { get; }

        public double CalculateArea() => Math.Pow(Math.PI * this.Radius, 2);

        public double CalculatePerimeter() => 2 * Math.PI * this.Radius;
    }
}
