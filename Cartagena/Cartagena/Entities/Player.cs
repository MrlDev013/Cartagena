using Cartagena.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena.Entities
{
    public class Player
    {
        string[] playerCards = new string[5];
        public string? cardC;

        Dictionary<Cards, int> cardsCount = new Dictionary<Cards, int>();
        Board board = new Board();

        public void InitialCards()
        {
            foreach (Cards letter in Enum.GetValues(typeof(Cards)))
            {
                cardsCount[letter] = 0;
            }

            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int rnd = random.Next(5);

                Cards cards = (Cards)rnd;
                cardsCount[cards]++;
                playerCards[i] = cards.ToString();
            }

            Console.WriteLine();
            Console.WriteLine("Cards: ");

            foreach (KeyValuePair<Cards, int> par in cardsCount)
            {
                Console.WriteLine(par.Key + " : " + par.Value);
            }

            Console.WriteLine();
        }

        public void Moviment()
        {
            Dictionary<Cards, int> quantidadeDisponivel = new Dictionary<Cards, int>(cardsCount);
            
            Console.WriteLine("Which card do you want to use?(C/E/F/G/T)");
            cardC = Console.ReadLine();
            Cards card;

            if (!Enum.TryParse(cardC, out card))
            {
                Console.WriteLine("Unvailable letter");
                return;
            }

            foreach (KeyValuePair<Cards, int> par in quantidadeDisponivel)
            {
                if (quantidadeDisponivel[card] > 0)
                {
                    quantidadeDisponivel[card]--;
                }
                Console.WriteLine(par.Key + " : " + par.Value);
            }
            Console.WriteLine();
        }
        
    }
}
