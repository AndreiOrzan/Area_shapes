using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_shapes
{
    class Rectangle:Shape
    {
        public double Lenght { set; get; }
        public double Width { set; get; }

        public Rectangle(double lenght, double width)
        {
            Name = "Rectangle";
            Lenght = lenght;
            Width = width;
        }

        public override double Area()
        {
            return Lenght * Width; 
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a lenght of {Lenght} and has a width of {Width} ");
        }
    }
}
