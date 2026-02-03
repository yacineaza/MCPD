using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Personnage
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Pv { get; protected set; }
    public int Damage { get; protected set; }
    public int Initiative { get; set; }

    public bool EstVivant => Pv > 0;

    protected Personnage(string nom, string prenom, int pv, int damage, int initiative)
    {
        Nom = nom;
        Prenom = prenom;
        Pv = pv;
        Damage = damage;
        Initiative = initiative;
    }

    public abstract void Attaquer(Personnage cible);

    public void SubirDegats(int degats)
    {
        Pv -= degats;
        if (Pv < 0)
            Pv = 0;
    }

    public override string ToString()
    {
        return $"{Prenom} {Nom} | PV : {Pv} | Dégâts : {Damage} | Initiative : {Initiative}";
    }
}
