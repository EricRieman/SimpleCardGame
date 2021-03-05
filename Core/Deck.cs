using System;
using CardNS;
using CardListNS;
using HandNS;

namespace DeckNS
{
   [Serializable]
   public class Deck : CardList
   {
      private const int deckSize = 60;
      private const int handSize = 7;

      public Deck() // Impove this randomly generate a deck, or create a databse of cards to generate from
      {
         for ( int i = 0; i < deckSize; i++ )
         {
            Card card         = new Card();
            card.name = i.ToString();
            card.alignment = Card.Alignment.Jupiter;
            card.type = Card.Type.Cosmic;
            card.rarity = Card.Rarity.Silver;
            card.stats.top = 10;
            card.stats.bottom = 10;
            card.stats.left = 10;
            card.stats.right = 10;

            InsertCard( card );
         }
      }

      public Hand DrawHand()
      {
         Hand h = new Hand();
         for ( int i = 0; i < handSize; i++ )
            h.DrawCard( PopCard( 0 ) );

         return h;
      }
   }
}
