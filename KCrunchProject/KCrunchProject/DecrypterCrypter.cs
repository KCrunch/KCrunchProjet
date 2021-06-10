﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    /// <summary>
    /// Classe DécrypterCrypter : Regroupe le cryptage ainsi que le décryptage
    /// </summary>
    static class DecrypterCrypter
    {
        /// <summary>
        /// Constante correspondant à une Mer
        /// </summary>
        const int Mer = 64;

        /// <summary>
        /// Constante correspondant à une Fôret
        /// </summary>
        const int Foret = 32;

        /// <summary>
        /// Constante correspond à une frontière nord
        /// </summary>
        const int Nord = 1;

        /// <summary>
        /// Constante correspond à une frontière ouest
        /// </summary>
        const int Ouest = 2;

        /// <summary>
        /// Constante correspond à une frontière sud
        /// </summary>
        const int Sud = 4;

        /// <summary>
        /// Constante correspond à une frontière est
        /// </summary>
        const int Est = 8;

        /// <summary>
        /// Cyptage de l'ile
        /// </summary>
        /// <param name="Ile"></param>
        /// <param name="LienFichier"></param>
        static public void Crypter(Ile Ile, string LienFichier)
        {
            string Fichier="";
            foreach (Unite U in Ile.Unités)
            {
                U.Code += VerifMerOuForet(U.NomU);
                U.Code += FrontiereException(U.X, U.Y); ;
                U.Code += SommeNordOuestSudEst(U.NomU, U.X, U.Y, Ile.Unités);
                Fichier += EcritureCryptage(U.Code, U.X);
            }
            Console.WriteLine("\n");
            CreeFichier(Fichier, LienFichier);
        }

        /// <summary>
        /// Vérification pour savoir si c'est une parcelle mer ou forêt
        /// </summary>
        /// <param name="nomU"></param>
        /// <returns></returns>
        static public int VerifMerOuForet(char nomU)
        {
            int code = 0;
            if (nomU == 'M')
                code = code + Mer;
            else if (nomU == 'F')
                code = code + Foret;
            return code;
        }

        /// <summary>
        /// Cryptage des exceptions de frontières (les bordures de la carte)
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        static public int FrontiereException(int X, int Y)
        {
            int code = 0;
            if (Y == 0) code = code + Nord;
            if (X == 0) code = code + Ouest;
            if (Y == 9) code = code + Sud;
            if (X == 9) code = code + Est;
            return code;
        }

        /// <summary>
        /// Cryptage des frontières classiques
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="BoiteX"></param>
        /// <param name="BoiteY"></param>
        /// <param name="ListeUnites"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// Fonction pour créer un fichier
        /// </summary>
        /// <param name="Fichier"></param>
        /// <param name="cheminAccesFichier"></param>
        static public void CreeFichier(string Fichier, string cheminAccesFichier) 
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

        /// <summary>
        /// Affichage du cryptage effectué 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static public string EcritureCryptage(int code, int x)
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

        /// <summary>
        /// Fonction pour déterminer le type de l'unité
        /// </summary>
        /// <param name="code"></param>
        /// <param name="nomUnite"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Déterminer si c'est la même parcelle (a, b, c...)
        /// </summary>
        /// <param name="code"></param>
        /// <param name="coordonneXU"></param>
        /// <param name="coordonneYU"></param>
        /// <param name="coordonneXVoisin"></param>
        /// <param name="coordonneYVoisin"></param>
        /// <returns></returns>
        static public bool DeterminerMemeParcelles(int code, int coordonneXU, int coordonneYU, int coordonneXVoisin, int coordonneYVoisin)
        {
            bool resultat=false;
            if ( !DeterminerSiFrontiereNord(code) &&  (coordonneXU == coordonneXVoisin) && (coordonneYU - 1 == coordonneYVoisin))
                resultat =true;
            if ( !DeterminerSiFrontiereOuest(code) && (coordonneXU - 1 == coordonneXVoisin) && (coordonneYU  == coordonneYVoisin))
                resultat = true;
            return resultat;
        }

        /// <summary>
        /// Détermine si c'est une parcelle
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        static public bool DeterminerSiParcelles(int code)
        {
            bool resultat = false;
            if (code < Foret)
                resultat = true;
            return resultat;
        }

        /// <summary>
        /// Determine si c'est une frontiere nord
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Détermine si c'est une frontière ouest
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Vérification si chaque unité dans toutesUnites possède un nom
        /// </summary>
        /// <param name="toutesUnites"></param>
        /// <returns></returns>
        static public bool ToutesUniteANomUnite(List<Unite> toutesUnites)
        {
            bool resultat = true;
            foreach (Unite U in toutesUnites)
                if (U.NomU == ' ')
                    resultat = false;
            return resultat;
        }

        /// <summary>
        /// Décryptage de l'ile
        /// </summary>
        /// <param name="Ile"></param>
        /// <param name="cheminAccesFichier"></param>
        static public void Decrypter(Ile Ile, string cheminAccesFichier)
        {
            string Fichier = "";
            string cheminAccesF;
            int compt = 0;
            foreach (Unite U in Ile.Unités)
            {
                if (compt == 10)
                {
                    Fichier += "\n";
                    compt = 0;
                }

                Fichier += Convert.ToString(U.NomU);

                compt++;
            }
            cheminAccesF = cheminAccesFichier;
            CreeFichier(Fichier, cheminAccesF);
        }

    }
}

