
class Program
{
    static void Main()
    {
        List<int> temperatures = new List<int>();
        int invalides = 0;
        int saisie;

        Console.Write("Saisissez une température (-999 pour arrêter) : ");
        saisie = int.Parse(Console.ReadLine());

        while (saisie != -999)
        {
            if (saisie >= -50 && saisie <= 50)
            {
                temperatures.Add(saisie);
            }
            else
            {
                invalides++;
            }

            Console.Write("Saisissez une température (-999 pour arrêter) : ");
            saisie = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nRésultats :");
        Console.WriteLine("Nombre de valeurs valides : " + temperatures.Count);
        Console.WriteLine("Nombre de valeurs invalides : " + invalides);

        if (temperatures.Count > 0)
        {
            Console.WriteLine("Température minimale : " + temperatures.Min());
            Console.WriteLine("Température maximale : " + temperatures.Max());
        }
        else
        {
            Console.WriteLine("Aucune température valide saisie.");
        }
    }
}
