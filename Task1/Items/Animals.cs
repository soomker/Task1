using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    
        public abstract class Animal : Item
        {
            
            public Animal(int posX, int posY)
                : base(posX, posY)
            {
            }

       public  abstract void SaySomething();
            
        }
    
}
