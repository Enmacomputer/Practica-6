using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero1, numero2;
			Console.WriteLine("Ingrese primer valor de tipo entero:");
			numero1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ingrese segundo valor entero:");
			numero2 = Convert.ToInt32(Console.ReadLine());

			if (numero2 <= 0)
			{
				Console.WriteLine("ERROR");

			}

			else
			{
				Console.WriteLine("Resultado de la division:" + numero1 / numero2);

			}

			Console.ReadKey();

























		}
	}
}
