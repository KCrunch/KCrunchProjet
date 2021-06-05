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
                if (U.X == 10) U.Code = U.Code + 2 ^ 3;
                if (U.X == 0) U.Code = U.Code + 2 ^ 1;
                if (U.Y == 10) U.Code = U.Code + 2 ^ 2;
                if (U.Y == 0) U.Code = U.Code + 2 ^ 0;
                if (U.X == 10 && U.Y == 10) U.Code = U.Code + 2 ^ 3 + 2 ^ 2;
                if (U.X == 0 && U.Y == 0) U.Code = U.Code + 2 ^ 0 + 2 ^ 1;
                if (U.X == 0 && U.Y == 10) U.Code = U.Code + 2 ^ 1 + 2 ^ 2;
                if (U.X == 10 && U.Y == 0) U.Code = U.Code + 2 ^ 0 + 2 ^ 3;
            }
        }

        public void CalculFrontiere()
        {
            foreach (Unité U in LCode)
            {
                for(int i = 0;i <= 9; i++)
                {
                    if (Parcelles.)
                    {

                    }
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


