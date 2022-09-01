using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica2022
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro(string titulo, int isbn, string autor)
        {
            Titulo = titulo;
            ISBN = isbn;
            Autor = autor;
            Anterior = null;
        }
        public override string ToString()
        {
            return "\nDados do livro:\nTitulo: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + ISBN;
        }
    }
}
