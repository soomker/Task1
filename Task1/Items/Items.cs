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

        private Point point;
        public Point Point
        {
         get { return point; }
            protected set { }
        }

        #endregion -------------- CLASS FIELDS -------------------

        #region -------------- CLASS CONSTRUCTOR -------------------

        public Item(int posX, int posY)
      {
            point = new Point();
            point.X = posX;
            point.Y = posY;
      }

        #endregion -------------- CLASS CONSTRUCTOR -------------------

  }


}
