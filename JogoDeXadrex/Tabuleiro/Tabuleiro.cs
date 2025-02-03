
using JogoDeXadrez.Tabuleiro;
using tabuleiro;
using Xadrex;


namespace JogoDeXadrez.tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;// Matriz de peças

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        // METODO SE EXISTE UMA PEÇA NUMA DADA POSIÇÃO
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;

        }


        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }


        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        // METODO RETIRAR PEÇA
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;

            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
               return aux;
        }
       

        // TESTAR POSIÇAÕ
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= Linhas || pos.coluna < 0 || pos.coluna > Colunas)
            {
                return false;
            }
            return true;
        }

        // VALIDAR POSIÇÃO
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }

        internal void colocarPeca(Torre torre, Posicao posicao)
        {
            throw new NotImplementedException();
        }
    }
}
