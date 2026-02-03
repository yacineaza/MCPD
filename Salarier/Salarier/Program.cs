using System;
using ExerciceSalarie;

namespace ExerciceSalarie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTION DES SALARIES");

            Salarie s1 = new Salarie("Chloé", "Secrétaire d'état", 24000);
            Salarie s2 = new Salarie("Pierre", "Ministre des sports", 30000);
            Salarie s3 = new Salarie("Sam", "Premier Ministre", 36000);

            s1.AfficherSalaire();
            s2.AfficherSalaire();
            s3.AfficherSalaire();

            Console.WriteLine( $"Le montant total des salaires des {Salarie.NombreEmployes()} employés est de {Salarie.SalaireTotal()} euros.");

            Salarie.ResetEmployes();

            Console.WriteLine( $"Il y a {Salarie.NombreEmployes()} employé dans l'entreprise (après reset)");
        }
    }
}
