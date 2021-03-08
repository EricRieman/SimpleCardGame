using UnityEngine;

public class CardController : MonoBehaviour
{
   [SerializeField] private GameObject CardBack;

   public void OnMouseDown()
   {
      if ( CardBack.activeSelf )
         CardBack.SetActive( false );
   }
}
