using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Combat
{
    private static Random random = new Random();

    public static void DemarrerCombat(List<Personnage> personnages)
    {
        Console.WriteLine("Début du combat !\n");

        // Tri par initiative fixe
        personnages = personnages
            .OrderByDescending(p => p.Initiative)
            .ToList();

        Console.WriteLine("Ordre d’initiative :");
        foreach (var p in personnages)
        {
            Console.WriteLine($"- {p.Prenom} ({p.Initiative})");
        }
        Console.WriteLine();

        while (personnages.Count(p => p.EstVivant) > 1)
        {
            foreach (var attaquant in personnages)
            {
                if (!attaquant.EstVivant)
                    continue;

                var cibles = personnages
                    .Where(p => p != attaquant && p.EstVivant)
                    .ToList();

                if (cibles.Count == 0)
                    break;

                var cible = cibles[random.Next(cibles.Count)];

                attaquant.Attaquer(cible);

                if (!cible.EstVivant)
                {
                    Console.WriteLine($"{cible.Prenom} est éliminé !");
                }

               
                if (personnages.Count(p => p.EstVivant) == 1)
                    break;

                Console.WriteLine();
            }

            AfficherEtat(personnages);
        }

        var vainqueur = personnages.First(p => p.EstVivant);
        Console.WriteLine($"{vainqueur.Prenom} remporte le combat !");
    }

    private static void AfficherEtat(List<Personnage> personnages)
    {
        Console.WriteLine("État des personnages :");
        foreach (var p in personnages)
        {
            string etat = p.EstVivant ? "Vivant" : "Mort";
            Console.WriteLine($"{p.Prenom} | PV : {p.Pv} | {etat}");
        }
        Console.WriteLine();
    }
}
