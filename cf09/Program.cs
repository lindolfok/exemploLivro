/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 17/11/2022
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf09
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = 0;
			bool convertido;
			
			Console.Write("Digite um numero: ");
			
			convertido = int.TryParse(Console.ReadLine(), out x);
			
			if(convertido){
				
				Console.WriteLine("Convertido com sucesso!");
				
				} else{
				
				Console.WriteLine("Erro na conversao");
				
			}
			Console.WriteLine("Valor de x: {0}", x);
			Console.ReadKey(true);
		}
	}
}