using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest;

namespace MindBoxTestTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void Triangle_WithValidSides()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.AreEqual(3, triangle.A);
			Assert.AreEqual(4, triangle.B);
			Assert.AreEqual(5, triangle.C);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception), "Треугольник не существует")]
		public void Triangle_WithInvalidSides1()
		{
			new Triangle(-4, 4, 5);
		}

		[TestMethod]
		[ExpectedException(typeof(Exception), "Треугольник не существует")]
		public void Triangle_WithInvalidSides2()
		{
			new Triangle(4, 4, 10);
		}

		[TestMethod]
		public void Area_WithAnyValues()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.AreEqual(6, triangle.Area());
		}

	}
}
