using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceBanque
{
    internal class CompteBancaire
    {
        public string Titulaire { get; set; }
        public double Solde { get; set; }
        public string Devise { get; set; }

        public CompteBancaire(string titulaire, double soldeInitial, string devise)
        {
            Titulaire = titulaire;
            Solde = soldeInitial;
            Devise = devise;
        }
        public void Deposer(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
                Console.WriteLine($"{montant} {Devise} déposés sur le compte de {Titulaire}.");
            }
        }

        public virtual void Retirer(double montant)
        {
            if (montant <= Solde)
            {
                Solde -= montant;
                Console.WriteLine($"{montant} {Devise} retirés du compte de {Titulaire}.");
            }
            else
            {
                Console.WriteLine("Solde insuffisant.");
            }
        }

        public void AfficherSolde()
        {
            Console.WriteLine($"Solde de {Titulaire} : {Solde} {Devise}");
        }
    }
}
