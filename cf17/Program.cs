/*
 * Created by SharpDevelop.
 * User: lindolfo.silveira
 * Date: 29/11/2022
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cf17
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n1 = 5, n2 = 10;
			bool varE, varOu, varInv;
			
			varE = ((n1 < 5) && (n2 == 10));
			varOu = ((n1 < 5) || (n2 == 10));
			varInv = !(n1 == 5);
			
			Console.WriteLine("Expressao E (({0} < 5) && ({1} == 10)): {2}", n1, n2, varE.ToString());
			Console.WriteLine("Expressao Ou (({0} < 5) || ({1} == 10)): {2}", n1, n2, varOu.ToString());
			Console.WriteLine("Expressao Invertida !({0} < 5) && ({1} == 10)): {2}", n1, n2, varE.ToString());
			
			Console.ReadKey(true);
		}
	}
}