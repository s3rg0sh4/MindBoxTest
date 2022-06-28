using System;

namespace MindBoxTest
{
	public class Circle : Figure
	{
		public double Radius { get; set; }
		public Circle(double radius)
		{
			if (radius < 0)
				throw new Exception("Круг не существует, радиус меньше нуля");
			else
				Radius = radius;
		}

		public override double Area() => Math.PI * Radius * Radius;
		
	}
}
