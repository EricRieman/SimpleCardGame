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

      public Card PlayCard( int index )
      {
         return PopCard( index );
      }
   }
}