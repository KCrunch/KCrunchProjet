using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Unité 
    {
        #region Attributs
        protected string NomU;

        protected int X;

        protected int Y;

        #endregion

        #region Contructeurs
        public Unité(string nu, int x, int y) 
        {
            NomU = nu;
            X = x;
            Y = y;

        }

        public void Afficher()
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
