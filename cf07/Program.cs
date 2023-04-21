/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 17/11/2022
 * Time: 08:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf07
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x = 10.5;
			int y;
			y =  (int) x;
			
			Console.WriteLine("Valor de x: {0}", x);
			Console.WriteLine("Valor de y: {0}", y);
			Console.ReadKey(true);
		}
	}
}