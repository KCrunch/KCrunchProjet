using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Décrypter : Unité
    {
        private int Mer = 64;
        private int Forêt = 32;

        public Décrypter(int X, int Y, char NomU, int Code, int Mer, int Forêt) : base (X,Y,NomU)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; i++)
                {
                    if (NomU == 'M') { Code = Code + Mer; }
                    if (NomU == 'F') { Code = Code + Forêt; }
                    if (NomU != 'M' && NomU != 'F' && X == 10) { Code = Code + 2 ^ 3; }
                    if (NomU != 'M' && NomU != 'F' && X == 0) { Code = Code + 2 ^ 1; }
                    if (NomU != 'M' && NomU != 'F' && Y == 10) { Code = Code + 2 ^ 2; }
                    if (NomU != 'M' && NomU != 'F' && Y == 0) { Code = Code + 2 ^ 0; }
                    if (NomU != 'M' && NomU != 'F' && X == 10 && Y == 10) { Code = Code + 2 ^ 3 + 2 ^ 2; }
                    if (NomU != 'M' && NomU != 'F' && X == 0 && Y == 0) { Code = Code + 2 ^ 0 + 2 ^ 1; }

                }
            }
        }
    }
}


