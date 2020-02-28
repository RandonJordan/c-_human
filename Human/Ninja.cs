using System;
using System.Collections.Generic;

namespace Human
{

    class Ninja : Human
    {   
        public Ninja(string person, int str, int intel, int dex, int hp) :base(person, str, intel, 175, hp)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = 5*Dexterity;
            target.health -= dmg;
            return target.health;
        }


        public void Steal(Human target)
        {
            int dmg = 5 - target.health;
            target.health -= dmg;
            health += 5;
        }
       
    }



}