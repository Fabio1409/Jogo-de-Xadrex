

using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.Tabuleiro;
using tabuleiro;



namespace Xadrex
{
     class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab, cor) 
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
