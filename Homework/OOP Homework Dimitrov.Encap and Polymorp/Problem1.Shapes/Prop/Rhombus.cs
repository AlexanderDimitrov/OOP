using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.Shapes.Prop
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double heigth)
            : base(width, heigth)
        {
        }

        public override double CalculateArea() => this.Width * this.Heigth / 2;

        public override double CalculatePerimeter() => this.CalculateRhombusSide() * 4;

        private double CalculateRhombusSide() =>
            Math.Sqrt((this.Width * this.Width) + (this.Heigth * this.Heigth)) / 2;
    }
}
