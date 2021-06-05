using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
            string Fichier="";
            foreach (Unité U in Ile.Unités)
            {
                U.Code += VerifMerOuForet(U.NomU);
                U.Code += FrontiereExeption(U.X, U.Y); ;
                U.Code += SommeNordOuestSudEst(U.NomU, U.X, U.Y, Ile.Unités);
                Fichier += AfficheCrypt(U.Code, U.X);
            }
            CreeFichierCrypter(Fichier, "../../../Phatt.chiffre.txt");
        }

        static public int VerifMerOuForet(char nomU)
        {
            int code = 0;
            if (nomU == 'M')
                code = code + Mer;
            else if (nomU == 'F')
                code = code + Foret;
            return code;
        }

        static public int FrontiereExeption(int X, int Y)
        {
            int code = 0;
            if (Y == 0) code = code + Nord;
            if (X == 0) code = code + Ouest;
            if (Y == 9) code = code + Sud;
            if (X == 9) code = code + Est;
            return code;
        }
        static public int SommeNordOuestSudEst(char nom, int BoiteX, int BoiteY, List<Unité> ListeUnites)
        {
            int code = 0;
            foreach (Unité U in ListeUnites)
            {

                if (U.NomU != nom && U.Y + 1 == BoiteY && U.X == BoiteX)
                    code = code + Nord;
                else if (U.NomU != nom && U.X + 1 == BoiteX && U.Y == BoiteY)
                    code = code + Ouest;
                else if (U.NomU != nom && U.Y - 1 == BoiteY && U.X == BoiteX)
                    code = code + Sud;
                else if (U.NomU != nom && U.X - 1 == BoiteX && U.Y == BoiteY)
                    code = code + Est;
            }
            return code;
        }

        static public void CreeFichierCrypter(string Fichier, string cheminAccesFichier) 
        {
            if (File.Exists(cheminAccesFichier))
            {
                File.Delete(cheminAccesFichier);
            }

            // Créer un nouveau fichier   
            using (FileStream fileStr = File.Create(cheminAccesFichier))
            {
                // Ajouter du texte au fichier  
                Byte[] text = new UTF8Encoding(true).GetBytes(Fichier);
                fileStr.Write(text, 0, text.Length);
            }
        }

        static public string AfficheCrypt(int code, int x)
        {
            string FichierCrypter;
            if (x >= 9)
            {
                Console.Write("{0}|", code);
                FichierCrypter = Convert.ToString(code) + "|";
            }
            else
            {
                Console.Write("{0}:", code);
                FichierCrypter = Convert.ToString(code) + ":";
            }
            return FichierCrypter;
        }
        /*
        public void Décrypter ()
        {
        
            string[] tab = code.Split(':'); // methode pour séparer dans un fichier le nombre de character separer par un caractere voulue
            code = tab [0];

        }*/
        
    }
}


