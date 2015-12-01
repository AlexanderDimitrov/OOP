using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Shapes.Prop
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth)
            : base(width, heigth)
        {
        }

        public override double CalculateArea() => this.Width * this.Heigth;

        public override double CalculatePerimeter() => (this.Width + this.Heigth) * 2;
    }
}