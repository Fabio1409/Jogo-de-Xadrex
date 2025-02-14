﻿

namespace JogoDeXadrez.Jogo;

public abstract class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }

    public int qteMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }

    public Peca(Tabuleiro tab, Cor cor)
    {
        this.posicao = null;
        this.tab = tab;
        this.cor = cor;
        this.qteMovimentos = 0;
    }
    public void incrementarQteMovimentos()
    {
        qteMovimentos++;
    }

    public void decrementarQteMovimentos()
    {
        qteMovimentos--;
    }

    public bool existeMovimentosPossiveis()
    {
        bool[,] mat = movimentosPossivel();
        for (int i = 0; i < tab.Linhas; i++)
        {
            for (int j = 0; j < tab.Colunas; j++)
            {
                if ( mat[i, j])
                {
                    return  true;
                }
            }
        }
        return false;
    }

    public bool podeMoverPara(Posicao pos)
    {
      return  movimentosPossivel()[pos.linha, pos.coluna];
    }
    

    public abstract bool[,] movimentosPossivel();

}

