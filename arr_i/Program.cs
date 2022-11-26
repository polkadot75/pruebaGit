using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace arr_i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            double import;



            Console.WriteLine("Import: ");
            import = double.Parse(Console.ReadLine());

            double[] descompte = new double[2] { 30, 13};



            double totalar=1;

            for (int i = 0; i < descompte.Length; i++)
            {
                totalar = (descompte[i] * totalar);  //multiplicación de los elementos del array
            }

            double desce=0;

            for (int i = 0;i< descompte.Length; i++)
            {
                desce += descompte[i]; //suma de los elementos del array
            }

            double total;

            total = (desce - (totalar / 100)); //formula para encontrar el porcentaje de los decuentos succesivos

            Console.WriteLine("tq " + totalar);
            Console.WriteLine("desce "+ desce);
            Console.WriteLine("totally "+total); //total del descuento succesivo

        }
    }
}
