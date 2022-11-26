using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pruebaGit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] familia =
          { {"1 Miembro", "Rosalia", "Madre", "1965"},
            {"2 Miembro", "Xavier", "Padre", "1968" },
            {"3 Miembro" , "David", "Primer hijo", "1996"},
            {"4 Miembro", "Francesc", "Segundo hijo", "1999" } };

            string nombre;

            string opcion;


            do
            {
                Console.WriteLine("Opción 1: Con el nombre del miembro obtendrás información de el: ");

                Console.WriteLine("Opción 2: Calcular porcentajes relativos");

                Console.Write("Escribe la opción deseada en el teclado, para finalizar escribir ( n ) : ");

                opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":
                        {
                            Console.WriteLine("Hola, ¿Como te llamas?");
                            nombre= Console.ReadLine();
                            int veces = 0;

                            for (int i = 0; i < familia.GetLength(0); i++)
                            {
                                for (int j = 0; j < familia.GetLength(1); j++)
                                {
                                    if (nombre == familia[i, 1])
                                    {
                                        Console.Write(familia[i, j] + "\t");
                                    }
                                }
                            }
                            Console.WriteLine();
                        }
                        break;


                    case "2":
                        {
                            int numdescomptes;
                            int x = 1;
                            double desc;

                            Console.WriteLine("Introdueix el número de descomptes: ");
                            numdescomptes = int.Parse(Console.ReadLine());

                            if (numdescomptes > 1)
                            {
                                double[] descompte = new double[numdescomptes];

                                do
                                {
                                    for (int i = 0; i < descompte.Length; i++)
                                    {
                                        Console.WriteLine("Descompte " + (i + 1) + " :");
                                        desc = double.Parse(Console.ReadLine());
                                        x++;
                                        descompte[i] = desc; //introducir descuentos en el array
                                    }
                                }
                                while (x <= descompte.Length);

                                Console.WriteLine();
                                Console.WriteLine("Els descomptes introduïts son: ");

                                for (int i = 0; i < descompte.Length; i++)
                                {
                                    Console.WriteLine(descompte[i] + " %"); //mostrar descomptes
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

                                Console.Write("Total descomptes succesius es: " + total + " % "); //total del descuento succesivo
                                Console.WriteLine();
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No hay descuentos");
                            }

                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    default:
                        break;
                }
            }
            while (opcion != "n");

        }
    }
}
