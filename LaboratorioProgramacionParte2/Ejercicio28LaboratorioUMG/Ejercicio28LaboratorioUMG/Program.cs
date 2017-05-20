using System;

namespace Ejercicio28LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que suma numeros impares y visualisa cuales son");

			Console.WriteLine("Ingrese un numero");
			int numero = Convert.ToInt16(Console.ReadLine());
			int total = 0;

			for (int i = 1; i <= numero; i++) {
				if (i % 2 != 0) {

					Console.WriteLine(i);
					i++;
					total +=i ;
				}
			}
			Console.WriteLine("La suma de los numeros impares es: {0}",total);

		}
	}
}
