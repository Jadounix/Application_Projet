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
        public void AjouterProjet() //Faire les try et catch
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
    }
}
