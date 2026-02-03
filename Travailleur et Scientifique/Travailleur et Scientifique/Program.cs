using System;
using Travailleur_et_Scientifique.Laboratoire;

namespace ExerciceTravailleur_et_Scientifique.Laboratoire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Travailleur trav1 = new Travailleur(
                "Enver ",
                "Gortash ",
                "0732172583 ",
                "Enver.Gortash@gmail.com",
                "Élu ",
                "Forteresse du Rocher du Wyrm ",
                "0385123217 "
            );
          
            Console.WriteLine("Travailleur");
            Console.WriteLine(trav1);
            Console.WriteLine();

       
            Scientifique scien1 = new Scientifique(
                "Druide ",
                "Halsin ",
                "0678971632 ",
                "druide.halsin@gmail.com ",
                "Acte 1 ",
                "Bosquet d'émereaude ",
                "0343561219 ",
                "Guérisseur ",
                "Soigneur de la Nature "
            );

            Console.WriteLine("Scientifique");
            Console.WriteLine(scien1);

         
        }
    }
}

