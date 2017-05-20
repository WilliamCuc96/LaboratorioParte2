using System;

namespace Ejercicio33LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int n1;
			int resta;
			int permutacionResta;
			int division;

			Console.WriteLine("Calculo de Permutacion");

			Console.WriteLine("Ingrese un valor");
			int n = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese un segundo valor");
			int r = Convert.ToInt16(Console.ReadLine());
			n1 = n;
			for (int i = n-1; i > 0 ; i--) {
				n1 = n1 * i;
			}
			resta = n - r;

			permutacionResta = resta;
			for (int e = resta - 1; e > 0; e--) {
				permutacionResta = permutacionResta * e;
			}

			division = n1 / permutacionResta;

			Console.WriteLine("{0}",n1);
			Console.WriteLine("{0}",permutacionResta);

			Console.WriteLine("El resultado es: {0}",division);
		}
	}
}
