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
        #endregion
        /*public Unité(string code)
        {
            string[] tab = code.Split(':');

            code = tab [0];

        }*/
    }
}
