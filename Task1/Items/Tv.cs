using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    class Tv:Electronic
    {
        public Tv(int posX, int posY) : base(posX, posY)
        {
            ItemName = "TV";
        }
    }
}
