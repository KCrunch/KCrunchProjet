using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    public class Unité 
    {
        #region Attributs
        private char NomU;
        protected int X;
        protected int Y;
        private int code = 0;
        private string type;

        public int Code { get => code; set => code = value; }
        public string Type { get => type; set => type = value; }
        public char NomU1 { get => NomU; set => NomU = value; }

        #endregion

        #region Contructeurs
        public Unité(char NomU, int X, int Y) 
        {
            this.NomU = NomU;
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


        public void Affiche()
        {
            Console.WriteLine("Nom de l'unité : {0} en postion ({1},{2})", NomU, X, Y);
        }
        #endregion

        
        /*public Unité(string code)
        {
            string[] tab = code.Split(':');

            code = tab [0];

        }*/
    }
}
