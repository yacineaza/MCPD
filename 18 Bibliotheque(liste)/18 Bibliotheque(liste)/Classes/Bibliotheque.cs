using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Bibliotheque_liste_.Classes
{
    using System.Collections.Generic;

    class Bibliotheque
    {
        private List<Livre> livres = new List<Livre>();

        public void AjouterLivre(Livre livre)
        {
            livres.Add(livre);
            Console.WriteLine("Livre ajouté avec succès.");
        }

        public void SupprimerLivre(int numero)
        {
            Livre? livre = livres.Find(l => l.Numero == numero);

            if (livre != null)
            {
                livres.Remove(livre);
                Console.WriteLine("Livre supprimé.");
            }
            else
            {
                Console.WriteLine("Livre introuvable.");
            }
        }

        public void AfficherLivres()
        {
            if (livres.Count == 0)
            {
                Console.WriteLine("Aucun livre dans la bibliothèque.");
                return;
            }

            foreach (Livre livre in livres)
            {
                livre.Afficher();
            }
        }

        public void RechercherParTitre(string titre)
        {
            bool trouve = false;

            foreach (Livre livre in livres)
            {
                if (livre.Titre.ToLower().Contains(titre.ToLower()))
                {
                    livre.Afficher();
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine("Aucun livre trouvé avec ce titre.");
            }
        }

        public void RechercherParAuteur(string auteur)
        {
            bool trouve = false;

            foreach (Livre livre in livres)
            {
                if (livre.Auteur.ToLower().Contains(auteur.ToLower()))
                {
                    livre.Afficher();
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine("Aucun livre trouvé pour cet auteur.");
            }
        }
    }
}