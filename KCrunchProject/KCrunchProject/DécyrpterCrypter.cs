using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class DécyrpterCrypter 
    {
        private int Mer = 64;
        private int Forêt = 32;
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
            ForetMer();
            LesBord();
            NordSudEstOuest();
            
        }

        public void ForetMer() //
        {
            foreach (Unité U in LCode)
            {
                if (U.NomU == 'M') U.Code = U.Code + 64;
                if (U.NomU == 'F') U.Code = U.Code + 32;
            }
        }

        public void LesBord()
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

        public void NordSudEstOuest()
        {
            foreach (Unité U in LCode)
            {
                for(int i = 0;i <= 9; i++)
                {
                    if (P.)
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


