using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExerciceSalarie
{
    internal class Salarie
    {
        private string _nom;
        private string _service;
        private double _salaire;

        private static int _nbEmployes = 0;
        private static double _salaireTotal = 0;
        public Salarie(string nom, string service, double salaire)
        {
            _nom = nom;
            _service = service;
            _salaire = salaire;
            _nbEmployes++;
            _salaireTotal += salaire;
        }
        public string Nom
        {
            get => _nom;
            set => _nom = value;
        }
        public string Service
        {
            get => _service;
            set => _service = value;
        }
        public double Salaire
        {
            get => _salaire;
            set => _salaire = value;
        }
        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros.");
        }
        public static int NombreEmployes()
        {
            return _nbEmployes;
        }
        public static double SalaireTotal()
        {
            return _salaireTotal;
        }
        public static void ResetEmployes()
        {
            _nbEmployes = 0;
            _salaireTotal = 0;
        }
    }
}

