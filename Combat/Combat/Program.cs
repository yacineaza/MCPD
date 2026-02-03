using System;
using ExerciceCombat;

namespace ExerciceCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEBUT");

            Personnage p1 = new Personnage("Gimli", 50, 25);
            Personnage p2 = new Personnage("Legolas", 150, 12); 
            while (p1.IsAlive() && p2.IsAlive())
            {
                p1.Attack(p2);

                if (!p2.IsAlive())
                {Console.WriteLine($"{p1.Name} gagne le combat !!!");
                break;
                }
                p2.Attack(p1);

                if (!p1.IsAlive())
                {Console.WriteLine($"{p2.Name} gagne le combat !!!");
                break;
                }
            }
            Console.WriteLine("FIN DU COMBAT");

           

        }
    }
}
