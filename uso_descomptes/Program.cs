using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace uso_descomptes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numdescomptes;
            int x = 1;
            double desc;
            int descar;
            int reduc;
            int import;

            Console.WriteLine("Import: ");
            import = int.Parse(Console.ReadLine());

            Console.WriteLine("introdueix el número de descomptes: ");
            numdescomptes = int.Parse(Console.ReadLine());

            double[] descompte = new double[numdescomptes];

            do
            {

                for (int i = 0; i < descompte.Length; i++)
                {
                    Console.WriteLine("Descompte " + x + " :");
                    desc = double.Parse(Console.ReadLine());
                    desc = desc / 100;
                    x++;
                    descompte[i] = desc; //introducir descuentos en el array
                }

            }
            while (x <= descompte.Length);

            for (int i = 0; i < descompte.Length; i++)
            {
                Console.WriteLine(descompte[i]); //mostrar descomptes
            }

            double resultado;

            do
            {
                for (int i = 0; i < descompte.Length; i++)
                {
                    resultado = import * descompte[i];
                    Console.WriteLine("1. " + import);
                    Console.WriteLine("2. " + resultado);
                    numdescomptes--;
                }
            }
            while (numdescomptes >= 0);
        }
    }
}

