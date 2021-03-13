using UnityEngine;

public class CardController : MonoBehaviour
{
   bool flipped = false;
   bool moved = false;

   void Update()
   {
      FlipCard();
   }

   void FlipCard()
   {
      if ( !flipped )
      {
         transform.Rotate( new Vector3( 0, 200, 0 ) * Time.deltaTime );
         flipped = transform.localRotation.y >= 0.98;
         if ( flipped )
            transform.localRotation = new Quaternion( 0.0f, 1.0f, 0.0f, 0.0f );
      }
   }

   void MoveCard()
   {
      if ( !moved )
      {
         //move card
      }
   }
}
