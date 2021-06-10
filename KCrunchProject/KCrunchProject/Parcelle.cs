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
        private List<Unité> Parcelle;
        #endregion

        #region Accesseurs
        public char NomP { get => nomP; set => nomP = value; }
        public int TailleP { get => tailleP; set => tailleP = value; }
        #endregion

        #region Constructeurs
        public Parcelles(char nP, List<Unité> ttsUnités)
        {
            
            nomP = nP;
            Parcelle = new List<Unité>();
            foreach (Unité U in ttsUnités)
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
            foreach (Unité U in Parcelle)
                Console.Write("({0},{1})  ",U.X,U.Y);
            Console.WriteLine("\n");
        }
        #endregion


    }
}
