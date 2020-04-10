using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class Eleve : Intervenant
    {
        private int _promotion;

        //Constructeur
        public Eleve(int promotion, string nom, string prenom, string role) : base(nom, prenom, role)
        {
            _promotion = promotion;
        }

        public void RechercheParEleve()
        {
            Console.WriteLine("Vous avez choisi le mode de consultation : Recherche par élève.");
            Console.WriteLine("Quel est le nom de l'élève a rechercher ?");
            string nomCherche = Console.ReadLine();
            foreach(Eleve k in liste)
            {
                if (nomCherche == k._nom)
                {
                    //
                }
                else
                {
                    Console.WriteLine("Il n'existe pas de projet correspondant à votre recherche.");
                }

            }
        }
    }
}
