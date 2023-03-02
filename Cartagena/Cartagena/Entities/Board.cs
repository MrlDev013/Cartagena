using Cartagena.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena.Entities
{
    public class Board
    {
        public string[] board = new string[36];

        public void BoardGame()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < board.Length; i++)
            {
                int randomCard = rnd.Next(5);
                Cards card = (Cards)randomCard;

                board[i] = card.ToString();
            } 
        }
        public void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
