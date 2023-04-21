/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 17/11/2022
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf08
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x;
			
			Console.Write("Digite um numero: ");
			x = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Valor de x: {0}", x);
			Console.ReadKey();
		}
	}
}