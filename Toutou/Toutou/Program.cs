using System;
using ExerciceChenil;

namespace ExerciceChenil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien chien1 = new Chien("Bob", "Berger Allemand", 5);
            Chien chien2 = new Chien("Marny", "Labrador", 3);

            chien1.Nom = "Marley";
            chien1.Age = 6;

            Console.WriteLine(chien1);
            Console.WriteLine(chien2);

            Console.WriteLine($"Nombre total de chiens : {Chien.NbChiens}");

            Chien.NomDuChenil = "Chenil du Nord";

            Console.WriteLine("Après changement du nom du chenil :");
            Console.WriteLine(chien1);
            Console.WriteLine(chien2);

        }
    }
}
