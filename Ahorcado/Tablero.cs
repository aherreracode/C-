using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class Tablero
    {
        public static bool final = true;

        public static void Bienvenida()
        {
            ArrayOculto.RellenarOculto(main.palabra);
            Console.WriteLine("* * * * * * * * * * * * * * < - - V.1 - - > *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*   Bienvenido al juego del ahorcado,       *");
            Console.WriteLine("*   tiene un máximo de 6 intentos para      *");
            Console.WriteLine("*   acertar la palabra, esta basado en      *");
            Console.WriteLine("*   los mejores coches jdm, indicar         *");
            Console.WriteLine("*   el modelo, por ejemplo: impreza         *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("- - - - - PULSE ENTER PARA COMENZAR - - - - -");
            Console.ReadLine();
        }

        public static void Principal()
       {
            Console.Clear();
            try
            {
                
                Console.WriteLine("* * * * * * * * * * * * * * * * * < - - V.1 - - > *");
                Console.WriteLine("*    Palabra a adivinar:                          *");
                Console.Write("                            "); ArrayOculto.MostrarOculto();
                Errores(main.intentos);
                Console.WriteLine("Introduzca una letra:");

                if (char.IsNumber(main.letra))
                {
                    Console.WriteLine("No introduzca numeros, solo una letra.");
                }
                else if (!final)
                {
                    Console.WriteLine("No introduzca espacios, solo una letra.");
                }

                final = true;

                do
                {
                    main.letra = char.Parse(Console.ReadLine());

                } while (char.IsNumber(main.letra));


            }
            catch (Exception)
            {
                
                final = false;
            }
            finally
            {
                if (!final)
                {
                    Principal();
                }
                
            }
            
       }

        public static void Comprobacion()
        {
            switch (ArrayOculto.Comprobar(main.letra))
            {
                case 0:
                    Console.WriteLine("La letra no se encuentra en la palabra, pulse enter para continuar.");
                    main.intentos--;
                    break;
                case 1:
                    Console.WriteLine("La letra ya ha sido introducida, pulse enter para continuar.");
                    break;
                case 2:
                    Console.WriteLine("Letra acertada, pulse enter para continuar.");
                    break;
                default:
                    break;
            }
        }

        public static void Finalizado()
        {

            Console.Clear();
            Console.WriteLine("* * * * * * * * * * * * * * * * * < - - V.1 - - > *");
            Console.WriteLine("*    Palabra a adivinar:                          *");
            Console.Write("                            " + main.palabra);
            Errores(main.intentos);
            Console.WriteLine(" ");
            if (main.intentos > 0)
            {
                Console.WriteLine("¡¡ Has ganado el juego !!");
            }
            else
            {
                Console.WriteLine("¡¡ GAME OVER !!");
            }

            CreatedBy();
            Console.WriteLine(" ");
            Console.WriteLine("< - - - Pulse enter para salir del juego - - - >");
            Console.ReadLine();
        }

        public static void Errores(int x)
        {
            Console.WriteLine();
            Console.WriteLine("*                                                 *");
            Console.WriteLine("* Intentos restantes: " + x + "                  + -----  *");
            switch (x)
            {
                case 6:

                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");

                    break;

                case 5:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");
                    break;

                case 4:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                        O     |  *");
                    Console.WriteLine("*                                              |  *");
                    Console.WriteLine("*                                              |  *");
                    break;

                case 3:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                        O     |  *");
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                              |  *");
                    break;
                case 2:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                        O     |  *");
                    Console.WriteLine("*                                       /|L    |  *");
                    Console.WriteLine("*                                              |  *");
                    break;

                case 1:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                        O     |  *");
                    Console.WriteLine("*                                       /|L    |  *");
                    Console.WriteLine("*                                       /      |  *");
                    break;

                case 0:
                    Console.WriteLine("*                                        |     |  *");
                    Console.WriteLine("*                                        O     |  *");
                    Console.WriteLine("*                                       /|L    |  *");
                    Console.WriteLine("*                                       / L    |  *");
                    break;

                default:
                    break;
            }
            Console.WriteLine("*                                        =======  *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("");

        }

        public static void CreatedBy()
        {
            Console.WriteLine("< - - - - - - - - - Created by: - - - - - - - - - >");
            Console.WriteLine("***************************************************");
            Console.WriteLine("**    *****    **    **     **                  **");
            Console.WriteLine("**    *****    **    ***     **                **");
            Console.WriteLine("**    *****    **    *****     **       ******** ");
            Console.WriteLine("**    *****    **    ******     **      *******");
            Console.WriteLine("**             **    *****     **       *******");
            Console.WriteLine("**    *****    **    ****     **            **");
            Console.WriteLine("**    *****    **            **       *******");
            Console.WriteLine("**    *****    **     ***     **      ******");
            Console.WriteLine("**    *****    **     ****     **     ******");
            Console.WriteLine("**    *****    **     *****     **       **");
            Console.WriteLine("******************************************");
        }

    }
}


