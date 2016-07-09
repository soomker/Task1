using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Items;

namespace Task1
{
    class Program
    {
      static  int maxX = 100;
      static  int maxY = 100;
        static void Main(string[] args)
        {
            Furniture chair = new Furniture("chair", 20, 30);
            Furniture table = new Furniture("table", 40, 50);
            Furniture tv = new Furniture("tv", 25, 55);
            Furniture pc = new Furniture("pc", 44, 0);
            Furniture couch = new Furniture("couch", 10, 16);
            Animal cat = new Animal("cat", 10, 16, "Meow!!");
            
            List<Item> roomItems = new List<Item> { chair, table, tv, pc, couch, cat };
            int[] reservPos = new int[roomItems.Count];

            for (int i = 0; i < roomItems.Count; i++)
            {
                reservPos[i] = roomItems[i].TotalPos;
            }

            ConsoleKeyInfo key;
            
            Console.WriteLine();
            Console.WriteLine("To move Items press 'ENTER' or double press 'Esc' to exit");
            while ((key = Console.ReadKey(true)).Key == ConsoleKey.Enter)
            {
                Mover mover = new Mover();
                mover.MoveItems(roomItems, ref reservPos, maxX, maxY);
                Console.WriteLine("To move Items press 'ENTER' or double press 'Esc' to exit");
                if (key.Key == ConsoleKey.Escape) return;
                
            }
            
                       
         }
       
    }
}
