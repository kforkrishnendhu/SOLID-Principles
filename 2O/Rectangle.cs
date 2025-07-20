using System;
namespace SOLID.O
{
	public class Rectangle :IArea
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double h,double w)
        {
            Height = h;
            Width = w;
        }

        public double Area() => Height * Width;
    }
}

