using System;
using CardListNS;
using CardNS;

namespace HandNS
{
   [Serializable]
   public class Hand : CardList
   {
      public void DrawCard( Card card )
      {
         InsertCard( card );
      }

      // play card
   }
}