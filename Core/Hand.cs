using System;
using Card;

namespace Hand
{
   [Serializable]
   public struct DuelHand
   {
      public int size;
      public DuelCard[] hand;
   }
}