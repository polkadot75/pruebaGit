using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndescomptes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numdescomptes;
            int x = 1;
            double desc;
            double import;

            Console.WriteLine("Introdueix el número de descomptes: ");
            numdescomptes = int.Parse(Console.ReadLine());

            if (numdescomptes >1 ) 
            { 

            double[] descompte = new double[numdescomptes];

            do
            {
                for (int i = 0; i < descompte.Length; i++)
                {
                    Console.WriteLine("Descompte " + (i+1) + " :");
                    desc = double.Parse(Console.ReadLine());
                    x++;
                    descompte[i]=desc; //introducir descuentos en el array
                }
            }
            while (x <= descompte.Length);

            Console.WriteLine();
            Console.WriteLine("Los descuentos introducidos son: ");

            for (int i = 0; i < descompte.Length; i++)
            {
                Console.WriteLine(descompte[i]); //mostrar descomptes
            }

            Console.WriteLine();

            double totalar = 1;

            for (int i = 0; i < descompte.Length; i++)
            {
                totalar = (descompte[i] * totalar);  //multiplicación de los elementos del array
            }

            double suma = 0;

            for (int i = 0; i < descompte.Length; i++)
            {
                suma += descompte[i]; //suma de los elementos del array
            }

            double total;

            total = (suma - (totalar / 100)); //formula para encontrar el porcentaje de los descuentos succesivos

            Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("multiplicacion elementos del Array " + totalar);
            //Console.WriteLine("suma de los elementos del Array " + desce);

            Console.Write("Total descuentos succesivos es: " + total + " % "); //total del descuento succesivo
            }

            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("No hay descuentos");
            }

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
