using System;
using HandNS;
using DeckNS;
using CardNS;
using GraveyardNS;

namespace PlayerNS
{
   [Serializable]
   public class Player : PlayerInfo
   {
      public Hand hand;
      public Deck deck;
      public Graveyard graveyard;

      public Player ( PlayerInfo info )
      {
         deck = new Deck();
         hand = deck.DrawHand();
         graveyard = new Graveyard();

         userName = info.userName;
         initiative = info.initiative;
      }
   }

   [Serializable]
   public class PlayerInfo
   {
      public string userName;
      public int initiative;
   }
}