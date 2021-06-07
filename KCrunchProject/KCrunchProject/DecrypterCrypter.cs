using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    static class DecrypterCrypter
    {
        const int Mer = 64;
        const int Foret = 32;
        const int Nord = 1;
        const int Ouest = 2;
        const int Sud = 4;
        const int Est = 8;


        static public void Crypter(Ile Ile, string LienFichier)
        {
            string Fichier="";
            foreach (Unite U in Ile.Unités)
            {
                U.Code += VerifMerOuForet(U.NomU);
                U.Code += FrontiereExeption(U.X, U.Y); ;
                U.Code += SommeNordOuestSudEst(U.NomU, U.X, U.Y, Ile.Unités);
                Fichier += AfficheCrypt(U.Code, U.X);
            }
            Console.WriteLine("\n");
            CreeFichierCrypter(Fichier, LienFichier);
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
        static public int SommeNordOuestSudEst(char nom, int BoiteX, int BoiteY, List<Unite> ListeUnites)
        {
            int code = 0;
            foreach (Unite U in ListeUnites)
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

        static public char DecrypteNomUnite(string nomUniteChiffre)
        {
            char nomUniteClair = 'a';
            int code = Convert.ToInt32(nomUniteChiffre);
            
            return nomUniteClair;
        }
        static public string DeterminerTypeUnite(int code,out char nomUnite)
        {
            nomUnite = ' ';
            string type = "";
            if (code - Mer >= 0)
            {
                type = "Mer";
                nomUnite = 'M';
            }
            else if (code - Foret >= 0)
            {
                type = "Foret";
                nomUnite = 'F';
            }
            else
                type = "Parcelle";
            return type;
        }
        static public bool DeterminerMemeParcelles(int code, int coordonneXU, int coordonneYU, int coordonneXVoisin, int coordonneYVoisin)
        {
            bool resultat=false;
            if ( !DeterminerSiFrontiereNord(code) &&  (coordonneXU == coordonneXVoisin) && (coordonneYU - 1 == coordonneYVoisin))
                resultat =true;
            if ( !DeterminerSiFrontiereOuest(code) && (coordonneXU - 1 == coordonneXVoisin) && (coordonneYU  == coordonneYVoisin))
                resultat = true;
            return resultat;
        }

        static public bool DeterminerSiParcelles(int code)
        {
            bool resultat = false;
            if (code < Foret)
                resultat = true;
            return resultat;
        }

        static public bool DeterminerSiFrontiereNord(int code)
        {
            bool resultat = false;
            if (code >= Est)
                code -= Est;
            if (code >= Sud)
                code -= Sud;
            if (code >= Ouest)
                code -= Ouest;
            if (code == Nord)
                resultat = true;
            return resultat;
        }

        static public bool DeterminerSiFrontiereOuest(int code)
        {
            bool resultat = false;
            if (code >= Est)
                code -= Est;
            if (code >= Sud)
                code -= Sud;
            if (code >= Ouest)
                resultat = true;
            return resultat;
        }

        static public bool ToutesUniteANomUnite(List<Unite> toutesUnites)
        {
            bool resultat = true;
            foreach (Unite U in toutesUnites)
                if (U.NomU == ' ')
                    resultat = false;
            return resultat;
        }
    }
}
/*foreach(Unite U in Ile.Unites)
{
    if (U.Type == "parcelle")
    {
            int NomC = 'a';
            char NomParcelle = ' ';
            foreach (Unite U in ListeUnites)
            {
                if (type == "Parcelle" && U.X - 1 == BoiteX && U.Y == BoiteY && code - Est >= 0) // c normal c du la plus grande a la plus petite puissance de deux
                    NomParcelle = Convert.ToChar(NomC);
                else if (type == "Parcelle" && U.Y - 1 == BoiteY && U.X == BoiteX && code - Sud >= 0)
                    NomParcelle = Convert.ToChar(NomC);
                else if (type == "Parcelle" && U.X + 1 == BoiteX && U.Y == BoiteY && code - Ouest >= 0)
                    NomParcelle = Convert.ToChar(NomC);
                else if (type == "Parcelle" && U.Y + 1 == BoiteX && U.Y == BoiteY && code - Nord >= 0)
                    NomParcelle = Convert.ToChar(NomC);
            }
            // 9 = Nord + Est  9 - 8 = 1 NON 9 - 1 = 0 NON Donc Voisin Ouest et Sud || 13 = Nord + Sud + Est  13 - 8 <= 0 NON 5 - 4 = 1 <= 0 NON 1 - 1 NON Donc voisin Ouest
        }
    }*/

