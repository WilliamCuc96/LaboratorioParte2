using System;

namespace Ejercicio39LaboratorioUMG
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Calculo del promedio de un estudiante mediante funciones de parametro");

			string nombre;
			string nombreCurso;

			Console.WriteLine("Ingrese el nombre del estudiante");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el nombre del curso");
			nombreCurso = Console.ReadLine();
			Console.WriteLine("Ingrese la nota 1");
			int nota1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la nota 2");
			int nota2 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la nota 3");
			int nota3 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Ingrese la nota 4");
			int nota4 = Convert.ToInt16(Console.ReadLine());

			if (promedio(nota1, nota2, nota3, nota4) >= 61)
			{
				Console.WriteLine("El alumno {0} aprueba el curso de {1} con un promedio de {2}", nombre, nombreCurso, promedio(nota1, nota2, nota3, nota4));
			}
			else { 
				Console.WriteLine("El alumno {0} no aprueba el curso de {1} con un promedio de {2}", nombre, nombreCurso, promedio(nota1, nota2, nota3, nota4));
			}
		}

		public static double promedio(int nota1,int nota2,int nota3,int nota4) {
			int promedioTotal;

			promedioTotal = (nota1 + nota2 + nota3 + nota4) / 4;

			return promedioTotal;

		}
	}
}
