using UnityEngine;

public class CardController : MonoBehaviour
{
   public Quaternion start;
   public float lerpTime = 1;

//   private void OnMouseDown()
//   {
//      FlipCard();
//   }
//
//   public void FlipCard()
//   {
//      //CardBack.SetActive( !CardBack.activeSelf );
//
//      for ( float i = 0; i <=180; i+= 10 )
//      {
//         transform.rotation = Quaternion.Euler( 0, i, 0 );
//      }
//
//
//   }

   void Start()
   {
      start = transform.rotation;
   }

   void Update()
   {
      //transform.rotation = Quaternion.Lerp( transform.rotation, start, Time.deltaTime * lerpTime );
      transform.Rotate( Vector3.up );
   }
}
