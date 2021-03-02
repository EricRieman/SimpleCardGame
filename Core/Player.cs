using System;
using Hand;

namespace Player
{
   [Serializable]
   public struct DuelPlayer
   {
      public DuelHand hand;     
      public string userName;
      public int index;
   }
}