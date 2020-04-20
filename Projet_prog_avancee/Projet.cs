using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Projet
    {
        public int _nbIntervenants { get; set; }
        public string _nom { get; set; }
        public string _typeProjet { get; set; }
        public int _dureeJours { get; set; }
        public int _annee { get; set; }
        public List<string> _listeMatieres;
        public List<Livrable> _listeLivrables;
        public List<MotCle> _listeMotsCles;
        public List<Intervenant> _listeIntervenants;
        public static Random alea = new Random();


        //Constructeur
        public Projet(int nbIntervenants, int dureeJours, int annee, string nom, string typeProjet)
        {
            _nbIntervenants = nbIntervenants;
            _nom = nom;
            _typeProjet = typeProjet;
            _dureeJours = dureeJours;
            _annee = annee;
            _listeMotsCles = new List<MotCle>();
            _listeMatieres = new List<string> { "Maths", "Informatique", "Anglais", "Psychologie", "UX Design"};
            _listeLivrables = new List<Livrable>(); CreationLivrables();
            _listeIntervenants = new List<Intervenant>(); CreationIntervenants();
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Projet : " + _nom + "\nType : " + _typeProjet + "\nDuree : " + _dureeJours + " jours\nAnnée : " + _annee + "\n";

            chS += "Les intervenants du projets : \n";
            foreach(Intervenant i in _listeIntervenants)
            {
                chS += i.ToString();
            }

            chS += "Les livrables du projet : \n";
            foreach (Livrable l in _listeLivrables)
            {
                chS += l.ToString();
            }

            chS += "Les mots clé projet : \n";
            foreach(MotCle m in _listeMotsCles)
            {
                chS += m.ToString();
            }
            return chS;
        }


        //Création de livrables pour un projet
        public void CreationLivrables()
        {
            for(int i = 0; i < alea.Next(0, 3); i++)
            {
                _listeLivrables.Add(new Soutenance("2 juin",10));
            }

            for (int i = 0; i < alea.Next(0, 1); i++)
            {
                _listeLivrables.Add(new SiteWeb("5 mai", "QuizCeption.com","C#"));
            }

            for (int i = 0; i < alea.Next(1, 2); i++)
            {
                _listeLivrables.Add(new Rapport("2 avril", 12));
            }
        }

        //Création des intervenants pour un projet
        public void CreationIntervenants()
        {
            int nbEleves = alea.Next(1, _nbIntervenants / 2);
            int nbProf = alea.Next(1, (_nbIntervenants - nbEleves) - 1);
            int nbExte = alea.Next(0, nbProf);

            //Permet de choisir une matière aléatoirement dans la liste des matières
            int noMatiere = alea.Next(_listeMatieres.Count);

            //Trouver un moyen de choisir plus aléatoirement les noms des personnes/projets etc..

            for (int i = 0; i < nbEleves; i++)
            {
                _listeIntervenants.Add(new Eleve(2022, "Lothaire", "Fannie", "chef de projet"));
            }

            for (int i = 0; i < nbProf; i++)
            {
                _listeIntervenants.Add(new Professeur(_listeMatieres[noMatiere], "Damich", "Paulette", "Tuteur"));
                noMatiere = alea.Next(_listeMatieres.Count);
            }

            for (int i = 0; i < nbExte; i++)
            {
                _listeIntervenants.Add(new Exte("Thalès", "Blendue", "Elisa", "Client"));
            }
        }
    }
}
