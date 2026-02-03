using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceVéhicule.Vehicule.Interfaces;

namespace ExerciceVéhicule.Vehicule

{
    internal class Hydravion : Vehicule, IMotorise, IVolant, IFlottant
    {
        public Hydravion(string nom, string marque)
            : base(nom, marque)
        {
        }
        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre ses moteurs.");
        }
        public void Decoller()
        {
            Console.WriteLine($"{Nom} décolle.");
        }
        public void Atterrir()
        {
            Console.WriteLine($"{Nom} atterrit.");
        }
        public void Naviguer()
        {
            Console.WriteLine($"{Nom} navigue sur l'eau.");
        }
    }
}
