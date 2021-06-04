using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    public class Parcelles
    {
        #region Attribut
        private int TailleP;
        private char nomP;
        private List<Unité> Parcelle;
        #endregion

        #region Constructeurs
        public Parcelles(char nP)
        {
            nomP = nP;
            Parcelle = new List<Unité>();
        }
        #endregion

        #region Méthodes
        /*
         int NbrP()
         * {
         * 
         * }

        int TailleP()
        {

        }
        */
        #endregion

    }
}
