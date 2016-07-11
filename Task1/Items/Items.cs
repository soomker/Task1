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

      public string ItemName { get; set; }
      int itemPosX;
      int itemPosY;
     
     public int[] CurrItemPos
        {
            get
            {
                return new int[] { itemPosX, itemPosY };
            }
        }
     //public Dictionary<string, int> CurrItemPos
     //   {
     //       get
     //       {
     //           return new Dictionary<string, int> {{"x",itemPosX },{"y", itemPosY }};
     //       }
     //   }


        //int totalPos;

        #endregion -------------- CLASS FIELDS -------------------

        #region -------------- CLASS CONSTRUCTOR -------------------

        public Item(int posX, int posY)
      {
          itemPosX = posX;
          itemPosY = posY;
         // totalPos = posX + posY;
      }

      #endregion -------------- CLASS CONSTRUCTOR -------------------

  }


}
