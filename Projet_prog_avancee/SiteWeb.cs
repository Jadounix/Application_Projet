﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_prog_avancee
{
    class SiteWeb : Livrable
    {
        private string _lien;
        private string _langageUtilise;

        //Constructeur
        public SiteWeb(string dateRendu, string lien, string langageUtilise) : base(dateRendu)
        {
            _lien = lien;
            _langageUtilise = langageUtilise;
        }

        //Méthode ToString
        public override string ToString()
        {
            string chS = "**SITE WEB**\nDate de rendu : " + _dateRendu + " | Langage utilisé : " + _langageUtilise + "\n";
            return chS;
        }
    }
}
