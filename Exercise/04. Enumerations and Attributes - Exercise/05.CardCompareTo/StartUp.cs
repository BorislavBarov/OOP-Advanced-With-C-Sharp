using System;

public class StartUp
{
    public static void Main()
    {
        var firstCard = ReadCard();
        var secondCard = ReadCard();

        if (firstCard.CompareTo(secondCard) > 0)
        {
            Console.WriteLine(firstCard);
        }
        else
        {
            Console.WriteLine(secondCard);
        }
    }

    public static Card ReadCard()
    {
        var rank = Console.ReadLine();
        var suit = Console.ReadLine();

        var card = new Card(rank, suit);

        return card;
    }
}
