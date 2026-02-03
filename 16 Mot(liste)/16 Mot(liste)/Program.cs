
class Program
{
    static void Main()
    {
        List<string> mots = new List<string>();
        string saisie;

        Console.Write("Saisissez un mot (\"stop au 7338\" pour terminer) : ");
        saisie = Console.ReadLine();

        while (saisie != "stop au 7338")
        {
            mots.Add(saisie);

            Console.Write("Saisissez un mot (\"stop au 7338\" pour terminer) : ");
            saisie = Console.ReadLine();
        }

        Console.WriteLine("Nombre total de mots saisis : " + mots.Count);

        Console.WriteLine("Liste des mots :");
        foreach (string mot in mots)
        {
            Console.WriteLine(mot);
        }
    }
}
