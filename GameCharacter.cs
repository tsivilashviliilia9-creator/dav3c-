using System;
using System.Collections.Generic;
using System.Text;

namespace dav3c_
{
    

        internal abstract class GameCharacter
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Level { get; set; }





            public abstract void Attack();
            public abstract void Defend();



            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}");
            }
        }
    }

