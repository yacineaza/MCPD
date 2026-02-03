using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFigure.Classe
{ 
        internal class Triangle : Figure
        {
            public double Base { get; set; }
            public double Hauteur { get; set; }

            public Triangle(Point origine, double b, double h)
                : base(origine)
            {
                Base = b;
                Hauteur = h;
            }

            public override string ToString()
            {
                return $"Triangle isocèle | Origine : {Origine} | Base : {Base} | Hauteur : {Hauteur}";
            }
        }
    }



