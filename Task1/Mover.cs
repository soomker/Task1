using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Items;
using System.Drawing;

namespace Task1
{
    class Mover
    {
        Random rand = new Random();
        //List<int[]> reservPos = new List<int[]>();
        List<Point> reservPos = new List<Point>();
        List<Item> itemsInRoom;
        int maxXpos;
        int maxYpos;
        public Mover(TheRoom room) 
        {
            maxXpos = room.MaxWidth;
            maxYpos = room.MaxHeight;
            itemsInRoom = room.RoomItems();
            for (int i = 0; i < itemsInRoom.Count; i++)
            {
                reservPos.Add(itemsInRoom[i].Point);
            }

        }
       
        
        public void MoveItems()
        {

            Point newPosPoint = new Point();
            for (int i = 0; i < itemsInRoom.Count; i++)
            {
               
                Console.WriteLine();
                Console.Write(itemsInRoom[i].ItemName+ "  Current position is: X - {0} and Y - {1} ", reservPos[i].X, reservPos[i].Y);
                do
                {
                    newPosPoint.X = rand.Next(maxXpos);
                    newPosPoint.Y = rand.Next(maxYpos);

                }
                while (reservPos.Contains(newPosPoint));
                reservPos[i] = newPosPoint;
                Console.Write(String.Format(itemsInRoom[i].ItemName + " Position after move is: X - {0} and Y - {1}", reservPos[i].X, reservPos[i].Y));
                Console.WriteLine();
            }  
        }

    }
}
