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

        public void CreationProjet()
        {
            //Choix aléatoire du nom du projet  ???

            int nbIntervenant = alea.Next(4,10);
            int nbJours = alea.Next(1,300);
            int annee = alea.Next(2009, 2022);

            //Liste qui contient tous les types de projet possibles. On choisit avec un nombre aléatoire un projet dans la liste
            int noTypeProjet = alea.Next(_typeProjets.Count);

            
            for (int k = 0; k < _nbProjets; k++)
            {
                _listeProjets.Add(new Projet(nbIntervenant, nbJours, annee, "ComPlant",_typeProjets[noTypeProjet]));
                nbIntervenant = alea.Next(4, 10);
                nbJours = alea.Next(1, 300);
                annee = alea.Next(2009, 2022);
                noTypeProjet = alea.Next(_typeProjets.Count);
            }

            foreach(Projet p in _listeProjets)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public void LancementApplication()
        {
            this.CreationProjet();

            Console.WriteLine("Bienvenue dans votre outil de gestion de projet ?\nQue voulez vous faire ?");
            Console.WriteLine("1 : Rechercher un projet\n2 : Ajouter un projet");

            int choix = 0;

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

            if(choix==1)
            {
                //Appel à la sous classe
                RechercheProjet R = new RechercheProjet(_nbProjets);
                R.Recherche();
            }
            else
            {
                AjoutProjet A = new AjoutProjet(_nbProjets);
                A.AjouterProjet();
            }
        }

    }
}
