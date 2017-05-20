using System;

namespace Ejercicio35LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Menu");

			bool salir = false;
			int total;

			while (!salir) {
				Console.WriteLine("Escoja la operació que desea realizar");
				Console.WriteLine("1. Suma");
				Console.WriteLine("2. Resta");
				Console.WriteLine("3. Multiplicación");
				Console.WriteLine("4. División");
				int numero = Convert.ToInt16(Console.ReadLine());

				if (numero == 1)
				{
					Console.WriteLine("Ingrese el primer valor");
					int valor1 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Ingrese el segundo valor");
					int valor2 = Convert.ToInt16(Console.ReadLine());

					total = valor1 + valor2;

					Console.WriteLine("La suma total es: {0}", total);
				}
				else if (numero == 2)
				{
					Console.WriteLine("Ingrese el primer valor");
					int valor1 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Ingrese el segundo valor");
					int valor2 = Convert.ToInt16(Console.ReadLine());

					total = valor1 * valor2;

					Console.WriteLine("La multiplicacion total es: {0}", total);
				}
				else if (numero == 3) {

					salir = true;
				}
			}

		}
	}
}
