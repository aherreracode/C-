using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Libro
    {
        string titulo;
        string autor;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }

        public void MostrarLibro()
        {
            Console.WriteLine("* * * * Libro * * * *");
            Console.WriteLine("* Titulo: "+Titulo);
            Console.WriteLine("* Autor: "+Autor);
            Console.WriteLine("* * * * * * * * * * *");
            Console.WriteLine("");
        }
    }
}
