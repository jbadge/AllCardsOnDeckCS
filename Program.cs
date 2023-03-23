using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generating the deck
            var deckOfCards = new List<string>();
            var suits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var faces = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deckOfCards.Add($"{faces[j]} of {suits[i]}");
                }
            }

            // Shuffling deck
            var randomNumberGenerator = new Random();
            for (int rightIndex = deckOfCards.Count - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(deckOfCards.Count - 1);
                var leftCard = deckOfCards[leftIndex];
                var rightCard = deckOfCards[rightIndex];
                deckOfCards[rightIndex] = leftCard;
                deckOfCards[leftIndex] = rightCard;
            }

            // Giving two cards to player and then to dealer   
            var playerHand = deckOfCards.Take(2);
            Console.WriteLine(String.Join(", ", playerHand));
            deckOfCards.RemoveAt(0);
            deckOfCards.RemoveAt(0);

            var dealerHand = deckOfCards.Take(2);
            Console.WriteLine(String.Join(", ", dealerHand));
            deckOfCards.RemoveAt(0);
            deckOfCards.RemoveAt(0);
        }
    }
}