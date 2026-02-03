using Abstraction_et_Interfaces.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_et_Interfaces.Classes
{
    public class Mage : Personnage, Imagie
    {
        public Arme Arme { get; set; }

        public Mage(string nom, string prenom, int pv, int damage, int initiative, Arme arme)
            : base(nom, prenom, pv, damage, initiative)
        {
            Arme = arme;
        }

        public override void Attaquer(Personnage cible)
        {
            if (!Arme.Utiliser())
            {
                Console.WriteLine($"{Prenom} n'a plus de durabilité sur son arme magique !");
                return;
            }

            int degats = Damage + Arme.DegatSupplementaire;
            cible.SubirDegats(degats);

            Console.WriteLine($"{Prenom} attaque avec son bâton sur {cible.Prenom} et inflige {degats} dégâts.");
        }

        public void LancerSort(Personnage cible)
        {
            int degats = Damage * 3;
            cible.SubirDegats(degats);

            Console.WriteLine($"{Prenom} lance un SORT sur {cible.Prenom} ({degats} dégâts magiques).");
        }
    }
}