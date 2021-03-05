using CardNS;
using System.Collections.Generic;

namespace CardListNS
{
   public class CardList
   {
      public List< Card > cards = new List< Card >();

      protected void InsertCard( Card card )
      {
         cards.Add( card );
      }

      protected Card PopCard( int pos )
      {
         //could put a safety check in here
         Card c = cards[ pos ];
         cards.RemoveAt( pos );

         return c;
      }
   }
}
