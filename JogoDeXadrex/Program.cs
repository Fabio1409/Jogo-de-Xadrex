﻿using System;

namespace JogoDeXadrez.Tabuleiro
{
    class Program
    {
        public static void Main(string[] args)
        {
            Posicao p;
            p = new(3, 4);

            Console.WriteLine("Posiçao: " + p);
        }
    }
}