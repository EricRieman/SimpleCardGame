using System;
using HandNS;
using DeckManagerNS;

namespace PlayerNS
{
   [Serializable]
   public class Player : PlayerInfo
   {
      public Hand hand; //hand manager
      public DeckManager deckManager;
      //public Graveyard graveyard; // manager
   }

   [Serializable]
   public class PlayerInfo
   {
      public string userName;
      public int initiative;
   }
}