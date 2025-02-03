
using JogoDeXadrez.Tabuleiro;
using JogoDeXadrez.Xadrez;
using Xadrex;



namespace JogoDeXadrez.tabuleiro;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            //PosicaoXadrez pos = new PosicaoXadrez('c', 7);


            //Console.WriteLine(pos);

            //Console.WriteLine(pos.toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
            //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 8));
            //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 2));
            Tela.imprimirTabuleiro(tab);
           
        }
        catch (TabuleiroException e) 
        {
            Console.WriteLine(e.Message);
        }
        

    } }