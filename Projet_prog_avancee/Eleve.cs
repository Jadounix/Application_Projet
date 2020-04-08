using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Eleve : Intervenant
    {
        private int _promotion;

        //Constructeur
        public Eleve(int promotion, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _promotion = promotion;
        }
    }
}
