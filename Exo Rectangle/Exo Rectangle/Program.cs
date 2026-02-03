using System;
using ExerciceRectangle; 

namespace ExerciceRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        { Rectangle monRectangle = new Rectangle();

            monRectangle.Largeur = 5;
            monRectangle.Hauteur = 3;

            Console.WriteLine("Largeur : " + monRectangle.Largeur);
            Console.WriteLine("Hauteur : " + monRectangle.Hauteur);
            Console.WriteLine("Périmètre : " + monRectangle.Perimetre());
            Console.WriteLine("Surface : " + monRectangle.Surface());

        }
    }
}

