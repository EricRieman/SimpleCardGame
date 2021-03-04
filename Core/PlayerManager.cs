using PlayerNS;
using HandNS;
using DeckManagerNS;
using System.Collections.Generic;

namespace PlayerManagerNS
{
   public class PlayerManager
   {
      public List<Player> players;

      public PlayerManager( PlayerInfo[] allInfo )
      {
         for (int i = 0; i < allInfo.Length; i++)
         {
            Player p = new Player();

            p.deckManager = new DeckManager();



            Hand h;
            for (int i = 0; i < numPlayers; i++)
               h.cards.Add();

            p.hand = DrawHand(i);


            p.initiative = allInfo[i].initiative;
            p.userName = allInfo[i].userName;
            players.Add(p);
         }
      }

      public void DrawHand( int i )
      {
         deckManager.Draw();
         Hand hand = new Hand(deckManager);
      }
   }
}