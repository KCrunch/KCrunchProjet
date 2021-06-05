using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class DécyrpterCrypter 
    {
        private int Mer = 64;
        private int Foret = 32;

        private int Nord = 1;
        private int Ouest = 2;
        private int Sud = 4;
        private int Est = 8;

        /*private string stockNom;
        private int stockX;*/
        private List<Unité> LCode;



        public DécyrpterCrypter(List<Unité> ttsUnités)
        {
            LCode = new List<Unité>();
            foreach (Unité U in ttsUnités)
            {
                    LCode.Add(U);
            }
        }

        public void Crypter()
        {
            VerifMerOuForet();
            FrontiereExeption();
            CalculFrontiere();
            AfficheCrypt();


        }

        public void VerifMerOuForet() //
        {
            foreach (Unité U in LCode)
            {
                if (U.NomU == 'M') U.Code = U.Code + Mer;
                else if (U.NomU == 'F') U.Code = U.Code + Foret;
            }
        }

        public void FrontiereExeption()
        {

            foreach (Unité U in LCode)
            {
                if (U.X == 9) U.Code = U.Code + Est;
                if (U.X == 0) U.Code = U.Code + Ouest;
                if (U.Y == 9) U.Code = U.Code + Sud;
                if (U.Y == 0) U.Code = U.Code + Nord;
                if (U.X == 9 && U.Y == 9) U.Code = U.Code + Est + Sud;
                if (U.X == 0 && U.Y == 0) U.Code = U.Code + Nord + Ouest;
                if (U.X == 0 && U.Y == 9) U.Code = U.Code + Ouest + Sud;
                if (U.X == 9 && U.Y == 0) U.Code = U.Code + Nord + Est;
            }
        }

        public void CalculFrontiere()
        {
            foreach (Unité U in LCode)
            {
                SommeNordOuestSudEst(U.NomU,U.X,U.Y);
            }
        }

        public void SommeNordOuestSudEst(char nomP, int BoiteX, int BoiteY)
        {
            foreach (Unité U in LCode)
            {
                if (nomP != U.NomU && U.X == BoiteX + 1)
                {
                    U.Code = U.Code + Est;
                }
                if (nomP != U.NomU && U.X == BoiteX - 1)
                {
                    U.Code = U.Code + Ouest;
                }
                if (nomP != U.NomU && U.Y == BoiteY + 1)
                {
                    U.Code = U.Code + Nord;
                }
                if (nomP != U.NomU && U.Y == BoiteY - 1)
                {
                    U.Code = U.Code + Sud;
                }
            }
        }

        public void AfficheCrypt()
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

        public void Décrypter ()
        {
        
            /*string[] tab = code.Split(':'); // methode pour séparer dans un fichier le nombre de character separer par un caractere voulue
            code = tab [0];*/

        }
        
    }
}


