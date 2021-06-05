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
                U.Code += SommeNordOuestSudEst(U.NomU, U.X, U.Y, Ile.Unités);
                U.Code += VerifMerOuForet(U.NomU);
                U.Code += FrontiereExeption(U.X,U.Y); ;
                AfficheCrypt(U.Code, U.X);
            }  
        }

        static public int VerifMerOuForet(char nomU)
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
            return code;
        }
        static public int SommeNordOuestSudEst(char nom, int BoiteX, int BoiteY, List<Unité> ListeUnites)
        {
            int code = 0;
            foreach (Unité U in ListeUnites)
            {
                
                if (U.NomU != nom && U.Y + 1 == BoiteY  && U.X == BoiteX)
                {
                    code = code + Nord;
                }
                else if (U.NomU != nom && U.X - 1 == BoiteX  && U.Y == BoiteY)
                {
                    code = code + Ouest;
                }
                else if (U.NomU != nom && U.Y - 1 == BoiteY  && U.X == BoiteX)
                {
                    code = code + Sud;
                }
                else if (U.NomU != nom && U.X + 1 == BoiteX  && U.Y == BoiteY)
                {
                    code = code + Est;
                }
            }
            return code;
        }

        static public void AfficheCrypt(int code, int x)
        {
            if (x >= 9)
            {
                Console.Write("{0}|",code);
            }
            else 
                Console.Write("{0}:", code);


        }
        /*
        public void Décrypter ()
        {
        
            string[] tab = code.Split(':'); // methode pour séparer dans un fichier le nombre de character separer par un caractere voulue
            code = tab [0];

        }*/
        
    }
}


