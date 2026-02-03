using System;
using Exo_Classe.Classe;

namespace Exo_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Chaise chaise1 = new Chaise();
         Chaise chaise2 = new Chaise(3, "Fer", "Mat");
         Chaise chaise3 = new Chaise(4, "Bois", "Marron");
         Console.WriteLine(chaise1);
         Console.WriteLine(chaise2);
         Console.WriteLine(chaise3);
      }
    }
}
