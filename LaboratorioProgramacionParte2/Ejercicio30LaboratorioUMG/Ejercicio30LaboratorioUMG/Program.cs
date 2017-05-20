using System;

namespace Ejercicio30LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int  resultado;

			Console.WriteLine("Programa que muestra una tabla de multiplicar");
			Console.WriteLine("Ingrese un Numero");
			int numero = Convert.ToInt16(Console.ReadLine());

			for (int i = 1; i <= 10; i++) {

				resultado = numero * i;
				Console.WriteLine("{0} * {1} = {2}",numero,i,resultado);
			}
		}
	}
}
