using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    [Serializable]
    public class Eleve : Intervenant
    {
        public int _promotion;
        public string _niveau { get; set; }

        //Constructeur
        public Eleve() : base()//necessaire pour xml
        {
            _promotion = 2022;
            _niveau = "1A";
        }

        public Eleve(int promotion, string niveau, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _promotion = promotion;
            _niveau = niveau;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + " | Promotion : " + _promotion + " | Niveau : " + _niveau +"\n";
            return chS;
        }
    }
}
