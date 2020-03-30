using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class ProjetProgWeb : ProjetProg
    {
        private List<string> _langagesUtilises;
        //Constructeur
        public ProjetProgWeb(int nbIntervanants, bool sujetLibre, int duree, int annee) : base(nbIntervanants, sujetLibre, duree, annee)
        {
            _langagesUtilises = new List<string>();
        }
    }

}
