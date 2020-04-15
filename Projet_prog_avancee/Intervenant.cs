using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    abstract class Intervenant
    {
        protected string _nom { get; set; }
        protected string _prenom { get; set; }
        protected string _role { get; set; }

        //Constructeur
        public Intervenant(string nom, string prenom, string role)
        {
            _nom = nom;
            _prenom = prenom;
            _role = role;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "Nom : " + _nom + " | Prénom : " + _prenom + " | Rôle : " + _role + "\n";
            return chS;
        }

        public void RechercheParIntervenant()
        {
            Console.WriteLine("Quel est le type d'intervenant recherché ?");
            Console.WriteLine("1 : Elève\n2 : Professeur\n3 : Personne extérieur");
            int typeChoisi = int.Parse(Console.ReadLine());

            if (typeChoisi == 1)
            {
                //Appel à eleve
            }
            else
            {
                if(typeChoisi == 2)
                {
                    //Appel à prof
                }
                else
                {
                    if(typeChoisi == 3)
                    {
                        //Appel à exte
                    }
                    else
                    {
                        Console.WriteLine("Veuillez choisir un nombre entre 1 et 3 pour poursuivre la recherche");
                    }
                }
            }
        }

    }
}
