using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::ExerciceFigure.Interface;

namespace ExerciceFigure.Classe
{
    internal abstract class Figure : IDeplacable
    {
        public Point Origine { get; set; }

        protected Figure(Point origine)
        {
            Origine = origine;
        }

        public virtual void Deplacement(double deplacex, double deplacey)
        {
            Origine.PosX += deplacex;
            Origine.PosY += deplacey;
        }
        public abstract override string ToString();
    }
}
