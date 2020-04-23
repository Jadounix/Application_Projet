using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Simulation
    {
        protected int _nbProjets;
        protected List<Projet> _listeProjets;
        protected List<string> _typeProjets;
        public static Random alea = new Random();

        //Constructeur
        public Simulation(int nbProjets)
        {
            _nbProjets = nbProjets;
            _listeProjets = new List<Projet>();
            _typeProjets = new List<string> { "Transdisciplinaire", "Transpromotion", "Projet informatique", "Projet logiciel" };
        }

        //Constructeur qui va servir pour les classes filles
        public Simulation(int nbProjets, List<Projet> listeProjets)
        {
            _nbProjets = nbProjets;
            _listeProjets = listeProjets;
            _typeProjets = new List<string> { "Transdisciplinaire", "Transpromotion", "Projet informatique", "Projet logiciel" };
        }

        public void CreationProjet()
        {
            //Choix aléatoire du nom du projet parmi quelques propositions
            List<string> nomProjets = new List<string> { "SentiAnt", "ComPlant", "Projet Motus", "Drowsy", "Projet Voltaire", "Burpees", "SpaceInvaders" };

            int nbIntervenant = alea.Next(4,10);
            int nbJours = alea.Next(1,300);
            int annee = alea.Next(2009, 2022);

            //Liste qui contient tous les types de projet possibles. On choisit avec un nombre aléatoire un projet dans la liste
            int noTypeProjet = alea.Next(_typeProjets.Count);
            //On fait la même chose pour les noms de projets
            int noNomProjet = alea.Next(nomProjets.Count);


            for (int k = 0; k < _nbProjets; k++)
            {
                _listeProjets.Add(new Projet(nbIntervenant, nbJours, annee, nomProjets[noNomProjet], _typeProjets[noTypeProjet]));
                //On relance tous les nombre aléatoires
                nbIntervenant = alea.Next(4, 10);
                nbJours = alea.Next(1, 300);
                annee = alea.Next(2009, 2022);
                noTypeProjet = alea.Next(_typeProjets.Count);
                noNomProjet = alea.Next(nomProjets.Count);
            }

            foreach(Projet p in _listeProjets)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public void LancementApplication()
        {
            this.CreationProjet();

            int choix = 0;
            bool continuer = true;

            while (continuer == true)
            {
                Console.WriteLine("Bienvenue dans votre outil de gestion de projet ?\nQue voulez vous faire ?");
                Console.WriteLine("1 : Rechercher un projet\n2 : Ajouter un projet");

                bool continuerDemander = true;
                while (continuerDemander)
                {
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                        if (choix == 1 || choix == 2)
                        {
                            continuerDemander = false;
                        }
                        else
                        {
                            Console.WriteLine("Veuillez entrer 1 pour chercher un projet, 2 pour ajouter un projet.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Veuillez entrer 1 pour chercher un projet, 2 pour ajouter un projet.");
                    }
                }

                if (choix == 1)
                {
                    //Appel à la sous classe
                    RechercheProjet R = new RechercheProjet(_nbProjets, _listeProjets);
                    R.Recherche();
                }
                else //Forcément 2 car on a déjà vérifié au préalable que le chiffre était soit 1 soit 2
                {
                    AjoutProjet A = new AjoutProjet(_nbProjets, _listeProjets);
                    A.AjouterProjet();
                }

                Console.WriteLine("Tapez 1 pour effectuer une nouvelle recherche, un autre chiffre pour quitter l'application.");
                int reponse = int.Parse(Console.ReadLine());
                if (reponse == 1)
                {
                    continuer = true;
                }
                else
                {
                    continuer = false;
                }
            }
            Console.WriteLine("Merci, à bientôt ! ");
        }

    }
}
