using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    [Serializable]
    public class Projet
    {
        public int _nbIntervenants { get; set; }
        public string _nom { get; set; }
        public string _typeProjet { get; set; }
        public int _dureeJours { get; set; }
        public int _annee { get; set; }
        public List<string> _listeMatieres { get; set; }
        public List<string> _listeMotsCles { get; set; }
        public List<Livrable> _listeLivrables { get; set; }
        public List<Intervenant> _listeIntervenants { get; set; }
        public static Random alea = new Random();


        //Constructeur
        public Projet()
        {
            _nbIntervenants = 2;
            _nom = "Projet";
            _typeProjet = "Type";
            _dureeJours = 30;
            _annee = 2020;
            _listeMotsCles = new List<string>(); CreationMotCle();
            _listeMatieres = new List<string> { "Maths", "Informatique", "Anglais", "Psychologie", "UX Design" };
            _listeLivrables = new List<Livrable>(); CreationLivrables();
            _listeIntervenants = new List<Intervenant>(); CreationIntervenants();
        }

        public Projet(int nbIntervenants, int dureeJours, int annee, string nom, string typeProjet)
        {
            _nbIntervenants = nbIntervenants;
            _nom = nom;
            _typeProjet = typeProjet;
            _dureeJours = dureeJours;
            _annee = annee;
            _listeMotsCles = new List<string>(); CreationMotCle();
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
            foreach(string m in _listeMotsCles)
            {
                chS += m+" | ";
            }
            Console.WriteLine();
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


            //Choix aléatoire du prénom de l'intervenant parmi quelques propositions
            List<string> prenomIntervenants = new List<string> { "Michel", "Camille", "Claude", "Dominique", "Ash", "Maxence", "Willow" };
            //On choisit avec un nombre aléatoire un nom dans la liste
            int noPrenomIntervenants = alea.Next(prenomIntervenants.Count);

            //Choix aléatoire du nom de l'intervenant parmi quelques propositions
            List<string> nomIntervenants = new List<string> { "Dupont", "Durant", "Rabii", "Henry", "Horcia", "Roche", "Rouge" };
            //On choisit avec un nombre aléatoire un nom dans la liste
            int noNomIntervenants = alea.Next(nomIntervenants.Count);


            //Permet de choisir une matière aléatoirement dans la liste des matières
            int noMatiere = alea.Next(_listeMatieres.Count);

            //Trouver un moyen de choisir plus aléatoirement les noms des personnes/projets etc..

            for (int i = 0; i < nbEleves; i++)
            {
                _listeIntervenants.Add(new Eleve(2022, "1A", nomIntervenants[noNomIntervenants], prenomIntervenants[noPrenomIntervenants], "chef de projet"));
                noNomIntervenants = alea.Next(nomIntervenants.Count);
                noPrenomIntervenants = alea.Next(prenomIntervenants.Count);
            }

            for (int i = 0; i < nbProf; i++)
            {
                _listeIntervenants.Add(new Professeur(_listeMatieres[noMatiere], nomIntervenants[noNomIntervenants], prenomIntervenants[noPrenomIntervenants], "Tuteur"));
                noMatiere = alea.Next(_listeMatieres.Count);
                noNomIntervenants = alea.Next(nomIntervenants.Count);
                noPrenomIntervenants = alea.Next(prenomIntervenants.Count);
            }

            for (int i = 0; i < nbExte; i++)
            {
                _listeIntervenants.Add(new Exte("Thalès", nomIntervenants[noNomIntervenants], prenomIntervenants[noPrenomIntervenants], "Client"));
                noNomIntervenants = alea.Next(nomIntervenants.Count);
                noPrenomIntervenants = alea.Next(prenomIntervenants.Count);
            }
        }

        //Création de mot-clés pour un projet
        public void CreationMotCle()
        {
            //Liste des mots clés possibles pour les projets générés aléatoirement
            List<string> motCles = new List<string> { "Sciences", "IA", "Cognitique", "Developpement", "Innovation", "Technique" };
            int noMotCle = alea.Next(motCles.Count);

            for (int i = 0; i < alea.Next(2, 4); i++)
            {
                if (_listeMotsCles.Contains(motCles[noMotCle]) == false) //On regarde si le mot clé n'est pas déjà présent pour éviter les doublons
                {
                    _listeMotsCles.Add(motCles[noMotCle]);
                }
                else
                {
                    while(_listeMotsCles.Contains(motCles[noMotCle]) == true) //On repioche le mot tant qu'on ne trouve pas un mot différent
                    {
                        noMotCle = alea.Next(motCles.Count);
                    }
                }
            }
        }
    }
}
