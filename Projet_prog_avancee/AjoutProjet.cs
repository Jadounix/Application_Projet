using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class AjoutProjet : Simulation
    {
        //Constructeur
        public AjoutProjet(int nbProjets, List<Projet> listeProjets) : base(nbProjets, listeProjets) { }

        //Fonction qui va gérer l'ajout de projet dans l'application
        public void AjouterProjet()
        {
            Console.WriteLine("--- Bienvenue dans votre outil d'ajout de projet ---");

            /*=======================================================================================*/

            Console.WriteLine("Veuillez entrer le nombre d'intervenants du projet");
            int nbIntervenants = 0;
            bool continuerDemandeNb = true;
            while (continuerDemandeNb)
            {
                try
                {
                    nbIntervenants = int.Parse(Console.ReadLine());
                    continuerDemandeNb = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Veuillez entrer un nombre.");
                }
            }
            
            /*=======================================================================================*/

            Console.WriteLine("Veuillez entrer le nombre de jours du projet");
            int nbJours = 0;
            bool continuerDemandeNbJours = true;
            while (continuerDemandeNbJours)
            {
                try
                {
                    nbJours = int.Parse(Console.ReadLine());
                    continuerDemandeNbJours = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Veuillez entrer un nombre.");
                }
            }

            /*=======================================================================================*/

            Console.WriteLine("Veuillez entrer l'année du projet");
            int annee = 2020;
            bool continuerDemandeAnnee = true;
            while (continuerDemandeAnnee)
            {
                try
                {
                    annee = int.Parse(Console.ReadLine());
                    continuerDemandeAnnee = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Veuillez entrer un nombre.");
                }
            }

            /*=======================================================================================*/

            Console.WriteLine("Veuillez entrer le nom du projet");
            string nomProjet = Console.ReadLine();

            /*=======================================================================================*/

            Console.WriteLine("Veuillez entrer le type du projet");
            //On affiche tous les types de projets en les faisant correspondre à un numéro
            int i = 1;
            foreach (string t in _typeProjets)
            {
                Console.WriteLine(i + " : " + t);
                i++;
            }

            //On veut vérifier que la réponse entrée par la personne est bien un nombre, et se situe entre 1 et 4.
            int typeChoisi = 0;
            bool continuerDemandeType = true;
            while (continuerDemandeType)
            {
                try
                {
                    typeChoisi = int.Parse(Console.ReadLine());
                    if (typeChoisi >= 1 && typeChoisi <= 4)
                    {
                        continuerDemandeType = false;
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
            string typeProjet = _typeProjets[typeChoisi - 1];

            /*=======================================================================================*/

            //Ajout du projet à la liste des projets
            this._listeProjets.Add(new Projet(nbIntervenants, nbJours, annee, nomProjet, typeProjet));

            Console.WriteLine("Votre projet a bien été enregistré !");
        }
    }
}
