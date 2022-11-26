using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numdescomptes = 3;
            int x = 1;
            double desc;
            int descar;
            int reduc;
            double import;
            double import1;

            

            Console.WriteLine("Import: ");
            import = double.Parse(Console.ReadLine());

            double[] descompte = new double[2] { 0.3, 0.10 };
            int i = 0;
            double resultado;
            double pago1;

            double totaldesc, totaldesc1, total, pago;


            totaldesc = import * descompte[i]; //30=100*0.3
            pago = import - totaldesc; //70=100-30
            totaldesc1 = pago * descompte[i]; //9,10=70*0,13

            //pago1 = pago - totaldesc1; // 60,9 = 70-9,1

            total = totaldesc + totaldesc1; //39,10=30+9,10

            


            Console.WriteLine(totaldesc);
            Console.WriteLine(totaldesc1);
            Console.WriteLine(total);
            Console.WriteLine(pago);


            if (descompte.Length==5)
            {

            }
            if (descompte.Length == 4)
            {

            }
            if (descompte.Length == 3)
            {
                totaldesc = import * descompte[0]; //30=100*0.3
                pago = import - totaldesc; //70=100-30

                totaldesc1 = pago * descompte[1]; //9,10=70*0,13

                total = totaldesc + totaldesc1; //39,10=30+9,10

            }
            if (descompte.Length == 2)
            {
                totaldesc = import * descompte[0]; //30=100*0.3
                pago = import - totaldesc; //70=100-30

                totaldesc1 = pago * descompte[1]; //9,10=70*0,13

                total = totaldesc + totaldesc1; //39,10=30+9,10

            }
            if (descompte.Length == 1)
            {
                totaldesc = import * descompte[0]; //30=100*0.3
                pago = import - totaldesc; //70=100-30

            }
















            /*
            do
            {

                total = import * descompte[i]; //equivalencia descompte
                Console.WriteLine(i + " " + total);
                import1 = import - descompte[i];
                //import1 = import1 * descompte[i];
                i++;
                Console.WriteLine("1. " + import1);
                Console.WriteLine("2. " + import);
            }
            while (i != descompte.Length);

            Console.WriteLine(import);*/
        }
    }
}
