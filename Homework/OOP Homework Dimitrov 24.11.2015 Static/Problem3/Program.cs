using System;
using Problem3.Prop;

namespace Problem3
{
    using System;
    

    public class MainProgram
    {
        private const string File = @"../../path.xml";

        public static void Main(string[] args)
        {
            var path = new Path3D(
                new Point3D(5, 9, 4),
                new Point3D(15, 16, 8.2),
                new Point3D(0, 0, 0),
                new Point3D(51, 122, 133));

            
            Storage.SavePath(File, path);

           
            Path3D path2 = Storage.LoadPath(File);

            Console.WriteLine(string.Join(Environment.NewLine, path2.Path));
        }
    }
}
