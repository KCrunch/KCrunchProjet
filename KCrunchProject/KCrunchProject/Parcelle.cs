using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    /// <summary>
    /// Classe Parcelles : Modélise les parcelles
    /// </summary>
    public class Parcelles
    {
        #region Attribut
        /// <summary>
        /// Taille de la parcelle
        /// </summary>
        private int tailleP;

        /// <summary>
        /// Nom de la parcelle
        /// </summary>
        private char nomP;

        /// <summary>
        /// Liste des Parcelles
        /// </summary>
        private List<Unite> Parcelle;
        #endregion

        #region Accesseurs
        /// <summary>
        /// Accesseur en écriture et lecture de nomP
        /// </summary>
        public char NomP { get => nomP; set => nomP = value; }

        /// <summary>
        /// Accesseur en écriture et lecture de tailleP
        /// </summary>
        public int TailleP { get => tailleP; set => tailleP = value; }
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur de la classe <see cref="KCrunchProject/KCrunchProject/Parcelle.cs"/>
        /// </summary>
        /// <param name="nP"></param>
        /// <param name="ttsUnités"></param>
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

        /// <summary>
        /// Constructeur de la classe <see cref="KCrunchProject/KCrunchProject/Parcelle.cs"/>
        /// </summary>
        /// <param name="nP"></param>
        /// <param name="ttsUnités"></param>
        /// <param name="numeroUnite"></param>
        public Parcelles(char nP, List<Unite> ttsUnités, int numeroUnite)
        {
            int unique = 1;
            nomP = nP;
            Parcelle = new List<Unite>();
            foreach (Unite U in ttsUnités)
            {
                if (U.Type=="Parcelle")
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
        /// <summary>
        /// Affichage des parcelles
        /// </summary>
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
