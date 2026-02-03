using Abstraction_et_Interfaces.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_et_Interfaces.Classes
{
    public class Guerrier : Personnage, IAttaqueSpeciale
    {
        public Arme Arme { get; set; }

        public Guerrier(string nom, string prenom, int pv, int damage,int initiative, Arme arme)
            : base(nom, prenom, pv, damage,initiative)
        {
            Arme = arme;
        }

        public override void Attaquer(Personnage cible)
        {
            if (!Arme.Utiliser())
            {
                Console.WriteLine($"{Prenom} n'a plus de durabilité sur son arme !");
                return;
            }

            int degats = Damage + Arme.DegatSupplementaire;
            cible.SubirDegats(degats);

            Console.WriteLine($"{Prenom} attaque {cible.Prenom} et inflige {degats} dégâts.");
        }

        public void AttaqueSpeciale(Personnage cible)
        {
            if (!Arme.Utiliser())
            {
                Console.WriteLine($"{Prenom} ne peut pas faire d'attaque spéciale (arme cassée).");
                return;
            }

            int degats = (Damage + Arme.DegatSupplementaire) * 2;
            cible.SubirDegats(degats);

            Console.WriteLine($"{Prenom} lance une ATTAQUE SPÉCIALE sur {cible.Prenom} ({degats} dégâts).");
        }
    }
}    

