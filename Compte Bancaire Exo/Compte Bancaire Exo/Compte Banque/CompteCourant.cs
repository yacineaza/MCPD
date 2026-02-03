using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciceBanque
{
    internal class CompteCourant : CompteBancaire
    {
        public double DecouvertAutorise { get; set; }

        public CompteCourant(string titulaire, double soldeInitial, string devise, double decouvertAutorise)
            : base(titulaire, soldeInitial, devise)
        {
            DecouvertAutorise = decouvertAutorise;
        }

        public void RetirerAvecDecouvert(double montant)
        {
            if (Solde - montant >= -DecouvertAutorise)
            {
                Solde -= montant;
                Console.WriteLine($"{montant} {Devise} retirés avec découvert autorisé.");
            }
            else
            {
                Console.WriteLine("Dépassement du découvert autorisé.");
            }
        }
    }
}
