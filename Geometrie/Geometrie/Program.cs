
namespace ExerciceFormes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme rectangle = new Rectangle(17, 12);
            Forme cercle = new Cercle(20);
            rectangle.Infos();
            cercle.Infos();
        }
    }
}
