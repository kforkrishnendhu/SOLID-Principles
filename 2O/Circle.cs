using System;
namespace SOLID.O
{
	public class Circle:IArea
	{
		public double radius { get; set; }

		public Circle(double r)
		{
			radius = r;
		}

		public double Area() => Math.PI * radius * radius;
    }
}

