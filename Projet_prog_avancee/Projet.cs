using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Projet
    {
        protected int _nbIntervenants { get; set; }
        protected string _nom { get; set; }
        protected string _typeProjet { get; set; }
        protected int _dureeJours { get; set; }
        protected int _annee { get; set; }
        protected List<string> _listeMatieres;
        protected List<Livrable> _listeLivrables;
        protected List<MotCle> _listeMotsCles;
        protected List<Intervenant> _listeIntervenants;
        public static Random alea = new Random();


        //Constructeur
        public Projet(int nbIntervenants, int dureeJours, int annee, string nom, string typeProjet)
        {
            _nbIntervenants = nbIntervenants;
            _nom = nom;
            _typeProjet = typeProjet;
            _dureeJours = dureeJours;
            _annee = annee;
            _listeLivrables = new List<Livrable>();
            _listeMotsCles = new List<MotCle>();
            _listeIntervenants = new List<Intervenant>();
            _listeMatieres = new List<string>();
        }

        //Méthode ToString
        public override string ToString()
        {
            return "";
        }

        //Création des différentes matières
        public void CreationMatieres()
        {
            _listeMatieres.Add("Maths");
            _listeMatieres.Add("Informatique");
            _listeMatieres.Add("Anglais");
            _listeMatieres.Add("Psychologie");
            _listeMatieres.Add("UX Design");
        }

        //Ajout des intervenants à la liste
        public void CreationIntervenants()
        {
            CreationMatieres();

            int nbEleves = alea.Next(1,_nbIntervenants/2);
            int nbProf = alea.Next(1, (_nbIntervenants - nbEleves) - 1);
            int nbExte = alea.Next(1, nbProf);

            //Trouver un moyen de choisir plus aléatoirement les noms des personnes/projets etc..

            for (int i = 0; i < nbEleves; i++) 
            {
                _listeIntervenants.Add(new Eleve(2022,"Lothaire", "Fannie", "chef de projet"));
            }

            for (int i = 0; i < nbProf; i++)
            {
                int k = 0; //Permet de parcourir la liste des matières pour choisir une matière différente pour chaque prof
                if (k > nbProf) 
                {
                    k = 0;
                }
                _listeIntervenants.Add(new Professeur(_listeMatieres[i], "Lothaire", "Fannie", "chef de projet"));
                k++;
            }

            for (int i = 0; i < nbExte; i++)
            {
                _listeIntervenants.Add(new Exte("Thalès", "Lothaire", "Fannie", "chef de projet"));
            }
        }
    }
}
