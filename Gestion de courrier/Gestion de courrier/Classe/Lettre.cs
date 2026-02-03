using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_courrier.Classe
{
    public class Lettre
    {
        public User Expediteur { get; set; }
        public User Destinataire { get; set; }
        public string Contenu { get; set; }
        public StatutLettre Statut { get; private set; }

        public Lettre(User expediteur, User destinataire, string contenu)
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
            Statut = StatutLettre.EnAttente;
        }

        public void Envoyer()
        {
            Statut = StatutLettre.Envoyee;
        }

        public void Lire()
        {
            Statut = StatutLettre.Lue;
        }

        public override string ToString()
        {
            return $" LETTRE " +
                   $"Expéditeur : {Expediteur}" +
                   $"Destinataire : {Destinataire}" +
                   $"Contenu : {Contenu}" +
                   $"Statut : {Statut}";
        }
    }
}
