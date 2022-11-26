using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace arr_1
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

        }
    }
}

