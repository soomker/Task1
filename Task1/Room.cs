using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Items;

namespace Task1
{
    class Room
    {

         //int maxX = 100;
        // int maxY = 100;
        List<Item> roomItems;
        public Room(int width, int height, List<Item> items)
        {
            MaxWidth = width;
            MaxHeight = height;
            roomItems = items;
        }

        public int MaxWidth
        {
            get;
            private set;
        }

        public  int MaxHeight
        {
            get;
            private set;
        }

        public  List<Item> RoomItems ()
        {
            return roomItems;
        }
    }
}
