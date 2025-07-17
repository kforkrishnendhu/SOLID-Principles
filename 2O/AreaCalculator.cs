using System;

namespace SOLID.O
{
	public class AreaCalculator
	{
		public double TotalArea(IArea[] arrObjects)
		{
			double area = 0;
			foreach(var obj in arrObjects)
			{
				//if(obj is Rectangle)
				//{
				//	var objRectangle = (Rectangle)obj;
				//	area += objRectangle.Height * objRectangle.Width;
				//}
				//else
				//{
				//               var objCircle = (Circle)obj;
				//	area += objCircle.radius * objCircle.radius * Math.PI;
				//}


				area += obj.Area();
			}
			return area;
		}
	}
}

