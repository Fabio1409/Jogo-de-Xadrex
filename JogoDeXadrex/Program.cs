using JogoDeXadrez.Tabuleiro;
using JogoDeXadrez.Xadrex;
using System;
using Xadrex;

namespace JogoDeXadrez.tabuleiro;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            PosicaoXadrex pos = new PosicaoXadrex('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
        catch (TabuleiroException e) 
        {
            Console.WriteLine(e.Message);
        }
} }