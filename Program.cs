using System;
using System.Collections.Generic;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        public int HP
        {
            get { return Health; }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int Str, int Int, int Dex, int health)
        {
            Name = name;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            Health = health;
        }
        public int Attack(Human attacker, Human target)
        {
            Console.WriteLine($"{attacker.Name} winds up for an attack against {target.Name}(HP:{target.Health})!");
            int damage = attacker.Strength * 5;
            target.Health -= damage;
            Console.WriteLine($"{target.Name} takes {damage} points of damage! {target.Name} has {target.Health} HP remaining!");
            return target.Health; 
        }
        static void Main(string[] args)
        {
            Human Bob = new Human("Bob", 5,5,5,100);
            Human Sam = new Human("Sam", 5,5,5,100);
            Bob.Attack(Bob,Sam);
        }
    }
}