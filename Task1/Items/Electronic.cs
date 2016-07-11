using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    class Electronic:Item
    {

        public Electronic(int posX, int posY) : base(posX, posY)
        {
        }

        public void TurnOn() { }
        public void TurnOff() { }
    }
}
