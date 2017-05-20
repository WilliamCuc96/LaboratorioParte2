using System;

namespace Ejercicio32LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que muestra la tabla de multiplicar del 1 al 10");
			for (int i = 1; i <= 10; i++) {
				for (int j = 1; j <= 10; j++) {
					Console.WriteLine("{0} * {1} = {2}", i, j,i*j);
				}
				Console.WriteLine("--------------------");
			}

		}
	}
}
