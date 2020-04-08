using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Soutenance : Livrable
    {
        private int _duree;

        //Constructeur
        public Soutenance(string dateRendu, int duree) : base(dateRendu)
        {
            _duree = duree;
        }
    }
}
