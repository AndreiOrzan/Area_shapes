using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5)};

            foreach (var s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This is not a circle");

                }

            }
        }
    }
}
