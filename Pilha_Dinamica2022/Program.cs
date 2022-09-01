using System;

namespace Pilha_Dinamica2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuEscolha, totalLivros = 0;
            bool saida = true;
            PilhaLivros pilha = new PilhaLivros();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu inicial - Exercicio Pilha de livros");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção para realizar alguma operação");
                Console.WriteLine("1.Inserir um livro na pilha \n2.Remover o livro da pilha \n3.Imprimir pilha de livros" +
                    "\n4.Imprimir quantidade de livros na pilha \n5.Localizar um livro na pilha \n6.Sair");
                menuEscolha = int.Parse(Console.ReadLine());
                if (menuEscolha == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Inserir um livro na pilha");
                    Console.WriteLine("Insira um valor de nome:");
                    string Titulo = Console.ReadLine();
                    Console.WriteLine("Insira um IBSN");
                    int ISBN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira uma autor");
                    string Autor = Console.ReadLine();
                    Livro livro = new Livro(Titulo, ISBN, Autor);
                    pilha.Push(livro);
                    totalLivros++;
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadKey();
                }
                else if (menuEscolha == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Remover um livro da pilha");
                    pilha.Pop();
                    totalLivros--;
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadKey();
                }
                else if (menuEscolha == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Imprimir lista de livros");
                    pilha.Print();
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadKey();
                }
                else if (menuEscolha == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Imprimir a quantidade de livros na lista");
                    Console.WriteLine("A quantidade total de livro na lista é: " + totalLivros);
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadKey();
                }
                else if (menuEscolha == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Localizar um livro na pilha");
                    Console.WriteLine("Insira o nome do livro desejado: ");
                    string nomeLivro = Console.ReadLine();
                    pilha.ProcurarLivro(nomeLivro);
                    Console.WriteLine("Aperte uma tecla para continuar");
                    Console.ReadKey();
                }
                else if (menuEscolha == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Voce selecionou: Sair\nObrigado pela visita!");
                    saida = false;
                }
            } while (saida);
        }
    }
}
