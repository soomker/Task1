using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Items
{
    
        public class Animal : Item
        {
            string animalSpeech;
            public Animal(string name, int posX, int posY, string speech)
                : base(name, posX, posY)
            {
                animalSpeech = speech;
            }
             
            public void SaySomething ()
            {
                Console.Write(animalSpeech);
            }
        }
    
}
