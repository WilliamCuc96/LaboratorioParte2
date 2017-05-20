using System;

namespace Ejercicio31LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el promedio de 10 estudiantes");

			double promedio;
			double total = 0;
			double estudiantes = 10;
			string[] nombre = new string[10];
			string[] nombreCurso = new string[10];
			double[] nota = new double[10];
			for (int i = 0; i< 10; i++) {
				
				Console.WriteLine("Ingrese el Nombre del Estudiante");
				nombre[i] = Console.ReadLine();
				Console.WriteLine("Ingrese el Nombre del Curso");
				nombreCurso[i] = Console.ReadLine();
				Console.WriteLine("Ingrese la Nota del Estudiante");
				nota[i] = Convert.ToDouble(Console.ReadLine());
			}

			for (int i = 0; i< 10; i++) {
				Console.WriteLine("{0} {1} {2}",nombre[i],nombreCurso[i],nota[i]);
				total += nota[i];
			}

			promedio = total / estudiantes;

			Console.WriteLine("Promedio =   {0}",promedio);
		}
	}
}
