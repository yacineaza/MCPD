
using System;

namespace Exo_Classe.Classe
{
    internal class Chaise
    {
        private int _nbPied = 4;
        private string _materiau = "Pierre de Forge";
        private string _couleur = "Sombre";

        public int NbPied
        {
            get => _nbPied;
            set => _nbPied = value;
        }

        public string Materiau
        {
            get => _materiau;
            set => _materiau = value;
        }

        public string Couleur
        {
            get => _couleur;
            set => _couleur = value;
        }

        public Chaise()
        { }

        public Chaise(int nbPied, string materiau, string couleur)
        {NbPied = nbPied;
        Materiau = materiau;
         Couleur = couleur;
        }

        public override string ToString()
        {return $"Chaise : {NbPied} pieds, Matériau : {Materiau}, Couleur : {Couleur}";
        }
    }
}
