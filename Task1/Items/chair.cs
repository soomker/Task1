using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    class Chair:Furniture
    {
        public Chair(int posX, int posY):base(posX, posY)
        {
            ItemName = "Chair";
        }
    }
}
