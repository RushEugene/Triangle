using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes
{
    public class RightTriangle
    {
		//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
		// METHODS
		//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
		public static double Area(double A, double B, double C)
		{
			// Стороны треугольника не могут быть меньше или равны нулю
			if (A <= 0 || B <= 0 || C <= 0)
				throw new ArgumentOutOfRangeException();

			// Гипотенузу вправо
			if (A > B) Helper.Swap(ref A, ref B);
			if (B > C) Helper.Swap(ref B, ref C);

			// Теорема Пифагора
			if ((A * A + B * B) != C * C)
				throw new ArgumentException();

			return A * B / 2;
		}

	}

	
	static class Helper
	{
		//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
		// METHODS
		//||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
		public static void Swap(ref double A, ref double B)
		{
			double T = A;
			A = B; B = T;
		}

	}

}
