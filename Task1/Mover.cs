using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Items;

namespace Task1
{
    class Mover
    {
        public Mover() 
        {
           
        
        }
       
        
        public void MoveItems(List<Item> roomItems, ref int[] reservedPos, int maxXpos, int maxYpos)
        {
           
            for (int i = 0; i < roomItems.Count; i++)
            {
                if (roomItems[i] is Animal)
                {
                    Animal anim = roomItems[i] as Animal;
                    anim.SaySomething();
                }
                roomItems[i].Move(reservedPos, maxXpos, maxYpos);
                reservedPos[i] = roomItems[i].TotalPos;
            }

        }
    }
}
