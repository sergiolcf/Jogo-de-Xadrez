using System;
using tabuleiro;
using xadrez;
namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colcoarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colcoarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
