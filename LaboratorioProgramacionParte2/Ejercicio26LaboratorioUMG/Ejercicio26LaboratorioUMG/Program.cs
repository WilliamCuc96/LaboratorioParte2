using System;

namespace Ejercicio26LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que muestra el abecedario con ascii");

			int inicio = 65;
			while (inicio <= 90) {
				Console.WriteLine("{0}",(char)inicio);
				inicio++;
			}

		}
	}
}
