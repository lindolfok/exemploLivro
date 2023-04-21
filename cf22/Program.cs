/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 16:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf22
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int mes = DateTime.Today.Month;
			
			switch(mes)
			{
				case 1:
					Console.WriteLine("Janeiro");
					break;
				case 2:
					Console.WriteLine("Fevereiro");
					break;
				case 3:
					Console.WriteLine("Março");
					break;
				case 4:
					Console.WriteLine("Abril");
					break;
				case 5:
					Console.WriteLine("Maio");
					break;
				case 6:
					Console.WriteLine("Junho");
					break;
				case 7:
					Console.WriteLine("Julho");
					break;
				case 8:
					Console.WriteLine("Agosto");
					break;
				case 9:
					Console.WriteLine("Setembro");
					break;
				case 10:
					Console.WriteLine("Outubro");
					break;
				case 11:
					Console.WriteLine("Novembro");
					break;
				case 12:
					Console.WriteLine("Dezembro");
					break;
				default:
					Console.WriteLine("Outro mes");
					break;
			}
			Console.ReadKey(true);

		}
	}
}