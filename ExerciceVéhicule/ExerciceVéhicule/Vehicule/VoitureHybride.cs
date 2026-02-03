using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciceVéhicule.Vehicule.Interfaces;

namespace ExerciceVéhicule.Vehicule

{
    internal class VoitureHybride : Vehicule, IMotorise, IElectrique
    {
        public VoitureHybride(string nom, string marque)
            : base(nom, marque)
        {
        }
        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre en mode hybride.");
        }
        public void Recharger()
        {
            Console.WriteLine($"{Nom} est en cours de recharge.");
        }
    }
}
