using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciceBanque
{
    internal class CompteEpargne : CompteBancaire
    {
       
        public double TauxInteret { get; set; }

       
        public CompteEpargne(string titulaire, double soldeInitial, string devise, double tauxInteret)
            : base(titulaire, soldeInitial, devise)
        {
            TauxInteret = tauxInteret;
        }

        public double CalculerInterets()
        {
            double interets = Solde * TauxInteret;
            Console.WriteLine($"Intérêts générés : {interets} {Devise}");
            return interets;
        }
    }
}
    

