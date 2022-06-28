using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using MindBoxTest;

namespace MindBoxTestTests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void Circle_WithValidRadius()
		{
			var circle = new Circle(3);
			Assert.AreEqual(3, circle.Radius);
		}
		[TestMethod]
		[ExpectedException(typeof(Exception), "Круг не существует, радиус меньше нуля")]
		public void Circle_WithInvalidRadius()
		{
			new Circle(-3);
		}

		[TestMethod]
		public void Area_WithAnyInt()
		{
			var circle = new Circle(3);
			Assert.AreEqual(Math.PI * 9, circle.Area());
		}
		[TestMethod]
		public void Area_WithAnyDouble()
		{
			var circle = new Circle(3.5);
			Assert.AreEqual(Math.PI * 3.5 * 3.5, circle.Area());
		}
	}
}
