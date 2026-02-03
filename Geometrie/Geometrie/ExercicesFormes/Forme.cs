using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFormes
{
    internal abstract class Forme
    {
        public string Nom { get; protected set; }


        protected Forme(string nom)
        {
            Nom = nom;
        }
        public abstract double CalculerAire();
        public abstract double CalculerPerimetre();

        public virtual void Infos()
        {
            Console.WriteLine($"Forme : {Nom}");
            Console.WriteLine($"Périmètre : {CalculerPerimetre()}");
            Console.WriteLine($"Aire : {CalculerAire()}");
        }
    }
}
