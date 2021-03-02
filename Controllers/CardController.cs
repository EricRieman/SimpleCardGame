using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
   [SerializeField] private GameObject Card_Back;

   public void OnMouseDown()
   {
      if ( Card_Back.activeSelf )
         Card_Back.SetActive( false );
   }
}
