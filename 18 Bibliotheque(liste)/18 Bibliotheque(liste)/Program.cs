using _18_Bibliotheque_liste_.Classes;
using System;


class Program
{
    static void Main()
    {
        Bibliotheque bibliotheque = new Bibliotheque();
        int choix;

        do
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Ajouter un livre");
            Console.WriteLine("2 - Afficher tous les livres");
            Console.WriteLine("3 - Trouver un livre par son titre");
            Console.WriteLine("4 - Trouver un livre par son auteur");
            Console.WriteLine("0 - Quitter");
            Console.Write("Votre choix : ");

            choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.Write("Numéro : ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.Write("Titre : ");
                    string titre = Console.ReadLine();

                    Console.Write("Auteur : ");
                    string auteur = Console.ReadLine();

                    Console.Write("Nombre d'exemplaires : ");
                    int ex = int.Parse(Console.ReadLine());

                    bibliotheque.AjouterLivre(
                        new Livre(numero, titre, auteur, ex)
                    );

                    Console.WriteLine("Livre ajouté");
                    break;

                case 2:
                    bibliotheque.AfficherLivres();
                    break;

                case 3:
                    Console.Write("Titre recherché : ");
                    string t = Console.ReadLine();
                    bibliotheque.RechercherParTitre(t);
                    break;

                case 4:
                    Console.Write("Auteur recherché : ");
                    string a = Console.ReadLine();
                    bibliotheque.RechercherParAuteur(a);
                    break;

                case 0:
                    Console.WriteLine("Au Revoir");
                    break;

                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

        } while (choix != 0);
    }
}
