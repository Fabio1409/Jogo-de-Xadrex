using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.Tabuleiro;


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