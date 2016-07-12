using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1.Items
{
  public  class Item
  {
        #region -------------- CLASS FIELDS -------------------

     public string ItemName { get; set; }
     private int itemPosX;
     private int itemPosY;

        private Point point;
        public Point Point
        {
            get { return point; }
            protected set { }
        }
     //public int[] CurrItemPos
     //   {
     //       get
     //       {
     //           return new int[] { itemPosX, itemPosY };
     //       }
     //   }
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
            point = new Point();
            point.X = posX;
            point.Y = posY;
            //itemPosX = posX;
          //itemPosY = posY;
         // totalPos = posX + posY;
      }

      #endregion -------------- CLASS CONSTRUCTOR -------------------

  }


}
