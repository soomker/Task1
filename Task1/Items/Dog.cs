using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    class Dog:Animal
    {
        public Dog (int posX, int posY):base(posX, posY)
        {
            ItemName = "Dog";
        }
        public override void SaySomething()
        {
            Console.WriteLine("Gav, Gav!!!");
        }
    }
}
