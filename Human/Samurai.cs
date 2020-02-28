using System;
using System.Collections.Generic;

namespace Human
{
    class Samurai : Human

    {
        private const int defaultHealth = 200;
        public Samurai(string name, int str, int intel, int dex, int hp) :base(name, str, intel, dex, defaultHealth)        
        {

        }

        public override int Attack(Human target)
        {
            Attack(target);
            if (target.health < 50)
            {
                target.health = 0;
            }
            else{
                Attack(target);
            }
            return target.health;

        }

        public void Meditate()
        {
            health = defaultHealth;
        }



    }




}