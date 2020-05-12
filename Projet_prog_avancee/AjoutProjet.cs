using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Projet_prog_avancee
{
    // https://docs.microsoft.com/fr-fr/dotnet/standard/serialization/examples-of-xml-serialization
    // https://docs.microsoft.com/fr-fr/dotnet/api/system.xml.serialization.xmlserializer?view=netcore-3.1
    // https://docs.microsoft.com/fr-fr/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1

    // création d'une classe
    public class Objet
    {
        public int Attribut1 { get; set; }
        public int Attribut2 { get; set; }
        public int Attribut3 { get; set; }
        public string Attribut4 { get; set; }
        public string Attribut5 { get; set; }

        public Objet()
        {
            Attribut1 = 0;
            Attribut2 = 0;
            Attribut3 = 0;
            Attribut4 = "";
            Attribut5 = "";
        }

        public Objet(int Attri1, int Attri2, int Attri3, string Attri4, string Attri5)
        {
            Attribut1 = Attri1;
            Attribut2 = Attri2;
            Attribut3 = Attri3;
            Attribut4 = Attri4;
            Attribut5 = Attri5;
        }
    }

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


                    //// on le transforme en xml
                    //string xmlIntervenants = XML.ConvertToXml(nbIntervenants);

                    //// On écrit dans un fichier
                    //File.WriteAllText("test.xml", xmlIntervenants);


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

                    //// on le transforme en xml
                    //string xmlJours = XML.ConvertToXml(nbJours);

                    //// On écrit dans un fichier
                    //File.WriteAllText("test.xml", xmlJours);

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

                    //// on le transforme en xml
                    //string xmlAnnee = XML.ConvertToXml(annee);

                    //// On écrit dans un fichier
                    //File.WriteAllText("test.xml", xmlAnnee);

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

            //// on le transforme en xml
            //string xmlNom = XML.ConvertToXml(nomProjet);

            //// On écrit dans un fichier
            //File.WriteAllText("test.xml", xmlNom);

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

                    //// on le transforme en xml
                    //string xmlOutput = XML.ConvertToXml(typeChoisi);

                    //// On écrit dans un fichier
                    //File.WriteAllText("test.xml", xmlOutput);

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

            //Objet ProjetSauv = new Objet(nbIntervenants, nbJours, annee, nomProjet, typeProjet);
            //Ajout du projet à la liste des projets
            this._listeProjets.Add(new Projet(nbIntervenants, nbJours, annee, nomProjet, typeProjet));

            Console.WriteLine("Votre projet a bien été enregistré !");
        }
    }

    public class XML
    {
        public static void Test1()
        {
            // on crée un objet
            var projetTest1 = new Objet();
            var projetTest2 = new Objet();
            var projetTest3 = new Objet();

            List<Objet> maListe = new List<Objet>() { projetTest1, projetTest2, projetTest3 };

            //// on le transforme en xml
            //string xmlOutput = XML.ConvertToXml(maListe);

            //// On écrit dans un fichier
            //File.WriteAllText("test.xml", xmlOutput);



            // on récupère ce qui est écrit dans le fichier
            string xmlInput = File.ReadAllText("test.xml");

            // on "déserialize" le contenu du fichier
            List<Objet> fdtqf = ConvertFromXml<List<Objet>>(xmlInput);
        }

        public static void Test2(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));

            // on créé un DataSet; ajout de table, colonne, et dix lignes.
            DataSet ds = new DataSet("myDataSet");
            DataTable t = new DataTable("table1");
            DataColumn c = new DataColumn("thing");
            t.Columns.Add(c);
            ds.Tables.Add(t);
            DataRow r;
            for (int i = 0; i < 10; i++)
            {
                r = t.NewRow();
                r[0] = "Thing " + i;
                t.Rows.Add(r);
            }
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, ds);
            writer.Close();
        }

        // https://stackoverflow.com/a/2670205
        public static T ConvertFromXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new StringReader(xml));
        }

        // https://stackoverflow.com/a/16853268
        // L'utilisation du T ici signifie que l'on utilise
        // un type générique mais que l'on veut quand même
        // savoir ce que c'est
        public static string ConvertToXml<T>(T instance)
        {
            // on vérifie que l'objet est pas null
            if (instance == null)
            {
                return string.Empty;
            }

            try
            {
                // création de l'outil qui va se charger de transformer
                // l'instance de l'objet et XML
                var xmlserializer = new XmlSerializer(typeof(T));

                // Création d'un outil qui permet d'écrire des données dans une
                // chaîne de caractères
                var stringWriter = new StringWriter();

                // le "using" ici va déclarer une variable "writer" qui ne sera
                // accessible que entre les accolades. Une fois que le programme
                // sort de ces accolades, il va détruire la variable pour libérer
                // toutes les ressources auxquelle elle faisait appel
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    // instruction principale ici, l'instance de l'objet est convertie
                    // en une chaine de caractère au format XML
                    xmlserializer.Serialize(writer, instance);

                    // On renvoit la chaine de caractère XML créée.
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                // Si la création de la chaine de caractère a échouée et
                // renvoyé la moindre erreur (utilisation du type général
                // Exception qui regroupe toutes les erreurs possibles),
                // alors on envoit une nouvelle erreur qui dit : 
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
