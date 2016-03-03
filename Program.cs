using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
	class Program
	{
		static void Main(string[] args)
		{
			double A = 20, B = 15, C = 10;
			Console.WriteLine("A = {0}, B = {1} C = {2}", A, B, C);

			Console.WriteLine(Triangle.Area(A, B, C));

			Console.ReadLine();			
		}
	}


	static class Triangle
	{
		public static double Area(double A, double B, double C)
		{
			if (A > B) Swap(ref A, ref B);
			if (B > C) Swap(ref B, ref C);			

			return A*B/2;						
		}
		
		static void Swap(ref double A, ref double B)
		{
			double T = A;
			A = B; B = T;
		}
	}
}
