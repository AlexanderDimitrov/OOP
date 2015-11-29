using System;
namespace Problem_1.Point_3D
{
    class Point3D
    {
        public static readonly Point3D StartingPointC;
        static Point3D()
        {
            StartingPointC = new Point3D(0, 0, 0);
        }
        public Point3D(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D()
        {

        }
        public static Point3D StartingPoint { get { return Point3D.StartingPointC; } }

        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public override string ToString()
        {
            return $"Point:{{x={this.x},y={this.y},z={this.z}}}";
        }
    }

    
}
