using Abstraction_et_Interfaces.Classes;

class Program
{
    static void Main(string[] args)
    {
        Arme epee = new Arme("Épée", 5, 3);
        Arme baton = new Arme("Bâton magique", 3, 10);
        Arme lameMagique = new Arme("Lame magique", 4, 12);

        Guerrier guerrier = new Guerrier(
            "*", " Stark",
            pv: 100, damage: 10,
            initiative: 22,
            arme: epee
        );

        Mage mage = new Mage(
            "*", "Fern",
            pv: 80, damage: 8,
            initiative: 20,
            arme: baton
        );

        GuerrierMage guerrierMage = new GuerrierMage(
            "La Fossoyeuse", "Frieren",
            pv: 90, damage: 9,
            initiative: 23,
            arme: lameMagique
        );

        List<Personnage> personnages = new List<Personnage>
        {
            guerrier,
            mage,
            guerrierMage
        };

        Console.WriteLine( "Personnages en jeu :\n");
        personnages.ForEach(p => Console.WriteLine(p));
        Console.WriteLine();

        Combat.DemarrerCombat(personnages);

       
    }
}
