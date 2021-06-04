using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Crypter : Unité
    {
        private int Mer = 64;
        private int Forêt = 32;
        private string stockNom;
        private int stockX;

        public Crypter(string NomU, int X, int Y,int code, int Mer, int Forêt, string StockNom, int stockX) : base (NomU,X,Y)
        {
            StockNom = NomU;
            for (Y = 0; Y <= 9; Y++)
            {
                for (X = 0; X <= 9; X++)
                {
                    if (NomU == "M")  code = code + Mer; 
                    if (NomU == "F")  code = code + Forêt; 
                    if (X == 10) { code = code + 2 ^ 3; }
                    if (X == 0) { code = code + 2 ^ 1; }
                    if (Y == 10) { code = code + 2 ^ 2; }
                    if (Y == 0) { code = code + 2 ^ 0; }
                    if (X == 10 && Y == 10) { code = code + 2 ^ 3 + 2 ^ 2; }
                    if (X == 0 && Y == 0) { code = code + 2 ^ 0 + 2 ^ 1; }
                    if (X == 0 && Y == 10) { code = code + 2 ^ 1 + 2 ^ 2; }
                    if (X == 10 && Y == 0) { code = code + 2 ^ 0 + 2 ^ 3; }
                    if (StockNom != NomU) 
                    { 
                        if(X == X +1) { code = code + 2 ^ 3; }
                    }
                    StockNom = NomU;
                }
            }
        }
    }
}


