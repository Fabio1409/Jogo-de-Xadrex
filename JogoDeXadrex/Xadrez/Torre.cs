using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.Tabuleiro;
using tabuleiro;


namespace Xadrex
{
     class Torre:Peca
    {
        
        
            public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            }
            public override string ToString()
            {
                return "T";
            }
        
    }
}