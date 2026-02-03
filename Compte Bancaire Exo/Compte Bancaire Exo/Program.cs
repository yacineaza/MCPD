using System;

namespace ExerciceBanque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COMPTE BANCAIRE");

            CompteBancaire compte = new CompteBancaire("Maxim", 1000, "Euros");
            compte.Deposer(500);
            compte.Retirer(200);
            compte.AfficherSolde();

            Console.WriteLine("COMPTE EPARGNE");

            CompteEpargne compteEpargne = new CompteEpargne("Juan", 2000, "Euros", 0.07);
            compteEpargne.Deposer(1200);
            compteEpargne.CalculerInterets();
            compteEpargne.AfficherSolde();

            Console.WriteLine("COMPTE COURANT");

            CompteCourant compteCourant = new CompteCourant("Tom", 500, "Euros", 600);
            compteCourant.Deposer(400);
            compteCourant.RetirerAvecDecouvert(1500);
            compteCourant.AfficherSolde();

        }
    }
}
