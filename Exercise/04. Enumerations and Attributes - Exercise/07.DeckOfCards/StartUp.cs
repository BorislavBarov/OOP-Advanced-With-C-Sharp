using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var cards = new List<Card>();

        foreach (var suit in Enum.GetNames(typeof(Suit)))
        {
            foreach (var rank in Enum.GetNames(typeof(Rank)))
            {
                cards.Add(new Card(rank, suit));
            }
        }

        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
}