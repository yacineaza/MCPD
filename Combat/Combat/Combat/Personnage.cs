using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExerciceCombat
{
    internal class Personnage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Personnage(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void Attack(Personnage adversaire)
        {
            Console.WriteLine($"{Name} a attaqué {adversaire.Name}");
            adversaire.Health -= Damage;

         
            if (adversaire.Health < 0)
                adversaire.Health = 0;

            if (adversaire.IsAlive())
                Console.WriteLine($"Il reste {adversaire.Health}pv à {adversaire.Name}");
            else
                Console.WriteLine($"{adversaire.Name} disparait.");
        }
        public bool IsAlive()
        {
            return Health > 0;
        }
        ~Personnage()
        {
            Console.WriteLine($"{Name} disparait.");
        }
    }
}

