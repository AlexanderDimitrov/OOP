using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.Shapes;


namespace Problem1.Shapes.Prop
{
    public abstract class BasicShape : IShape
    {
        protected BasicShape(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        protected double Width { get; }

        protected double Heigth { get; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}


    

