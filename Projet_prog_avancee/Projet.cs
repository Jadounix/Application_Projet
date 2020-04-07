using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    abstract class Projet
    {
        protected int _nbIntervanants { get; set; }
        protected bool _sujetLibre { get; set; }
        protected int _duree { get; set; }
        protected int _annee { get; set; }
        protected List<string> _listeMatieres;
        protected List<string> _listeLivrables;
        protected List<string> _listeMotCle;
        protected List<Intervenant> _listeIntervenant;

        //Constructeur
        public Projet(int nbIntervanants, bool sujetLibre, int duree, int annee)
        {
            _nbIntervanants = nbIntervanants;
            _sujetLibre = sujetLibre;
            _duree = duree;
            _annee = annee;
            _listeMatieres = new List<string>();
            _listeLivrables = new List<string>();
            _listeMotCle = new List<string>();
            _listeIntervenant = new List<Intervenant>();
        }

        //Méthode ToString
        public override string ToString()
        {
            return "";
        }
    }
}
