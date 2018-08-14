using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia1, mes1, anio1, dia, mes, anio, dias, meses, anios;
            String line;
            Console.WriteLine("Ricardo Diaz");
            Console.WriteLine("17-MIIN-1-090");
            Console.WriteLine("Seccion: 0463");
            Console.WriteLine("Ingrese la Fecha de Nacimiento (dd/mm/aaaa)\nFecha de Nacimiento:");

            Console.WriteLine("Dia Nacimiento:");
            line = Console.ReadLine();
            dia1 = int.Parse(line);

            Console.WriteLine("Mes Nacimiento:");
            line = Console.ReadLine();
            mes1 = int.Parse(line);

            Console.WriteLine("Año Nacimiento:");
            line = Console.ReadLine();
            anio1 = int.Parse(line);

            Console.WriteLine("Ingrese la Fecha Actual (dd/mm/aaaa)\nFecha Actual:");

            Console.WriteLine("Dia Actual:");
            line = Console.ReadLine();
            dia = int.Parse(line);

            Console.WriteLine("Mes Actual:");
            line = Console.ReadLine();
            mes = int.Parse(line);

            Console.WriteLine("Año Actual:");
            line = Console.ReadLine();
            anio = int.Parse(line);

            
            anios = anio - anio1;
            double aniosr = (double)(anios) * 365.242189;
            dias = dia - dia1;
            meses = mes - mes1;

            double r = (aniosr + dias + (meses) * (365.242189 / 12));


            Console.WriteLine("\nLos dias que usted ha vivido son:\n" + (int)r);

        }
    }
}
