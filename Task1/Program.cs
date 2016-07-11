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
      
        static void Main(string[] args)
        {
            TheRoom room = new TheRoom();
            Mover mover = new Mover(room.RoomItems, room.MaxX, room.MaxY);
            ConsoleKeyInfo key;
            Console.WriteLine("To move Items press 'ENTER' or double press 'Esc' to exit");
            while ((key = Console.ReadKey(true)).Key == ConsoleKey.Enter)
            {
                mover.MoveItems();
                Console.WriteLine();
                Console.WriteLine("To move Items press 'ENTER' or double press 'Esc' to exit");
                if (key.Key == ConsoleKey.Escape) return;
            }
            
                       
         }
       
    }
}
