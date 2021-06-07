using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    public class Unite 
    {
        #region Attributs
        private char nomU;
        private int x;
        private int y;
        private int code = 0;
        private string type;
        #endregion

        #region Accesseurs
        public int Code { get => code; set => code = value; }
        public string Type { get => type; set => type = value; }
        public char NomU { get => nomU; set => nomU = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        #endregion

        #region Contructeurs
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

        public Unite(string codeChiffre, int x, int y, string voisinOuest, string voisinNord)
        {
            this.code = Convert.ToInt32(codeChiffre);
            this.type = DecrypterCrypter.DeterminerTypeUnite(code, out this.nomU);
            this.x = x;
            this.y = y;

        }
        #endregion

        public void AfficheU()
        {
            Console.WriteLine("Nom de l'unité : {0} en postion ({1},{2})", nomU, x, y);
        }
        

        
        
    }
}
