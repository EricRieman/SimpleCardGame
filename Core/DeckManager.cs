using CardNS;
using DeckNS;

namespace DeckManagerNS
{
   public class DeckManager
   {
      public Deck deck;

      public DeckManager() // Impove this randomly generate a deck, or create a databse of cards to generate from
      {
         const int deckSize = 60;

         for (int i = 0; i < deckSize; i++)
         {
            Card card = new Card();
            card.name = i.ToString();
            card.alignment = Card.Alignment.Jupiter;
            card.type = Card.Type.Cosmic;
            card.rarity = Card.Rarity.Silver;
            card.stats.top = 10;
            card.stats.bottom = 10;
            card.stats.left = 10;
            card.stats.right = 10;

            deck.InsertCard( card );
         }
      }
   }
}