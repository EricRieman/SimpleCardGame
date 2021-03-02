using UnityEngine;
using Player;
using Card;

public class PlayersCreator : MonoBehaviour
{
   public DuelPlayer[] players;

   void Start()
   {
      BuildPlayers();
   }

   private void BuildPlayers()
   {
      players = new DuelPlayer[ 2 ];

      DuelCard[] tempHand = new DuelCard[0];

      for ( int i = 0; i < players.Length; i++ )
      {
         DuelPlayer p = new DuelPlayer();
         //p.hand = tempHand;
         p.index = i;
         p.userName = "Player " + 1;
         players[ i ] = p;
      }
   }
}
