using System;

namespace MindBoxTest
{
	public class Triangle : Figure
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public Triangle(double a, double b, double c)
		{
			if ((a + b <= c) || (a + c <= b) || (b + c <= a) || a <= 0 || b <= 0 || c <= 0)
				throw new Exception("Треугольник не существует");
			else
			{
				A = a;
				B = b;
				C = c;
			}
		}

		public override double Area() => Math.Sqrt((A + B + C) * (A + B - C) * (A + C - B) * (B + C - A) / 16);
		public bool IsRight() => (A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == B * B + A * A); //Проверка на прямогольность
		
	}
}
