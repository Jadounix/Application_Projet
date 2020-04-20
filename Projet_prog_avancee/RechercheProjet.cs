using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class RechercheProjet : Simulation
    {
        //Constructeur
        public RechercheProjet(int nbProjets) : base(nbProjets) { }

        //Fonction qui va gérer la recherche de projet dans l'application
        public void Recherche()
        {
            bool continuer = true;

            while (continuer == true)
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
                        if (modeChoisi >= 1 && modeChoisi <= 7) //7 correspond au nombre de modes de consultations
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

                switch (modeChoisi) //Point d'avancement le 3 mai <3
                {
                    case 1:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Mots clés");
                        break;

                    case 2:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Nom"); //Fannie
                        break;

                    case 3:
                        Console.WriteLine("Vous avez choisi le mode de consultation : Type"); //Jade

                        Console.WriteLine("Quel type de projet voulez-vous rechercher ?");
                        int i = 1;
                        foreach (string t in _typeProjets)
                        {
                            Console.WriteLine(i + " : " + t);
                            i++;
                        }
                        int typeChoisi = int.Parse(Console.ReadLine()); //à sécuriser

                        Console.WriteLine("Projet(s) correspondant(s) à votre recherche :");
                        foreach (Projet P in _listeProjets)
                        {
                            if (P._typeProjet == _typeProjets[typeChoisi - 1])
                            {
                                Console.WriteLine(P);
                            }
                        }
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
                        Console.WriteLine("Quelle promotion voulez-vous rechercher ?");
                        int promoChoisi = int.Parse(Console.ReadLine()); //à sécuriser

                        if (promoChoisi < 2009 || promoChoisi > 2022)
                        {
                            while (promoChoisi < 2009 || promoChoisi > 2022)
                            {
                                Console.WriteLine("Cette promotion n'est pas disponible");
                                Console.WriteLine("Quelle promotion voulez-vous rechercher ?");
                                promoChoisi = int.Parse(Console.ReadLine()); //à sécuriser
                            }
                        }
                        else
                        {
                            Console.WriteLine("Projet(s) correspondant(s) à votre recherche :");
                            foreach (Projet P in _listeProjets)
                            {
                                foreach (Intervenant I in P._listeIntervenants) //Problème si deux fois la même promo dans 1 projet
                                {
                                    if (I is Eleve)
                                    {
                                        Eleve E = (Eleve)I; //On change la classe de l'intervenant I -> il devient un élève sinon on n'a pas accès à sa promo
                                        if (promoChoisi == E._promotion)
                                        {
                                            Console.WriteLine(P);
                                        }
                                    }
                                }
                            }
                        }
                        break;
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
