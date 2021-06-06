using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    public class Parcelles
    {
        #region Attribut
        private int tailleP;
        private char nomP;
        private List<Unite> Parcelle;
        #endregion

        #region Accesseurs
        public char NomP { get => nomP; set => nomP = value; }
        public int TailleP { get => tailleP; set => tailleP = value; }
        #endregion

        #region Constructeurs
        public Parcelles(char nP, List<Unite> ttsUnités)
        {
            
            nomP = nP;
            Parcelle = new List<Unite>();
            foreach (Unite U in ttsUnités)
            {
                if (U.Type == "Parcelle" && U.NomU == nomP)
                {
                    Parcelle.Add(U);
                    tailleP++;
                }
            }
        }

        
        #endregion

        #region Méthodes
        public void AfficheP()
        {
            Console.WriteLine("Parcelle {0} - {1} Unités",nomP,tailleP);
            foreach (Unite U in Parcelle)
                Console.Write("({0},{1})  ",U.X,U.Y);
            Console.WriteLine("\n");
        }
        #endregion

    }
}
