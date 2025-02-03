
using JogoDeXadrez.tabuleiro;
using JogoDeXadrez.Tabuleiro;
using Xadrez;



namespace JogoDeXadrez
{

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao Destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, Destino);
                }

               

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}  