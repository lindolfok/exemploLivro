/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf23
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n,r;
			Console.WriteLine("Digite um numero: ");
			n = Int32.Parse(Console.ReadLine());
			
			for(int i = 0; i <= 10; i++)
			{
				r = n * i;
				Console.WriteLine("{0} x {1} = {2}", n, i, r);
			}
			Console.ReadKey(true);
		}
	}
}