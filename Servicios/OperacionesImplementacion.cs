using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Repaso1.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        private bool condicionAPedir(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("Error en el sistema, el numero es menor de 2 cifras");
                return true;
            }else
            {
                return false;
            }

        }
        public int pedirNum()
        {
            int numeroEntero;
            do
            {
                Console.WriteLine("Dame un numero que se de 2 cifras al menos.");
                 numeroEntero = Int32.Parse(Console.ReadLine());
                

            } while (condicionAPedir(numeroEntero));
            return numeroEntero;
        }

        public void operacionEntero(int numeroEntero)
        {
            decimal j = 0;
            decimal p = 0;
            for(int i = 401; i < 700; i++)
            {
                j=numeroEntero * i;
                Console.WriteLine("Multiplo " + i + "=" +j);
                p += j;
            }
            
            Console.WriteLine("La suma es: " + p);
            decimal mediaAritmetica = p / (699 - 401);
            Console.WriteLine("La media aritmetica es: " + mediaAritmetica);

        }
    }
}
