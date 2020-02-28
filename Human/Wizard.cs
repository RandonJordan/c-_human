using System;
using System.Collections.Generic;

namespace Human
{
    class Wizard : Human
    {
        public Wizard(string wname, int str, int dex, int health) :base(wname, str, 25, dex, 50)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = 5 * Intelligence;
            target.health -= dmg;
            return target.health;


        }
        public void Heal(Human target)
        {
            int healing = 10 * Intelligence;
            healing = target.health;
        }

    }
    




}