using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceVéhicule.Vehicule.Interfaces;

namespace ExerciceVéhicule.Vehicule
{
    internal class Voiture : Vehicule, IMotorise
    {
        public Voiture(string nom, string marque)
            : base(nom, marque)
        {
        }
        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre.");
        }
    }
}

