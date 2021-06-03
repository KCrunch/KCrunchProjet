using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    class Parcelles
    {
        #region Attribut
        private int TailleP;
        private char nomP;
        private List<Unité> Parcelle;
        #endregion

        #region Constructeurs
        public Parcelles(int tP, char nP, List<Unité> P)
        {
            TailleP = tP;
            nomP = nP;
            Parcelle = P;
        }
        #endregion

        #region Méthodes
        /*int NbrP()
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
