using UnityEngine;
using PlayerNS;
using DeckNS;
using GraveyardNS;
using System.Collections.Generic;

public class Core : MonoBehaviour
{
   public int numPlayer = 2;

   public List<Player> players;

   private void Start()
   {
      CreatePlayers();

      // begin game state?
   }

   private void CreatePlayers()
   {
      PlayerInfo[] allInfo = GetPlayerInfo();

      for ( int i = 0; i < allInfo.Length; i++ )
      {
         Player p = new Player();

         p.deck       = new Deck();
         p.hand       = p.DrawHand();
         p.graveyard  = new Graveyard();
         p.initiative = allInfo[ i ].initiative;
         p.userName   = allInfo[ i ].userName;

         players.Add( p );
      }
   }

   private PlayerInfo[] GetPlayerInfo()
   {
      PlayerInfo[] allInfo = new PlayerInfo[2];
      PlayerInfo info = new PlayerInfo();

      info.userName   = "Name1";
      info.initiative = 0;
      allInfo[0]      = info;

      info.userName   = "Name2";
      info.initiative = 1;
      allInfo[1]      = info;

      return allInfo;
   }
}
