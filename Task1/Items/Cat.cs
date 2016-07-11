using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    class Cat:Animal
    {
        public Cat(int posX, int posY):base(posX,posY)
        {
            ItemName = "Cat";
        }
        public override void SaySomething()
        {
            Console.WriteLine("Meow!!!");
        }
    }
}
