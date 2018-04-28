using System;

public class Card
{
    public Card(string rank, string suit)
    {
        this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
        this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
    }

    public Rank Rank { get; }

    public Suit Suit { get; }

    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }
}