using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Décrypter : Unité
    {
        private int Mer = 64;
        private int Forêt = 32;

        public Décrypter(string NomU, int X, int Y, int code, int Mer, int Forêt) : base(NomU, X, Y, code)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; i++)
                {
                    if (NomU == "M") { code = code + Mer; }
                    if (NomU == "F") { code = code + Forêt; }
                    if (NomU != "M" && NomU != "F" && X == 10) { code = code + 2 ^ 3; }
                    if (NomU != "M" && NomU != "F" && X == 0) { code = code + 2 ^ 1; }
                    if (NomU != "M" && NomU != "F" && Y == 10) { code = code + 2 ^ 2; }
                    if (NomU != "M" && NomU != "F" && Y == 0) { code = code + 2 ^ 0; }
                    if (NomU != "M" && NomU != "F" && X == 10 && Y == 10) { code = code + 2 ^ 3 + 2 ^ 2; }
                    if (NomU != "M" && NomU != "F" && X == 0 && Y == 0) { code = code + 2 ^ 0 + 2 ^ 1; }

                }
            }
        }
    }
}


