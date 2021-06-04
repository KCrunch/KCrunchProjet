using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Décrypter : Unité
    {
        private int Mer = 64;
        private int Forêt = 32;

        public Décrypter(int X, int Y, char NomU, int code, int Mer, int Forêt) : base (X,Y,NomU,code)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; i++)
                {
                    if (X = j + 1 && Y = i) && (NomU != 'F' || NomU != 'M')) { }
                    {
                    if (X = 10 && Y = i && (NomU != 'F' || NomU != 'M')) { code = 2 ^ 3; }
                    else { code = 2 ^ 3; }

            }
        }
    }
}


