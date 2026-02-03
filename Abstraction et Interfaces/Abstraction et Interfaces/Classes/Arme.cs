using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_et_Interfaces.Classes
{
    public class Arme
{
    public string Nom { get; set; }
    public int DegatSupplementaire { get; set; }
    public int Durabilite { get; private set; }

    public Arme(string nom, int degatSupplementaire, int durabilite)
    {
        Nom = nom;
        DegatSupplementaire = degatSupplementaire;
        Durabilite = durabilite;
    }

    public bool Utiliser()
    {
        if (Durabilite <= 0)
            return false;

        Durabilite--;
        return true;
    }

    public override string ToString()
    {
        return $"{Nom} | Bonus dégâts : {DegatSupplementaire} | Durabilité : {Durabilite}";
    }
}
}
