using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Simulation
    {
        private int _nbProjets;
        private List<Projet> _listeProjets;
        public static Random alea = new Random();

        //Constructeur
        public Simulation(int nbProjets)
        {
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

        //Fonction qui va gérer l'ajout de projet dans l'application
        public void AjoutProjet() //Faire les try et catch
        {
            Console.WriteLine("--- Bienvenue dans votre outil d'ajout de projet ---");

            Console.WriteLine("Veuillez entrer le nombre d'intervenants du projet");
            int nbIntervenants = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer le nombre de jours du projet");
            int nbJours = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer l'année du projet");
            int annee = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez entrer le nom du projet");
            string nomProjet = Console.ReadLine();

            Console.WriteLine("Veuillez entrer le type du projet");
            string typeProjet = Console.ReadLine();

            this._listeProjets.Add(new Projet(nbIntervenants, nbJours, annee, nomProjet, typeProjet));

            Console.WriteLine("Votre projet a bien été enregistré !");

        }

        //Fonction qui va gérer la recherche de projet dans l'application
        public void Recherche()
        {
            bool continuer = true;

            while(continuer == true)
            {
                Console.WriteLine("--- Bienvenue dans votre outil de recherche de projets --- \nQuel mode de consultation voulez-vous utiliser ?");
                Console.WriteLine("1 : Mots clés\n2 : Nom\n3 : Type\n4 : Année\n5 : Niveau\n6 : Intervenant\n7 : Promotion");

                int modeChoisi = 0;

                bool continuerDemander = true;
                while (continuerDemander)
                {
                    try
                    {
                        modeChoisi = int.Parse(Console.ReadLine());
                        if(modeChoisi>=1 && modeChoisi<7) //7 correspond au nombre de modes de consultations
                        {
                            continuerDemander = false;
                        }
                        else
                        {
                            Console.WriteLine("Veuillez entrer un nombre entre 1 et 7 pour commencer votre recherche.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Veuillez entrer un nombre entre 1 et 7 pour commencer votre recherche.");
                    }
                }

                switch(modeChoisi) //Point d'avancement le 3 mai <3
                {
                    case 1:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Mots clés");
                        break;
                    case 2:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Nom"); //Fannie
                        break;
                    case 3:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Type"); //Jade
                        break;
                    case 4:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Année"); //Fannie
                        break;
                    case 5:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Niveau"); //Fannie
                        break;
                    case 6:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Intervenant"); //Jade
                        break;
                    case 7:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Promotion"); //Jade
                        break;
                }

                Console.WriteLine("Tapez 1 pour effectuer une nouvelle recherche, un autre chiffre pour quitter l'application.");
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

        public void LancementApplication()
        {
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
                Recherche();
            }
            else
            {
                AjoutProjet();
            }
        }

    }
}
