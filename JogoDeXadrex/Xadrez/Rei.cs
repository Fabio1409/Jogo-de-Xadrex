
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
    public override bool[,] movimentosPossivel()
    {
        bool[,] mat = new bool[tab.Linhas, tab.Colunas];

        Posicao pos = new Posicao(0, 0);

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha - 1, posicao.coluna);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha + 1, posicao.coluna);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }

        // verificando os movimentos do rei para noroeste
        pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
        if (tab.posicaoValida(pos) && podeMover(pos))
        {
            mat[pos.linha, pos.coluna] = true;
        }
        // verificando os movimentos do rei para noroeste
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
        return mat;
    }
}

