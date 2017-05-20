using System;

namespace Ejercicio40LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculo del sueldo de un trabajador mediante funciones");

			Console.WriteLine("Ingrese su sueldo base");
			double sueldoBase = Convert.ToDouble(Console.ReadLine());
			double cuotaPatronal_val = cuotaPatronal(sueldoBase);
			double cuotaLaboral_val = cuotaLaboral(sueldoBase);
			double sueldoLiquido_val = sueldoLiquido(cuotaPatronal_val, cuotaLaboral_val, sueldoBase);
			Console.WriteLine("El sueldo liquido es: {0}",sueldoLiquido_val);
		}
		public static double cuotaLaboral(double sueldo) {
			double total;
			total = sueldo * 0.0483;
			return total;
		}
		public static double cuotaPatronal(double sueldo) {
			double total;
			total = sueldo * 0.01;
			return total;
		}
		public static double sueldoLiquido(double cuotaPatronal, double cuotaLaboral, double sueldoBase) {
			double total;
			total = (sueldoBase-(cuotaLaboral+cuotaPatronal));
			return total;
		}
	}
}
