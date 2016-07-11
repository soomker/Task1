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
        Random rand = new Random();
        List<int[]> reservPos = new List<int[]>();
        List<Item> itemsInRoom;
        int maxXpos;
        int maxYpos;
        public Mover(List<Item> roomItems, int roomSizeX, int roomSizeY) 
        {
            maxXpos = roomSizeX;
            maxYpos = roomSizeY;
            itemsInRoom = roomItems;
            for (int i = 0; i < itemsInRoom.Count; i++)
            {
                reservPos.Add(itemsInRoom[i].CurrItemPos);
            }

        }
       
        
        public void MoveItems()
        {
            

            for (int i = 0; i < itemsInRoom.Count; i++)
            {
                int[] newPos = new int[2];
                Console.WriteLine();
                Console.Write(itemsInRoom[i].ItemName+ "  Current position is: X - {0} and Y - {1} ", reservPos[i][0], reservPos[i][1]);
                do
                {
                    newPos[0] = rand.Next(maxXpos);
                    newPos[1] = rand.Next(maxYpos);

                }
                while (reservPos.Contains(newPos));
                reservPos[i] = newPos;
                Console.Write(String.Format(itemsInRoom[i].ItemName + " Position after move is: X - {0} and Y - {1}", reservPos[i][0], reservPos[i][1]));
                Console.WriteLine();
            }  
        }

    }
}
