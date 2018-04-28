using System;

public class Card : IComparable<Card>
{
    public Card(Rank rank, Suit suit)
    {
        this.Rank = rank;
        this.Suit = suit;
        this.Power = CalculatePower(this.Rank, this.Suit);
    }

    public Rank Rank { get; set; }

    public Suit Suit { get; set; }

    public int Power { get; set; }

    public int CompareTo(Card other)
    {
        return this.Power.CompareTo(other.Power);
    }

    public override int GetHashCode()
    {
        return (int)this.Rank + (int)this.Suit;
    }

    public override bool Equals(object obj)
    {
        var other = obj as Card;

        if (this.Suit != other.Suit)
        {
            return false;
        }

        return this.Rank == other.Rank;
    }

    public override string ToString()
    {
        return $"{this.Rank} of {this.Suit}";
    }

    private static int CalculatePower(Rank rank, Suit suit)
    {
        var power = 0;

        switch (rank)
        {
            case Rank.Ace:
                power += 14;
                break;
            default:
                power += (int)rank + 1;
                break;
        }

        switch (suit)
        {
            case Suit.Diamonds:
                power += 13;
                break;
            case Suit.Hearts:
                power += 26;
                break;
            case Suit.Spades:
                power += 39;
                break;
        }

        return power;
    }
}