using System;

namespace Ejercicio29LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el factorial de un numero");

			Console.WriteLine("Ingrese un numero");
			int num = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("{0}! es igual a {1}",num,factorial(num));


		}

		public static int factorial(int num) {
			if (num >= 1) return num * factorial(num - 1);
			return 1;
		}
	}
}
