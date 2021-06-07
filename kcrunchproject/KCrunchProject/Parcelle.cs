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

        public Parcelles(char nP, List<Unite> ttsUnités, int numeroUnite)
        {
            int unique = 1;
            nomP = nP;
            Parcelle = new List<Unite>();
            foreach (Unite U in ttsUnités)
            {
                if (DecrypterCrypter.DeterminerSiParcelles(U.Code))
                {
                    if (numeroUnite == 1 && U.NomU == ' ')
                    {
                        U.NomU = nomP;
                        Parcelle.Add(U);
                        tailleP++;
                        numeroUnite++;
                    } 
                    else
                    {
                        foreach(Unite UParcelle in this.Parcelle)
                        {
                            if (DecrypterCrypter.DeterminerMemeParcelles(U.Code,U.X,U.Y,UParcelle.X,UParcelle.Y) && unique == 1)
                            {
                                U.NomU = nomP;
                                tailleP++;
                                unique++;
                            }
                        }
                        if(U.NomU==nomP)
                            Parcelle.Add(U);
                        unique = 1;
                    }
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
