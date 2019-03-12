using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Biblioteca
    {
        private int tam = 0;
        List<Libro> libreria = new List<Libro>();

        public int Tam { get => tam; set => tam = value; }

        public void NuevoLib(string tit, string aut)
        {
            Libro x = new Libro(tit,aut);
            libreria.Add(x);
            Console.WriteLine("Libro creado.");
            tam++;
        }

        public void BuscarLib(string tit)
        {
            
            int pos = libreria.FindIndex(x => x.Titulo == tit);
            if (pos != -1)
            {
                libreria[pos].MostrarLibro();
                Console.WriteLine("Posición del libro = " + (pos+1));
            }
            else
            {
                Console.WriteLine("El libro no existe.");
            }

        }

        public void EliminarLib(string tit)
        {
            int pos = libreria.FindIndex(x => x.Titulo == tit);
            if (pos != -1)
            {
                libreria.Remove(libreria[pos]);
                Console.WriteLine("Libro borrado.");
                --tam;
            }
            else
            {
                Console.WriteLine("El libro no existe.");
            }

        }

        public void ImprimirLib()
        {
            foreach (Libro x in libreria)
            {
                x.MostrarLibro();
            }
                
        }

        public void ModificarLib(string tit)
        {

            int pos = libreria.FindIndex(x => x.Titulo == tit);
            if (pos != -1)
            {
                libreria[pos].MostrarLibro();

                Console.WriteLine("1. Para modificar Titulo introducir");
                Console.WriteLine("2. Para modificar Autor introducir");
                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("Introduzca el nombre del nuevo Titulo:");
                    string valor = Console.ReadLine();
                    libreria[pos].Titulo = valor;
                    
                }else if (num == 2)
                {
                    Console.WriteLine("Introduzca el nombre del nuevo Autor:");
                    string valor = Console.ReadLine();
                    libreria[pos].Autor = valor;
                }
            }
            else
            {
                Console.WriteLine("El libro no existe.");
            }
        }



    }
}
