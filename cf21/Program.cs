/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 15:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf21
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n1, n2, m;
			string msg;
			
			Console.Write("Digite a 1 nota: ");
			n1 = Double.Parse(Console.ReadLine());
			
			Console.Write("Digite a 2 nota: ");
			n2 = Double.Parse(Console.ReadLine());
			
			m = (n1 +  n2) / 2;
			
			msg = (m >= 5) ? "Passou" : "Reprovou";
			
			Console.WriteLine("Voce {0}!", msg);
			Console.ReadKey(true);
		}
	}
}