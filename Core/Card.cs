using System;
using UnityEngine;

namespace CardNS
{
   [Serializable]
   public struct Card
   {
      public string name;
      public Alignment alignment;
      public Type type;
      public Rarity rarity;
      public Stats stats;

      public enum Alignment
      {
         // Type: Cosmic
         Jupiter,
         Pluto,
         Sol,
         Luna,

         // Type: Elemental
         Wind,
         Earth,
         Water,
         Fire
      };

      public enum Type
      {
         Cosmic,
         Elemental
      };

      public enum Rarity
      {
         Copper,
         Silver,
         Gold,
         Ruby
      };

      public struct Stats
      {
         public int top;
         public int left;
         public int bottom;
         public int right;
      }
   }

   public class EmptyCard
   {
      public static Card card = new Card();
      public static string EmptyCardStr = "Empty";

      EmptyCard() { card.name = EmptyCardStr; }
   }
}

