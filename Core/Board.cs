using System;
using System.Collections.Generic;
using CardNS;
using UnityEngine;

namespace BoardNS
{
   [Serializable]
   public class Board
   {
      public List<List< Card> > board = new List< List< Card > >();
      private const int height = 9;
      private const int width = 11;

      public GameObject layout;

      public Board()
      {
         for ( int row = 0; row < height; row++ )
            for ( int col = 0; col < width; col++ )
               board[row][col] = EmptyCard.card;
      }

      public void PlayCard( int row, int col, Card card )
      {
         //Could make limit checks here, check for null

         //board[x].Insert(y, card);

         board[row][col] = card;
      }

      public Card DestroyCard( int row, int col )
      {
         Card card = board[row][col];

         board[row][col] = EmptyCard.card;

         return card;
      }
   }
}