using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfShapes;

namespace AreaOfShapesTests
{
	[TestClass]
	public class AreaTests
	{
		/// <summary>
		/// Тест пройден если сгенерированно ArgumentOutOfRangeException
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Area_WhenSideIsLessThanOrEqualToZero()
		{
			RightTriangle.Area(10, -5, 15);
		}


		/// <summary>
		/// Тест пройден если "Пифагор" рассчитывается верно
		/// </summary>
		[TestMethod]		
		public void Area_WhenTriangleIsNotRightTriangle()
		{
			try { RightTriangle.Area(3, 4, 5); }
			catch (ArgumentException)
			{
				Assert.Fail("Пифагор рассчитан неверно.");
			}
		}

				

		/// <summary>
		/// Тест пройден если рассчитанная площадь треугольника со сторонами 5, 4, 3 равна 6.
		/// </summary>
		[TestMethod]
		public void Area_IsCalculatedCorrectly()
		{
			Assert.AreEqual(6, RightTriangle.Area(5, 4, 3), 0, "Площадь треугольника рассчитана не верно.");
		}
	}
}
