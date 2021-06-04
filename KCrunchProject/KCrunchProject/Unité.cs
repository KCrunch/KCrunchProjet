﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    public class Unité 
    {
        #region Attributs
        protected char NomU;

        protected int X;

        protected int Y;

        private int code = 0;

        public int Code { get => code; set => code = value; }

        #endregion

        #region Contructeurs
        public Unité(char NomU, int X, int Y, int code) 
        {
            this.NomU = NomU;
            this.X = X;
            this.Y = Y;
            this.code = code;
        }

        public Unité(int x, int y, int code)
        {
            this.X = x;
            this.Y = y;
            this.code = code;
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
