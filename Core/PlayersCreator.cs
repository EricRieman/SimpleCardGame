using Player;
using Hand;
using System.Collections.Generic;

namespace PlayerManager
{
   public class PlayersCreator
   {
      public List<DuelPlayer> players;

      public PlayersCreator( int numPlayers )
      {
         BuildPlayers(numPlayers);
      }

      private void BuildPlayers(int numPlayers)
      {

         // Deack creator here. Add method to remove top 7 to initlize Dual
         DuelHand hand = new DuelHand();

         for( int i = 0; i < numPlayers; i++)
         { 
            DuelPlayer p = new DuelPlayer();

            p.hand = hand;
            p.index = i;
            p.userName = "Player " + 1;
            players.Add( p );
         }
      }
   }
}