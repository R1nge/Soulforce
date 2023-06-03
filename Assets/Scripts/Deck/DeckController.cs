using System.Collections.Generic;
using Cards;
using Extensions;
using UnityEngine;

namespace Deck
{
    public class DeckController
    {
        private readonly List<CardBase> _deck = new();
        
        public void AddCard(CardBase card) => _deck.Add(card);
        public void RemoveCard(CardBase card) => _deck.Remove(card);
        public void Shuffle() => _deck.Shuffle();
        public CardBase DrawCard()
        {
            Debug.Log($"COUNT" + _deck.Count);
            return _deck.GetRandomElement();
        }
    }
}