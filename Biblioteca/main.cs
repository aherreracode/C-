using System;

namespace Biblioteca
{
    class main
    {
        static void Main(string[] args)
        {

            int num = -1;
            string titulo;
            string autor;
            Biblioteca libros = new Biblioteca();

            do
            {
                Console.Clear();
                Console.WriteLine("* * * * * * * * * Libreria  * * * * * * * * *");
                Console.WriteLine("* - - - - - Selecciona la opción  - - - - - *");
                Console.WriteLine("* 0. Salir.                                 *");
                Console.WriteLine("* 1. Dar de alta un libro.                  *");
                Console.WriteLine("* 2. Buscar un libro en la base de datos.   *");
                Console.WriteLine("* 3. Eliminar un libro de la base de datos. *");
                Console.WriteLine("* 4. Imprimir la lista de libros.           *");
                Console.WriteLine("* 5. Modificar libro.                       *");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");

                num = int.Parse(Console.ReadLine());
                Console.WriteLine("");


                switch (num)
                {
                    case 1:

                        if (libros.Tam > 9)
                        {
                            Console.WriteLine("La Biblioteca está llena.");
                        }
                        else
                        {
                            Console.WriteLine("Introduzca Titulo:");
                            titulo = Console.ReadLine();

                            Console.WriteLine("Introduzca Autor:");
                            autor = Console.ReadLine();

                            libros.NuevoLib(titulo, autor);
                        }

                        break;

                    case 2:

                        if (libros.Tam > 0)
                        {
                            Console.WriteLine("Introduzca Titulo:");
                            titulo = Console.ReadLine();
                            libros.BuscarLib(titulo);
                        }
                        else
                        {
                            Console.WriteLine("No hay ningún libro.");
                        }

                        break;

                    case 3:

                        if (libros.Tam > 0)
                        {
                            Console.WriteLine("Introduzca Titulo:");
                            titulo = Console.ReadLine();
                            libros.EliminarLib(titulo);
                        }
                        else
                        {
                            Console.WriteLine("No hay ningún libro.");
                        }

                        break;

                    case 4:

                        libros.ImprimirLib();

                        break;

                    case 5:

                        if (libros.Tam > 0)
                        {
                            Console.WriteLine("Introduzca Titulo:");
                            titulo = Console.ReadLine();
                            libros.ModificarLib(titulo);
                        }
                        else
                        {
                            Console.WriteLine("No hay ningún libro.");
                        }

                        break;

                    default:

                        break;
                }

                Console.WriteLine("Pulse enter para continuar...");
                Console.ReadLine();

            } while (num != 0);
            

            
        }
    }
}
