using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVéhicule.Vehicule

{
    internal abstract class Vehicule
    {
        public string Nom { get; set; }
        public string Marque { get; set; }

        protected Vehicule(string nom, string marque)
        {
            Nom = nom;
            Marque = marque;
        }
        public override string ToString()
        {
            return $"Véhicule : {Nom} | Marque : {Marque}";
        }
    }
}
