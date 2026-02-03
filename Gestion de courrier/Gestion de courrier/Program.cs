using Gestion_de_courrier.Classe;

class Program
{
    static void Main(string[] args)
    {
       
        Adresse adresse1 = new Adresse(5, "Salle de boss", "Arbre Sacrée de Miquella ", "33333");
        User user1 = new User("Blade of Miquella", "Malenia", adresse1 );

        Adresse adresse2 = new Adresse(1, "Château de Redmane", "Caelid ", "59100");
        User user2 = new User("le Fléau des Astres", "Radahn", adresse2);

        
        Lettre lettre = new Lettre(user1, user2, "Bonjour Radahn, mon frère j'espère que tu vas bien !");

        Console.WriteLine("Création d'une Lettre :");
        Console.WriteLine(lettre);

        
        lettre.Envoyer();
        Console.WriteLine(" Lettre envoyée !");
        Console.WriteLine($"Statut : {lettre.Statut}");

       
        lettre.Lire();
        Console.WriteLine(" Lettre lue !");
        Console.WriteLine($"Statut : {lettre.Statut}");

     
        Console.WriteLine("Informations complètes de la lettre :");
        Console.WriteLine(lettre);

       
    }
}
