using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Bibliotheque_liste_.Classes
{ 
class Livre
{
    public int Numero { get; set; }
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int Exemplaires { get; set; }

    public Livre(int numero, string titre, string auteur, int exemplaires)
    {
        Numero = numero;
        Titre = titre;
        Auteur = auteur;
        Exemplaires = exemplaires;
    }

    public void Afficher()
    {
        Console.WriteLine(
            $"[{Numero}] {Titre} - {Auteur} ({Exemplaires} exemplaires)"
        );
    }
}
}