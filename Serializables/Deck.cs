using System;
using CardNS;
using CardListNS;

namespace DeckNS
{
   [Serializable]
   public class Deck : CardList
   {
      public Card Draw()
      {
         return PopCard(0);
      }


   }
}
