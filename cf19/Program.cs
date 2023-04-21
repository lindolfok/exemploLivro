/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf19
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numero;
			Console.WriteLine("Digite um numero");
			numero = Int32.Parse(Console.ReadLine());
			
			if(numero == 1)
			{
				Console.WriteLine("O numero digitado foi o numero 1");
				
			}
			else
			{
				Console.WriteLine("O numero digitado nao foi o numero 1");
			}
			Console.ReadKey(true);
		}
	}
}