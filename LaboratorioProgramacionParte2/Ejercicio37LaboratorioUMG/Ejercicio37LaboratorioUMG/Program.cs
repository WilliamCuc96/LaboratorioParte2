using System;

namespace Ejercicio37LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculo de la hipotenusa de un triangulo atraves de funciones");

			Console.WriteLine("Ingrese la base");
			int numBase = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese el exponente");
			int numExponente = Convert.ToInt16(Console.ReadLine());


			Console.WriteLine("El total es: {0}",calculo(numBase, numExponente));
		}

		public static double calculo(int bas, int expo) {

			double potencia1;
			double potencia2;
			double suma;
			double total;

			potencia1 = Math.Pow(bas, 2);
			potencia2 = Math.Pow(expo,2);
			suma = potencia1 + potencia2;

			total = Math.Sqrt(suma);

			return total;
		}
	}
}
