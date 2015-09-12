using System;
//Write a program that generates and prints all possible cards from a standard deck of 52 cards(without the jokers). The cards should be printed using the classical notation(like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A.Print each card face in its four possible suits: clubs, diamonds, hearts and spades.Use 2 nested for-loops and a switch-case statement.
//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠



class DeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
        string[] symbols = { "♣", "♦", "♥", "♠" };
        for (int i = 0; i < cards.Length; i++)
        {

            for (int j = 0; j < symbols.Length; j++)
            {
                Console.Write(cards[i] + " ");
                Console.Write(symbols[j]);
            }
            Console.WriteLine();
            

        }

    }

}


