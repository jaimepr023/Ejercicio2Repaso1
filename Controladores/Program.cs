using Ejercicio2Repaso1.Servicios;

namespace Ejercicio1Repaso1
{
    class program
    {
        public static void Main(String[] args)
        {
            OperacionesInterfaz op = new OperacionesImplementacion();

            int numero = op.pedirNum();
            op.operacionEntero(numero);
        }
    }
}