using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

// https://docs.microsoft.com/fr-fr/dotnet/standard/serialization/examples-of-xml-serialization
// https://docs.microsoft.com/fr-fr/dotnet/api/system.xml.serialization.xmlserializer?view=netcore-3.1
// https://docs.microsoft.com/fr-fr/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netcore-3.1

// création d'une classe
public class Objet
{
    public string Attribut1 { get; set; }
    public string Attribut2 { get; set; }

    private string Attribut3 { get; set; }
    private int Attribut4;

    public Objet()
    {
        Attribut1 = "Projet";
        Attribut2 = "Intervenant";
        Attribut3 = "bonsoir";
        Attribut4 = 15;
    }
}

public class XML_test
{
    public static void Test1()
    {
        // on crée un objet
        var projetTest1 = new Objet();
        var projetTest2 = new Objet();
        var projetTest3 = new Objet();

        List<Objet> maListe = new List<Objet>() { projetTest1, projetTest2, projetTest3 };

        // on le transforme en xml
        string xmlOutput = XML_test.ConvertToXml(maListe);

        // On écrit dans un fichier
        File.WriteAllText("test.xml", xmlOutput);



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
        catch (NotImplementedException ex)
        {
            // Si la création de la chaine de caractère a échouée et
            // renvoyé la moindre erreur (utilisation du type général
            // Exception qui regroupe toutes les erreurs possibles),
            // alors on envoit une nouvelle erreur qui dit : 
            throw new Exception("An error occurred", ex);
        }
    }
}
