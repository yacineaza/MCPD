using ExerciceFigure.Classe;
using System;

namespace ExerciceFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure carre = new Carre(new Point(4, 3), 5);
            Figure rectangle = new Rectangle(new Point(8, 3), 7, 4);
            Figure triangle = new Triangle(new Point(-8, 3), 7, 2);

            Console.WriteLine("Figures Initiales");
            Console.WriteLine(carre);
            Console.WriteLine(rectangle);
            Console.WriteLine(triangle);

            Console.WriteLine("Déplacement Des Figures");
            carre.Deplacement(2, 2);
            rectangle.Deplacement(-1, 1);
            triangle.Deplacement(3, -2);

           
            Console.WriteLine("Figures Après Déplacement");
            Console.WriteLine(carre);
            Console.WriteLine(rectangle);
            Console.WriteLine(triangle);

        }
    }
}
