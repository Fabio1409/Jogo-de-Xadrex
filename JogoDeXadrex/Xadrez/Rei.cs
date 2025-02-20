
using JogoDeXadrez.Jogo;
namespace JogoDeXadrez.Xadrez;

 public class Rei : Peca
{
     
    private PartidaDeXadrez partida;
    public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
    {
        this.partida = partida;
    }
    public override string ToString()
    {
        return "R";
    }
    private bool podeMover(Posicao pos)
    {
        Peca p = tab.peca(pos);
        return p == null || p.cor != cor;
    }

    private bool testeTorreParaRoque(Posicao pos)
    {
        Peca p = tab.peca(pos);
        return p != null && p is Torre && p.cor == cor && p.qteMovimentos == 0;

    }
    public override bool[,] movimentosPossiveis()
    {
        bool[,] mat = new bool[tab.Linhas, tab.Colunas];

        Posicao pos = new Posicao(0, 0);

        

        // verificando os movimentos do rei para acima
        pos.definirValores(posicao.linha - 1, posicao.coluna);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para nordeste
        pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para direita
        pos.definirValores(posicao.linha, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para sudeste
        pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para abaixo
        pos.definirValores(posicao.linha + 1, posicao.coluna);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para sudoeste
        pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }
        // verificando os movimentos do rei para esquerda
        pos.definirValores(posicao.linha, posicao.coluna - 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }
        // # Jogada especial roque pequeno

        if(qteMovimentos == 0 && !partida.xeque)
        {
            Posicao posT1 = new Posicao(pos.linha, pos.coluna + 3);
            if (testeTorreParaRoque(posT1))
            {
                Posicao p1 = new Posicao(pos.linha,posicao.coluna + 1);
                Posicao p2 = new Posicao(pos.linha,posicao.coluna + 2);
                if (tab.peca(p1) == null && tab.peca(p2) == null)
                {
                    mat[posicao.linha, pos.coluna + 2] = true;
                }
            }
        }

        // Jogada especial roque grande

        Posicao posT2 = new Posicao(pos.linha, pos.coluna - 4);
        if (testeTorreParaRoque(posT2))
        {
            Posicao p1 = new Posicao(pos.linha, posicao.coluna - 1);
            Posicao p2 = new Posicao(pos.linha, posicao.coluna - 2);
            Posicao p3 = new Posicao(pos.linha, posicao.coluna - 3);
            if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
            {
                mat[posicao.linha, pos.coluna - 2] = true;
            }
        }

        return mat;
    }
}

