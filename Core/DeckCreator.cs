using UnityEngine;
using Card;

public class DeckCreator : MonoBehaviour
{
   public DuelCard[] deck;
   const int deckSize = 60;

   private void Start()
   {
      BuildDecks();
   }

   private void BuildDecks()
   {
      deck = new DuelCard[ deckSize ];

      for ( int i = 0; i < deckSize; i++ )
      {
         DuelCard card = new DuelCard();
         card.name = i.ToString();
         card.alignment = DuelCard.Alignment.Jupiter;
         card.type = DuelCard.Type.Cosmic;
         card.rarity = DuelCard.Rarity.Silver;
         card.stats.top = 10;
         card.stats.bottom = 10;
         card.stats.left = 10;
         card.stats.right = 10;

         deck[ i ] = card;
      }
   }
}