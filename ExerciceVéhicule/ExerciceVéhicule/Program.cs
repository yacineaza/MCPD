using ExerciceVéhicule.Vehicule;

namespace ExerciceVéhicule.Vehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("R8", "Audi");
            VoitureHybride hybride = new VoitureHybride("Espace", "Renault");
            Hydravion hydravion = new Hydravion("Catalina", "PBY");

            Console.WriteLine(voiture);
            voiture.Demarrer();
            Console.WriteLine();

            Console.WriteLine(hybride);
            hybride.Demarrer();
            hybride.Recharger();
            Console.WriteLine();

            Console.WriteLine(hydravion);
            hydravion.Demarrer();
            hydravion.Decoller();
            hydravion.Naviguer();
            hydravion.Atterrir();

            
        }
    }
}
