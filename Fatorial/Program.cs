using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial Recursivo: " + FatorialRecursivo(10));
            Console.WriteLine("Fatorial Iterativo: " + Fatorial(9));
            
            Console.Read();
        }

        static int Fatorial(int numero)
        {
                        
            int resultado = numero;

            while (numero > 1)
            {
                //Console.WriteLine(resultado + " x " + (numero - 1));

                resultado *= numero - 1;

                numero--;
            }

            return resultado;
            
        }

        static int FatorialRecursivo(int numero)
        {
            return numero == 0 ? 1 : numero * FatorialRecursivo(numero - 1);
        }
    }
}
