using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFigure.Classe

{
    internal class Carre : Figure
    {
        public double Cote { get; set; }

        public Carre(Point origine, double cote)
            : base(origine)
        {
            Cote = cote;
        }

        public override string ToString()
        {
            return $"Carré | Origine : {Origine} | Côté : {Cote}";
        }
    }
}
