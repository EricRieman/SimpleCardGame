using System;
using Card;

namespace Deck
{
   [Serializable]
   public struct Deck
   {
      public DuelCard[] deck;

      public int size;
      public int graveyardSize;
   }
}
