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

        public void Afficher()
        {
            Console.WriteLine("Choisir les coordonnée de l'unité");
            Console.WriteLine("X = ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y = ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nom de l'unité : {0} en postion ({1},{2})",NomU , X , Y);
        }
        /*public Unité(string code)
        {
            string[] tab = code.Split(':');

            code = tab [0];

        }*/
    }
}
