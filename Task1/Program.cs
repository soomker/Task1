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
            Chair chair = new Chair(20, 30);
            Table table = new Table(40, 50);
            Tv tv = new Tv(25, 55);
            Pc pc = new Pc(44, 0);
            Couch couch = new Couch(10, 16);
            Cat cat = new Cat(10, 16);
            Dog dog = new Dog(12, 13);
            List<Item>roomItems = new List<Item> { chair, table, tv, pc, couch, cat, dog };

            TheRoom room = new TheRoom(100,100,roomItems);
            Mover mover = new Mover(room);
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
