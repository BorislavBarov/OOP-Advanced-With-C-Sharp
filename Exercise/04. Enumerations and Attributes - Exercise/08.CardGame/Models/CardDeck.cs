using System;
using System.Collections;
using System.Collections.Generic;

public class CardDeck : IEnumerable<Card>
{
    public CardDeck()
    {
        this.Cards = new List<Card>();
        this.Cards = this.CreateDeck();
    }

    public List<Card> Cards { get; set; }
    
    public bool Contains(Card card)
    {
        return this.Cards.Contains(card);
    }

    public void DrawCard(Card card)
    {
        this.Cards.Remove(card);
    }

    public IEnumerator<Card> GetEnumerator()
    {
        return ((IEnumerable<Card>)this.Cards).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private List<Card> CreateDeck()
    {
        var cards = new List<Card>();
        var suits = Enum.GetValues(typeof(Suit));
        var ranks = Enum.GetValues(typeof(Rank));

        foreach (Suit suit in suits)
        {
            foreach (Rank rank in ranks)
            {
                var card = new Card(rank, suit);
                cards.Add(card);
            }
        }

        return cards;
    }
}