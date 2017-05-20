using System;

namespace Ejercicio27LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula numeros pares");

			for (int i = 1; i <= 100; i++) {

				if (i % 2 == 0) {
					Console.WriteLine(i);
				}
			
			}
		}
	}
}
