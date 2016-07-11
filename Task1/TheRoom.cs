using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Items;

namespace Task1
{
    class TheRoom
    {

         int maxX = 100;
         int maxY = 100;
        List<Item> roomItems;
        public TheRoom()
        {
            Chair chair = new Chair(20, 30);
            Table table = new Table(40, 50);
            Tv tv = new Tv(25, 55);
            Pc pc = new Pc(44, 0);
            Couch couch = new Couch(10, 16);
            Cat cat = new Cat(10, 16);
            Dog dog = new Dog(12, 13);
            roomItems = new List<Item> { chair, table, tv, pc, couch, cat , dog};
        }

        public  int MaxX
        {
            get
            {
                return maxX;
            }
        }

        public  int MaxY
        {
            get
            {
                return maxY;
            }
        }

        public List<Item> RoomItems
        {
            get
            {
                return roomItems;
            }
        }
    }
}
