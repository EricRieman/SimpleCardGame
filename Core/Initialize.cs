using UnityEngine;
using PlayerManager;

public class Core : MonoBehaviour
{
   public int numPlayer = 2;

   private void Start()
   {
      PlayersCreator playerCreator = new PlayersCreator( numPlayer );

      // draw hands

      // begin game state?
   }
}
