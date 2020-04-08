using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    abstract class Livrable
    {
        protected string _dateRendu;

        //Constructeur
        public Livrable(string dateRendu)
        {
            _dateRendu = dateRendu;
        }
    }
}
