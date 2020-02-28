using System;

namespace Human
{

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        
        public int Health
        {
            get { return health; }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Human player1 = new Human("Great Hero", 10, 10, 20, 1000);
            Human player2 = new Human("AI", 10, 15, 10, 200);
            Samurai kyoto = new Samurai("Kyoto", 10, 15 ,20, 200);
            Ninja silentKill = new Ninja("Silent Killer", 20, 30, 50, 300);

            player1.Attack(player2);
            silentKill.Attack(player1);
            silentKill.Attack(kyoto);
            
            System.Console.WriteLine($"After being attacked by the {player1.Name}, the {player2.Name}'s health is now {player2.Health}");
            System.Console.WriteLine($"You were hit by {silentKill.Name}, your health is now {player1.health}");
            System.Console.WriteLine($"{kyoto.Name} was hit by {silentKill.Name}, your health is now {kyoto.health}");
            kyoto.Meditate();
            System.Console.WriteLine($"{kyoto.Name} health is {kyoto.health}");


        }
    }
}
