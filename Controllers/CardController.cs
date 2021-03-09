using UnityEngine;

public class CardController : MonoBehaviour
{
   [SerializeField] private GameObject CardBack;

   private void OnMouseDown()
   {
      FlipCard();
   }

   public void FlipCard()
   {
      CardBack.SetActive( !CardBack.activeSelf );
   }
}
