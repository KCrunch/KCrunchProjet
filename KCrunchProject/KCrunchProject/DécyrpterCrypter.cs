using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{ 
    static class DécyrpterCrypter 
    {
        const int Mer = 64;
        const int Foret = 32;

        const int Nord = 1;
        const int Ouest = 2;
        const int Sud = 4;
        const int Est = 8;


        static public void Crypter(Ile Ile)
        {
            foreach (Unité U in Ile.Unités)
            {
                U.Code += VerifMerOuForet(U.NomU);
                U.Code += FrontiereExeption(U.X,U.Y); ;
                U.Code += CalculFrontiere(U.NomU, U.X, U.Y) ;
                AfficheCrypt();
            }
        }

        static public int VerifMerOuForet(char nomU) //
        {
            int code=0;
            if (nomU == 'M') 
                code = code + Mer;
            else if (nomU == 'F') 
                code = code + Foret;
            return code;
        }

        static public int FrontiereExeption(int X,int Y)
        {
            int code = 0;
            if (X == 9) code = code + Est;
            if (X == 0) code = code + Ouest;
            if (Y == 9) code = code + Sud;
            if (Y == 0) code = code + Nord;
            if (X == 9 && Y == 9) code = code + Est + Sud;
            if (X == 0 && Y == 0) code = code + Nord + Ouest;
            if (X == 0 && Y == 9) code = code + Ouest + Sud;
            if (X == 9 && Y == 0) code = code + Nord + Est;
            return code;
        }

        static public int CalculFrontiere(char nomU,int X, int Y)
        {
                return SommeNordOuestSudEst(nomU, X, Y) ;
        }

        static public int SommeNordOuestSudEst(char nomP, int BoiteX, int BoiteY)
        {
            int code = 0;
            foreach (Unité U in LCode)
            {
                if (nomP != U.NomU && U.X == BoiteX + 1)
                {
                    code = code + Est;
                }
                if (nomP != U.NomU && U.X == BoiteX - 1)
                {
                    code = code + Ouest;
                }
                if (nomP != U.NomU && U.Y == BoiteY + 1)
                {
                    code = code + Nord;
                }
                if (nomP != U.NomU && U.Y == BoiteY - 1)
                {
                    code = code + Sud;
                }
            }
            return code;
        }


        static public void AfficheCrypt()
        {
            foreach (Unité U in LCode)
            {
                Console.WriteLine("{0} : ", U.Code);
                if (U.X >= 9)
                {
                    Console.Write(" | ");
                }
            }
        }
        /*
        public void Décrypter ()
        {
        
            string[] tab = code.Split(':'); // methode pour séparer dans un fichier le nombre de character separer par un caractere voulue
            code = tab [0];

        }*/
        
    }
}


