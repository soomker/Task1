using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
  public  class Item
  {
      #region -------------- CLASS FIELDS -------------------
      
      string itemName;
      int itemPosX;
      int itemPosY;
      int totalPos;
      
      #endregion -------------- CLASS FIELDS -------------------

       #region -------------- CLASS PROPERTIES -------------------
 
      /// <summary>
     /// Sum of Positions (need for check reserved positions)
    /// </summary>
      public int TotalPos
      {
          get { return totalPos; }
      }
     
       #endregion -------------- CLASS PROPERTIES -------------------

      #region -------------- CLASS CONSTRUCTOR -------------------

      public Item(string name, int posX, int posY)
      {
          itemName = name;
          itemPosX = posX;
          itemPosY = posY;
          totalPos = posX + posY;
      }

      #endregion -------------- CLASS CONSTRUCTOR -------------------

      #region -------------- CLASS METHODS -------------------

      public virtual void SaySomething(){}
    
     
      public void Move(int [] positions)
        {
            Console.Write(String.Format(itemName + " Current position is: X - {0} and Y - {1} ", itemPosX.ToString(), itemPosY.ToString()));
            Random rand = new Random();
            do
            {
                itemPosX = rand.Next(0, 100);
                itemPosY = rand.Next(0, 100);
                totalPos = itemPosX + itemPosY;
            }
            while (positions.Contains(totalPos));
            Console.Write(String.Format(itemName + " Position after move is: X - {0} and Y - {1}", itemPosX.ToString(), itemPosY.ToString()));
            Console.WriteLine();
            totalPos = itemPosX + itemPosY;
        }

      #endregion -------------- CLASS METHODS -------------------
  }

 public class Animal : Item
    {
     string animalSpeech;  
     public Animal(string name, int posX, int posY, string speech)
            : base(name,posX,posY)
        {
            animalSpeech = speech;
        }

        public override void SaySomething()
        {
            Console.Write(animalSpeech);
        }
    }
}
