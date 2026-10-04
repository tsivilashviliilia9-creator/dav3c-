using System;
using System.Collections.Generic;
using System.Text;

namespace dav3c_
{
    internal class Mage : GameCharacter
    {
        
            public override void Attack()
            {
                Console.WriteLine("Mage attacks with fireball!");
            }

            public override void Defend()
            {
                Console.WriteLine("Mage casts a protective shield!");

            }
        }
    }
}
