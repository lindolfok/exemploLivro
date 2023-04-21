/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 16/11/2022
 * Time: 15:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf04
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
			
			Console.Write("Escreva seu nome: ");
			nome = Console.ReadLine();
			
			Console.Write("Ola " + nome + " Tudo bem?");
			
			Console.ReadKey(true);
			              
		}
	}
}