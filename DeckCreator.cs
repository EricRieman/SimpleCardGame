using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeckCreator : MonoBehaviour
{
   public Card[] deck;
   const int deckSize = 60;

   private void Start()
   {

   }

   private void Update()
   {

   }

   private void BuildDeck()
   {
      deck = new Card[ deckSize ];

      for ( int i = 0; i < deckSize; i++ )
      {
         Card card = new Card();
         card.name = i.ToString();
         card.alignment = Card.Alignment.Jupiter;
         card.type = Card.Type.Cosmic;
         card.rarity = Card.Rarity.Silver;
         card.stats.top = 10;
         card.stats.bottom = 10;
         card.stats.left = 10;
         card.stats.right = 10;

         deck[ i ] = card;
      }
   }
}

[Serializable]
public class Card 
{
   public string name;
   public Alignment alignment;
   public Type type;
   public Rarity rarity;
   public Stats stats;

   public enum Alignment
   {
      // Type: Cosmic
      Jupiter,
      Pluto,
      Sol,
      Luna,

      // Type: Elemental
      Wind,
      Earth,
      Water,
      Fire
   };

   public enum Type
   {
      Cosmic,
      Elemental
   };

   public enum Rarity
   {
      Copper,
      Silver,
      Gold,
      Ruby
   };

   public struct Stats
   {
      public int top;
      public int left;
      public int bottom;
      public int right;
   }
}


