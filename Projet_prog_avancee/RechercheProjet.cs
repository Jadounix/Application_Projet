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
        public RechercheProjet(int nbProjets, List<Projet> listeProjets) : base(nbProjets, listeProjets) { }

        //Fonction qui va gérer la recherche de projet dans l'application
        public void Recherche()
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
                    bool trouve1 = false; //Booleen qui vaut true si un projet correspondant à la recherche a été trouvé, false sinon

                    Console.WriteLine("Quel mot clé voulez-vous recherchez ?");
                    string motCherche = Console.ReadLine().ToLower(); //On place directemment le mot en minuscule

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        for (int j = 0; j < P._listeMotsCles.Count; j++) //Et on cherche tous les mots clés par projet
                        {
                            
                            if (motCherche == P._listeMotsCles[j].ToLower())
                            {
                                Console.WriteLine(P);
                                trouve1 = true;
                            }
                        }
                    }

                    //Dans le cas où il n'y a pas de projets correspondants on affiche ce message
                    if (trouve1 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 2: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Nom");
                    Console.WriteLine("Veuillez entrer le nom du projet que vous cherchez");
                    string nomProjet = Console.ReadLine();

                    bool trouve2 = false; //Booleen qui vaut true si un projet correspondant à la recherche a été trouvé, false sinon

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        //On met en minuscule le nom du projet souhaité et chaque nom de projet présent dans la liste pour la comparaison
                        if (nomProjet.ToLower() == P._nom.ToLower())
                        {
                            //Console.WriteLine("Projet trouvé :");
                            Console.WriteLine(P);
                            trouve2 = true;
                        }
                    }

                    //Dans le cas où il n'y a pas de projets correspondants on affiche ce message
                    if (trouve2 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 3: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Type");
                    Console.WriteLine("Quel type de projet voulez-vous rechercher ?");

                    bool trouve3 = false; 

                    //On affiche tous les types de projets en les faisant correspondre à un numéro
                    int i = 1;
                    foreach (string t in _typeProjets)
                    {
                        Console.WriteLine(i + " : " + t);
                        i++;
                    }

                    //On veut vérifier que la réponse entrée par la personne est bien un nombre, et se situe entre 1 et 4.
                    int typeChoisi = 0;
                    bool continuerDemande3 = true;
                    while (continuerDemande3)
                    {
                        try
                        {
                            typeChoisi = int.Parse(Console.ReadLine());
                            if(typeChoisi>=1 && typeChoisi<=4)
                            {
                                continuerDemande3 = false;
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un nombre entre 1 et 4.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Veuillez entrer un nombre entre 1 et 4.");
                        }
                    }


                    Console.WriteLine("Projet(s) correspondant(s) à votre recherche :");
                    foreach (Projet P in _listeProjets)
                    {
                        if (P._typeProjet == _typeProjets[typeChoisi - 1])
                        {
                            Console.WriteLine(P);
                            trouve3 = true; //Un projet a été trouvé, on change le booléen pour ne pas afficher le message d'erreur
                        }
                    }

                    //Si aucun projet n'est trouvé, on affiche ce message.
                    if (trouve3 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 4: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Année");
                    bool trouve4 = false; //Booleen qui vaut true si un projet correspondant à la recherche a été trouvé, false sinon
                    int anneeMin = 2019;
                    int anneeMax = 2020;

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        if (P._annee < anneeMin)
                        {
                            anneeMin = P._annee;
                        }
                        else if (P._annee > anneeMax)
                        {
                            anneeMax = P._annee;
                        }
                    }

                    int anneeProjet;

                    do
                    {
                        Console.WriteLine("La base de données contient des projets de {0} à {1}.", anneeMin, anneeMax);
                        Console.WriteLine("Veuillez entrer l'année du projet que vous cherchez");
                        anneeProjet = int.Parse(Console.ReadLine());
                    }
                    while (anneeProjet < anneeMin || anneeProjet > anneeMax);

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        if (anneeProjet == P._annee)
                        {
                            //Console.WriteLine("Projet trouvé :");
                            Console.WriteLine(P);
                            trouve4 = true;
                        }
                    }

                    //Dans le cas où il n'y a pas de projets correspondants on affiche ce message
                    if (trouve4 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 5: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Niveau");
                    Console.WriteLine("Quel niveau d'étude vous intéresse ?");
                    bool trouve5 = false; //Booleen qui vaut true si un projet correspondant à la recherche a été trouvé, false sinon


                    //On affiche tous les niveaux des élèves en les faisant correspondre à un numéro
                    int m = 1;
                    while (m <= 3)
                    {
                        Console.WriteLine("{0} : {0}A", m);
                        m++;
                    }

                    //On veut vérifier que la réponse entrée par la personne est bien un nombre, et se situe entre 1 et 3.
                    int niveauChoisi;
                    string niveau = "";
                    bool continuerDemande5 = true;
                    while (continuerDemande5)
                    {
                        try
                        {
                            niveauChoisi = int.Parse(Console.ReadLine());
                            if (niveauChoisi >= 1 && niveauChoisi <= 3)
                            {
                                continuerDemande5 = false;
                                niveau = niveauChoisi.ToString() + "A";
                                
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un nombre entre 1 et 3.");
                            }
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Veuillez entrer un nombre entre 5 et 8.");
                        }
                    }

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        foreach (Intervenant I in P._listeIntervenants)
                        {
                            if (I is Eleve)
                            {
                                Eleve E = (Eleve)I; //On change la classe de l'intervenant I -> il devient un élève sinon on n'a pas accès à sa promo
                                if (E._niveau == niveau)
                                {
                                    Console.WriteLine("Projet(s) trouvé(s) :");
                                    Console.WriteLine(P);
                                    trouve5 = true;
                                }
                            }
                        }
                    }


                    //Dans le cas où il n'y a pas de projets correspondants on affiche ce message
                    if (trouve5 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 6: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Intervenant");
                    Console.WriteLine("Quel est le nom de l'intervenant à rechercher ?");
                    string nomDemande = Console.ReadLine();

                    bool trouve6 = false;

                    foreach (Projet P in _listeProjets) //On parcourt tous les projets
                    {
                        for (int k = 0; k < P._listeIntervenants.Count; k++) //Et on cherche tous les intervenants par projet
                        {
                            //Si le nom ou le prenom de la personne correspond au nom demandé on affiche l'intervenant (en mettant tout en minuscule)
                            if(nomDemande.ToLower() == P._listeIntervenants[k]._nom.ToLower() || nomDemande.ToLower() == P._listeIntervenants[k]._prenom.ToLower())
                            {
                                //Console.WriteLine(P._listeIntervenants[k].ToString());
                                Console.WriteLine(P);
                                trouve6 = true;
                            }
                        }
                    }

                    if(trouve6==false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;


                case 7: //Fonctionne
                    Console.WriteLine("Vous avez choisi le mode de consultation : Promotion");
                    Console.WriteLine("Quelle promotion voulez-vous rechercher ?");

                    bool trouve7 = false;

                    int promoChoisi = 0;

                    bool continuerDemande = true;
                    while (continuerDemande)
                    {
                        try
                        {
                            promoChoisi = int.Parse(Console.ReadLine());
                            continuerDemande = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Veuillez entrer un nombre pour chercher une promotion.");
                        }
                    }

                    //On enregistre les projets correspondants dans cette liste
                    List<Projet> projetAafficher = new List<Projet>();

                    foreach (Projet P in _listeProjets)
                    {
                        foreach (Intervenant I in P._listeIntervenants)
                        {
                            if (I is Eleve)
                            {
                                Eleve E = (Eleve)I; //On change la classe de l'intervenant I -> il devient un élève sinon on n'a pas accès à sa promo
                                if (promoChoisi == E._promotion)
                                {
                                    if (projetAafficher.Contains(P) == false) //On veut éviter les doublons de projets si deux élèves font parti de la même promotion : on regarde si le projet n'est pas déjà dans la liste
                                    {
                                        projetAafficher.Add(P);
                                        trouve7 = true;
                                    }
                                }
                            }
                        }
                    }

                    //Affichage des projets correspondants aux promotions
                    Console.WriteLine("Projet(s) correspondant(s) à votre recherche :");
                    foreach (Projet P in projetAafficher)
                    {
                        Console.WriteLine(P);
                    }

                    if (trouve7 == false)
                    {
                        Console.WriteLine("Aucun résultat ne correspond à votre recherche.");
                    }
                    break;
            }
        }
    }
}
