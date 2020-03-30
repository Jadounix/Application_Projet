using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class ProjetTransdi : Projet
    {
        private bool _continuite;

        //Constructeur
        public ProjetTransdi(bool continuite, int nbIntervanants, bool sujetLibre, int duree, int annee): base(nbIntervanants, sujetLibre, duree, annee)
        {
            _continuite = continuite;
        }
    }
}
