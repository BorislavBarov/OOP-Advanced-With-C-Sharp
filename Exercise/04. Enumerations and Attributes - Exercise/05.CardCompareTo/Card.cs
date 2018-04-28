using System;

public class Card : IComparable<Card>
{
    public Card(string rank, string suit)
    {
        this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
        this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
    }

    public Rank Rank { get; }

    public Suit Suit { get; }

    public int Power
    {
        get
        {
            return (int)this.Rank + (int)this.Suit;
        }
    }

    public override string ToString()
    {
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.Power}";
    }

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        if (ReferenceEquals(null, other))
        {
            return 1;
        }

        var rankComparison = this.Rank.CompareTo(other.Rank);

        if (rankComparison != 0)
        {
            return rankComparison;
        }

        return this.Suit.CompareTo(other.Suit);
    }
}