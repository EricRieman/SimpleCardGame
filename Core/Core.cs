using UnityEngine;
using PlayerNS;
using BoardNS;
using System.Collections.Generic;
using System;

public class Core : MonoBehaviour
{
   public List<Player> players;
   //public Board board;

   private void Start()
   {
      CreatePlayers();
   }

   private void CreatePlayers()
   {
      List<PlayerInfo> allInfo = GetPlayerInfo();
   
      for ( int i = 0; i < allInfo.Count; i++ )
         players.Add( new Player( allInfo[ i ] ) );
   }
   
   private List<PlayerInfo> GetPlayerInfo()
   {
      List<PlayerInfo> allInfo = new List<PlayerInfo>();

      PlayerInfo info = new PlayerInfo();

      info.userName   = "Name1";
      info.initiative = 0;
      allInfo.Add( info );

      info.userName   = "Name2";
      info.initiative = 1;
      allInfo.Add( info );
   
      return allInfo;
   }
}
