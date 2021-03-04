using UnityEngine;
using PlayerManagerNS;
using PlayerNS;

public class Core : MonoBehaviour
{
   public int numPlayer = 2;

   private void Start()
   {
      PlayerManager playerManager = new PlayerManager( GetPlayerInfo() );


      // begin game state?
   }

   private PlayerInfo[] GetPlayerInfo()
   {
      PlayerInfo[] allInfo = new PlayerInfo[2];

      PlayerInfo info = new PlayerInfo();
      info.userName = "Name1";
      info.initiative = 0;
      allInfo[0] = info;

      info.userName = "Name2";
      info.initiative = 1;
      allInfo[1] = info;

      return allInfo;
   }
}
