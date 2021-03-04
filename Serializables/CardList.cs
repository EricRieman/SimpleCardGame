using CardNS;
using System.Collections.Generic;

namespace CardListNS
{
   public class CardList
   {
      private List< Card > cards;

      public void InsertCard( Card card )
      {
         cards.Add( card );
      }

      public Card PopCard( int pos )
      {
         //could put a safety check in here
         Card c = cards[ pos ];
         cards.RemoveAt( pos );

         return c;
      }
   }
}
