using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class ArrayOculto
    {
        public static char[] oculto;

        public static void RellenarOculto(string c)
        {
            oculto = new char[c.Length];
            
            for (int i = 0; i < oculto.Length; i++)
            {
                oculto[i] = '_';
            } 
                
        }

        public static void MostrarOculto()
        {

            foreach (char x in oculto)
            {
                Console.Write(x+" ");
            }

        }

        public static int Comprobar(char x)
        {
            int opcion = 0;
            bool repetida = false;
            bool acertada = false;
            bool error = false;

            for (int i = 0; i < Palabra.visible.Length; i++)
            {
                if (x != Palabra.visible[i])
                {
                    error = true;
                }
                else if(x == oculto[i])
                {
                    repetida = true;    
                }
                else if (x == Palabra.visible[i])
                {
                    oculto[i] = x;
                    acertada = true;
                }
            }

            if (repetida)
            {
                opcion = 1;
            }
            else if (acertada)
            {
                opcion = 2;
            }
            else if ((error)&&(!acertada))
            {
                opcion = 0;
            }

            return opcion;
        }

        public static bool Finalizado()
        {
            bool acertado = true;

            for (int i = 0; (i < Palabra.visible.Length)&&(acertado); i++)
            {
                if (Palabra.visible[i] == oculto[i])
                {
                    acertado = true;
                }
                else
                {
                    acertado = false;
                }
            }
            
            return acertado;
        }
    }
}
