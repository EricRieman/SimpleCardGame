using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeckCreator : MonoBehaviour
{
   public Player[] players;
   public Card[] deck;
   const int deckSize = 60;

   private void Start()
   {
      BuildPlayers();
      BuildDecks();
   }

   private void Update()
   {

   }

   private void BuildDecks()
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

   private void BuildPlayers()
   {
      players = new Player[ 2 ];

      Card[] tempHand = new Card[0];

      for (int i = 0; i < players.Length; i++ )
      {
         Player p = new Player();
         p.hand = tempHand;
         p.index = i;
         p.userName = "Player " + 1;
         players[ i ] = p;
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

[Serializable]
public class Player
{
   public Card[] hand;
   public int index;
   public string userName;
}
