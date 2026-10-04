using System;
using System.Collections.Generic;
using System.Text;

namespace dav3c_
{
    

        internal class Archer : GameCharacter
        {
            public override void Attack()
            {
                Console.WriteLine("Archer attacks with bow!");
            }

            public override void Defend()
            {
                Console.WriteLine("Archer dodges the attack");
            }
        }
    }

