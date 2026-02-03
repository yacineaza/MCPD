using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travailleur_et_Scientifique.Laboratoire

{
    internal class Scientifique : Travailleur
    {
        public string Discipline { get; set; }
        public string TypeScientifique { get; set; }

        public Scientifique(
            string nom,
            string prenom,
            string telephone,
            string email,
            string nomEntreprise,
            string adresseEntreprise,
            string telephoneProfessionnel,
            string discipline,
            string typeScientifique)
            : base(nom, prenom, telephone, email, nomEntreprise, adresseEntreprise, telephoneProfessionnel)
        {
            Discipline = discipline;
            TypeScientifique = typeScientifique;
        }

        public override string ToString()
        {
            return base.ToString() + " " +
                   $"Discipline : {Discipline}" +
                   $"Type de scientifique : {TypeScientifique}";
        }
    }
}
