using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica2022
{
    internal class PilhaLivros
    {
        public Livro TOPO { get; set; }

        public PilhaLivros()
        {
            TOPO = null;
            Console.WriteLine("Pilha criada com sucesso!!");
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Simpatia, a pilha esta vazia");
            }
            else
            {
                TOPO = TOPO.Anterior;
                Console.WriteLine("O elemente foi removido.");
            }
        }
        public void Push(Livro auxiliar)
        {
            if (Vazia())
            {
                this.TOPO = auxiliar;
                Console.WriteLine("O livro foi adicionado a pilha");
            }
            else
            {
                auxiliar.Anterior = TOPO;
                this.TOPO = auxiliar;
                Console.WriteLine("O livro foi adicionado a pilha");
            }
        }
        public void Print()
        {
            if (Vazia())
                Console.WriteLine("A pilha esta vazia!");
            else
            {
                Livro auxiliar = TOPO;

                do
                {
                    Console.WriteLine(auxiliar.ToString());
                    auxiliar = auxiliar.Anterior;
                } while (auxiliar != null);
                Console.WriteLine("Fim da impressão");
            }

        }
        private bool Vazia()
        {
            if (TOPO == null)
                return true;
            else
                return false;
        }
       
        public void ProcurarLivro(string nomeLivro)
        {
            if (Vazia())
                Console.WriteLine("Não foi encontrado o livro, a pilha esta vazia;");
            else
            {
                Livro auxiliar = TOPO;
                bool achou = false;
                do
                {
                    if (auxiliar.Titulo == nomeLivro)
                    {
                        Console.WriteLine("Livro localizado: ");
                        Console.WriteLine(auxiliar.ToString());
                        Console.WriteLine("Aperte uma tecla para continuar");
                        Console.ReadKey();
                        achou = true;   
                    } 
                    auxiliar = auxiliar.Anterior;
                } while (auxiliar != null);
                if (!achou)
                {
                    Console.WriteLine("Livro nao localizado com esse titulo '" +nomeLivro+"'");
                } else
                {
                Console.WriteLine("Fim da busca!");
                }
                Console.WriteLine("");
            }
        }
    }
}
