using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    /// <summary>
    /// Classe Unite : Modélise les unités
    /// </summary>
    public class Unite 
    {
        #region Attributs
        /// <summary>
        /// Nom de l'unité
        /// </summary>
        private char nomU;

        /// <summary>
        /// Coord x de l'unité
        /// </summary>
        private int x;

        /// <summary>
        /// Coord y de l'unité
        /// </summary>
        private int y;

        /// <summary>
        /// Code de l'unité
        /// </summary>
        private int code = 0;

        /// <summary>
        /// Type de l'unité
        /// </summary>
        private string type;
        #endregion

        #region Accesseurs

        /// <summary>
        /// Accesseur en écriture et lecture de code
        /// </summary>
        public int Code { get => code; set => code = value; }

        /// <summary>
        /// Accesseur en écriture et lecture de type
        /// </summary>
        public string Type { get => type; set => type = value; }

        /// <summary>
        /// Accesseur en écriture et lecture de nomU
        /// </summary>
        public char NomU { get => nomU; set => nomU = value; }

        /// <summary>
        /// Accesseur en écriture et lecture de x
        /// </summary>
        public int X { get => x; set => x = value; }

        /// <summary>
        /// Accesseur en écriture et lecture de y
        /// </summary>
        public int Y { get => y; set => y = value; }

        #endregion

        #region Contructeurs

        /// <summary>
        /// Constructeur de la classe <see cref="KCrunchProject/KCrunchProject/Unite.cs"/>
        /// </summary>
        /// <param name="NomU"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Unite(char NomU, int X, int Y) 
        {
            this.nomU = NomU;
            this.x = X;
            this.y = Y;
            this.code = 0;
            if (NomU == 'M')
                this.Type = "Mer";
            else if (NomU == 'F')
                this.Type = "Forêt";
            else
                this.Type = "Parcelle";
        }

        /// <summary>
        /// Constructeur de la classe <see cref="KCrunchProject/KCrunchProject/Unite.cs"/>
        /// </summary>
        /// <param name="codeChiffre"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="voisinOuest"></param>
        /// <param name="voisinNord"></param>
        public Unite(string codeChiffre, int x, int y, string voisinOuest, string voisinNord)
        {
            this.code = Convert.ToInt32(codeChiffre);
            this.type = DecrypterCrypter.DeterminerTypeUnite(code, out this.nomU);
            this.x = x;
            this.y = y;

        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Affichage des Unités
        /// </summary>
        public void AfficheU()
        {
            Console.WriteLine("Nom de l'unité : {0} en postion ({1},{2})", nomU, x, y);
        }
        #endregion

    }
}
