using System;

namespace Ejercicio36LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Conversion de cantidad expresada en quetzales a dolares");

			Console.WriteLine("Ingrese una cantidad");
			int cantidad = Convert.ToInt16(Console.ReadLine());

			Console.WriteLine("El total en dolares es: {0}",conversion(cantidad));

		}
		public static double conversion(int valor){
			double dolar = 7.6;
			double total;

			total = valor / dolar;
			return total;
		}
	}
}
