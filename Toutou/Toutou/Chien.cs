using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExerciceChenil
{
    internal class Chien
    {
        private string _nom;
        private string _race;
        private int _age;

        private static string _nomDuChenil = "Les Canins Malin";
        private static int _nbChiens = 0;
        public Chien(string nom, string race, int age)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _nbChiens++;
        }
        public string Nom
        {
            get => _nom; set => _nom = value;
        }
        public string Race
        {
            get => _race; set => _race = value;
        }
        public int Age
        {
            get => _age; set => _age = value;
        }
        public static string NomDuChenil
        {
            get => _nomDuChenil; set => _nomDuChenil = value;
        }

        public static int NbChiens
        {
            get => _nbChiens;
        }
        public override string ToString()
        {
            return $"Chien : {Nom}, Race : {Race}, Âge : {Age} ans, Chenil : {NomDuChenil}";
        }
    }
}
