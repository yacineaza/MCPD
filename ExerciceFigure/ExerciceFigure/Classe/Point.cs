using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceFigure.Classe

{
    internal class Point
    {
        public double PosX { get; set; }
        public double PosY { get; set; }

        public Point(double x, double y)
        {
            PosX = x;
            PosY = y;
        }
        public override string ToString()
        {
            return $"({PosX}, {PosY})";
        }
    }
}
