﻿using System;
using tabuleiro;
using xadrez;
namespace Jogo_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colcoarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colcoarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
