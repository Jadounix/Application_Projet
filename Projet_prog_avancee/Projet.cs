using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    abstract class Projet
    {
        protected int _nbIntervenants { get; set; }
        protected string _nom { get; set; }
        protected string _typeProjet { get; set; }
        protected int _duree { get; set; }
        protected int _annee { get; set; }
        protected List<string> _listeMatieres;
        protected List<string> _listeLivrables;
        protected List<MotCle> _listeMotsCles;
        protected List<Intervenant> _listeIntervenants;

        //Constructeur
        public Projet(int nbIntervenants, int duree, int annee, string nom, string typeProjet)
        {
            _nbIntervenants = nbIntervenants;
            _nom = nom;
            _typeProjet = typeProjet;
            _duree = duree;
            _annee = annee;
            _listeMatieres = new List<string>();
            _listeLivrables = new List<string>();
            _listeMotsCles = new List<MotCle>();
            _listeIntervenants = new List<Intervenant>();
        }

        //Méthode ToString
        public override string ToString()
        {
            return "";
        }
    }
}
