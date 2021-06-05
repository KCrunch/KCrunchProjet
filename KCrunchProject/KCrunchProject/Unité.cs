using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    public class Unité 
    {
        #region Attributs
        private char nomU;
        protected int X;
        protected int Y;
        private int code = 0;
        private string type;
        #endregion

        #region Accesseurs
        public int Code { get => code; set => code = value; }
        public string Type { get => type; set => type = value; }
        public char NomU { get => nomU; set => nomU = value; }
        #endregion

        #region Contructeurs
        public Unité(char NomU, int X, int Y) 
        {
            this.nomU = NomU;
            this.X = X;
            this.Y = Y;
            this.code = 0;
            if (NomU == 'M')
                this.Type = "Mer";
            else if (NomU == 'F')
                this.Type = "Forêt";
            else
            {
                this.Type = "Parcelle";

            }

        }

        public Unité(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public void AfficheU()
        {
            Console.WriteLine("Nom de l'unité : {0} en postion ({1},{2})", nomU, X, Y);
        }
        #endregion

        
        /*public Unité(string code)
        {
            string[] tab = code.Split(':');

            code = tab [0];

        }*/
    }
}
