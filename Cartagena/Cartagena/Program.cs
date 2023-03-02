using Cartagena.Entities;

namespace Cartagena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Instantiate the classes
            Player player = new Player();       
            Board board = new Board();
            #endregion

            board.BoardGame();      //gera o tabuleiro
            board.PrintBoard();     //Exibe o "tabuleiro"
            
            player.InitialCards();      //Gera a mão inicial do player.

            int count = 0;
            while (count < 5)
            {
                player.Moviment();
                board.UpdateBoard();
                board.PrintBoard();
                count++;
            }
        }
    }
}