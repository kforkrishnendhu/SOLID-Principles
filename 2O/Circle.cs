using System;
namespace SOLID.O
{
	public class Circle:IArea
	{
		public double radius { get; set; }

		public double Area() => Math.PI * radius * radius;
    }
}

