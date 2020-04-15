using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Simulation
    {
        private int _nbModeConsultation;
        private int _nbProjets;
        private List<Projet> _listeProjets;
        public static Random alea = new Random();

        //Constructeur
        public Simulation(int nbModeConsultation, int nbProjets)
        {
            _nbModeConsultation = nbModeConsultation;
            _nbProjets = nbProjets;
            _listeProjets = new List<Projet>();
        }

        public void CreationProjet()
        {
            //Choix aléatoire du nom du projet  ???

            int nbIntervenant = alea.Next(4,10);
            int nbJours = alea.Next(1,300);
            int annee = alea.Next(2009, 2022);

            //Liste qui contient tous les types de projet possibles. On choisit avec un nombre aléatoire un projet dans la liste
            List <string> typeProjets = new List<string> {"Transdisciplinaire","Traspromotion","Projet informatique", "Projet logiciel"};
            int noTypeProjet = alea.Next(typeProjets.Count);

            
            for (int k = 0; k < _nbProjets; k++)
            {
                _listeProjets.Add(new Projet(nbIntervenant, nbJours, annee, "ComPlant",typeProjets[noTypeProjet]));
                nbIntervenant = alea.Next(4, 10);
                nbJours = alea.Next(1, 300);
                annee = alea.Next(2009, 2022);
            }

            foreach(Projet p in _listeProjets)
            {
                Console.WriteLine(p.ToString());
            }
        }

        public void Recherche()
        {
            bool continuer = true;
            while(continuer == true)
            {
                Console.WriteLine("Bienvenue dans votre outil de recherche de projets \nQuel mode de consultation voulez-vous utiliser ?");
                Console.WriteLine("1 : Mots clés\n2 : Nom\n3 : Type\n4 : Année\n5 : Niveau\n6 : Intervenant\n7 : Promotion");
                int modeChoisi = int.Parse(Console.ReadLine());
                for (int i = 1; i <= _nbModeConsultation; i++)
                {
                    if (modeChoisi == i)
                    {
                        //RechercheModei()
                        Console.WriteLine("Recherche en fonction du mode");
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer un nombre entre 1 et " + _nbModeConsultation + " pour commencer votre recherche.");
                    }
                }
                Console.WriteLine("Tapez 1 pour effectuer une nouvelle recherche.");
                int reponse = int.Parse(Console.ReadLine());
                if(reponse == 1)
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
