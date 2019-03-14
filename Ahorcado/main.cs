using System;

namespace Ahorcado
{
    class main
    {
        public static char letra;
        public static int intentos = 6;
        public static string palabra = Palabra.AsignarPalabra();
        static void Main(string[] args)
        {

            Tablero.Bienvenida();

            do
            {

                Tablero.Principal();

                Tablero.Comprobacion();

                Console.ReadLine();

            } while ((intentos > 0)&&(!ArrayOculto.Finalizado()));

            Tablero.Finalizado();
        }

        
    }
}
