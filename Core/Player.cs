using System;
using HandNS;
using DeckNS;
using GraveyardNS;

namespace PlayerNS
{
   [Serializable]
   public class Player : PlayerInfo
   {
      public Hand Hand { set { hand = value; } }
      public Deck Deck { set { deck = value; } }
      public Graveyard Graveyard { set { graveyard = value; } }

      public Hand DrawHand()
      {
         return deck.DrawHand();
      }

      private Hand hand;
      private Deck deck;
      private Graveyard graveyard;
   }

   [Serializable]
   public class PlayerInfo
   {
      public string userName;
      public int initiative;
   }
}