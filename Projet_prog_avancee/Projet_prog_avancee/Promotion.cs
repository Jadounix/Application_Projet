using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Promotion
    {
        private int _annee;
        protected List<Intervenant> _ListeIntervenants;
        protected List<Projet> _ListeProjet;

        //Constructeur
        public Promotion(int annee)
        {
            _annee = annee;
            _ListeIntervenants = new List<Intervenant>();
            _ListeProjet = new List<Projet>();
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Promotion " + _annee + " : \nListe des intervenants";
            foreach(Intervenant i in _ListeIntervenants)
            {
                chS += i.ToString()+"/n";
            }
            chS += "Liste des projets : /n";
            foreach (Projet p in _ListeProjet)
            {
                chS += p.ToString() + "/n";
            }
            return chS;
        }
    }
}
