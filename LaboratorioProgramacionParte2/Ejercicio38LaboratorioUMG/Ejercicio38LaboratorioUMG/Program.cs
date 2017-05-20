using System;

namespace Ejercicio38LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculo de factorial por medio de funciones");

			Console.WriteLine("Ingrese un numero");
			int num = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("{0}! es igual a {1}",num,factorial(num));

		}

		public static int factorial(int valor) {
			if (valor >= 1) return valor* factorial(valor - 1);
			return 1;
		}
	}
}
