/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf16
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1 = 5, n2 = 8;
			
			bool igual, diferente, maior, menor, maiorigual, menorigual;
			
			igual = (n1 == n2);
			diferente = (n1 != n2);
			maior = (n1 > n2);
			menor = (n1 < n2);
			maiorigual = (n1 >= n2);
			menorigual = (n1 <= n2);
			
			Console.WriteLine("{0} é igual {1} ? {2}", n1, n2, igual.ToString());
			Console.WriteLine("{0} é diferente {1} ? {2}", n1, n2, diferente.ToString());
			Console.WriteLine("{0} é maior que {1} ? {2}", n1, n2, maior.ToString());
			Console.WriteLine("{0} é menor que {1} ? {2}", n1, n2, menor.ToString());
			Console.WriteLine("{0} é maior ou igual a {1} ? {2}", n1, n2, maiorigual.ToString());
			Console.WriteLine("{0} é menor ou igual a {1} ? {2}", n1, n2, menorigual.ToString());
			
			Console.ReadKey(true);
		}
	}
}