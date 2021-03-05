using System;
using HandNS;
using DeckNS;
using GraveyardNS;

namespace PlayerNS
{
   [Serializable]
   public class Player : PlayerInfo
   {
      public Hand hand;
      public Deck deck;
      public Graveyard graveyard;

      public Hand DrawHand()
      {
         return deck.DrawHand();
      }
   }

   [Serializable]
   public class PlayerInfo
   {
      public string userName;
      public int initiative;
   }
}