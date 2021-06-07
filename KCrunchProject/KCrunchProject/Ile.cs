﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    public class Ile
    {
        #region Attributs
        private List<Unite> unites;
        private List<Parcelles> ListParcelles;

        
        #endregion
        #region Accesseurs
        public List<Unite> Unités { get => unites; set => unites = value; }
        #endregion

        #region Constructeurs
        public Ile(string cheminAccesFichier)
        {
            if(cheminAccesFichier.Contains(".clair"))
            { 
                        // instanciations de l'attribut unité
                        // Attention ! La lecture dans le fichier peut échouer
                        // Il faut gérer les erreurs -> structure try...catch
                try
                {
                        // Ici, instructions pouvant échouer
                    CreationListUniteViaPointClair(cheminAccesFichier);
                    CréationParcellesViaPointClair();
                }
                catch (Exception e)
                {
                        // Exécuté uniquement si erreur dans le bloc try
                        // e est alimentée par Windows avec un message d'erreur
                    Console.WriteLine(e.Message);
                }
            }
            if(cheminAccesFichier.Contains(".chiffre"))
            {
                try
                {
                    // Ici, instructions pouvant échouer
                    CreationListUniteViaPointChiffre(cheminAccesFichier);
                    CréationParcellesViaPointChiffre();
                }
                catch (Exception e)
                {
                    // Exécuté uniquement si erreur dans le bloc try
                    // e est alimentée par Windows avec un message d'erreur
                    Console.WriteLine(e.Message);
                }
                
            }

        }
        #endregion

        #region Méthodes
        public void AfficheUnité()
        {
            // Parcours de la liste Unités élément par élément
            foreach (Unite U in unites)
            {
                // Appel de la méthode AfficheU de la classe Unité
                U.AfficheU();
            }

        }
        public void AfficheParcelle()
        {
            // Parcours de la liste Parcelle élément par élément
            foreach (Parcelles P in ListParcelles)
            {
                // Appel de la méthode AfficheP de la classe Parcelles
                P.AfficheP();
            }

        }

        public void CreationListUniteViaPointClair(string cheminAccesFichier)
        {
            string nomUnite;
            Unite U;
            unites = new List<Unite>();
            StreamReader IleClaire = new StreamReader(cheminAccesFichier);
            string str;
            int y = 0;
            while ((str = IleClaire.ReadLine()) != null)
            {

                for (int x = 0; x <= 9; x = x + 1)
                {
                    nomUnite = str.Substring(x, 1);
                    U = new Unite(Convert.ToChar(nomUnite), x, y);
                    unites.Add(U);
                }
                y = y + 1;
            }
            IleClaire.Close();
        }

        public void CreationListUniteViaPointChiffre(string cheminAccesFichier)
        {
            unites = new List<Unite>();
            StreamReader IleChiffre = new StreamReader(cheminAccesFichier);
            string str = IleChiffre.ReadLine();
            string[] tabDeLigne = str.Split('|');
            DecryptageUnites(tabDeLigne);
            IleChiffre.Close();
        }

        public void DecryptageUnites(string[] ligneDeIle)
        {
            Unite U;
            int y = 0;
            string[] tabDeUnite;
            string[] exTabDeUnite;
            while (y != 10)
            {
                tabDeUnite = ligneDeIle[y].Split(':');
                if (y >= 1)
                {
                    exTabDeUnite = ligneDeIle[y - 1].Split(':');
                    for (int x = 0; x <= 9; x++)
                    {
                        if (x > 0)
                        {
                            U = new Unite(tabDeUnite[x], x, y, tabDeUnite[x - 1], exTabDeUnite[x]);
                            unites.Add(U);
                        }
                        else
                        {
                            U = new Unite(tabDeUnite[x], x, y, "0", "0");
                            unites.Add(U);
                        }
                    }

                }
                else
                {
                    for (int x = 0; x <= 9; x++)
                    {
                        if (x > 0)
                        {
                            U = new Unite(tabDeUnite[x], x, y, tabDeUnite[x - 1], "0");
                            unites.Add(U);
                        }
                        else 
                        {
                            U = new Unite(tabDeUnite[x], x, y, "0", "0");
                            unites.Add(U);
                        }     
                     }
                }
                y++;
            }
        }

        public int nbParcelle()   //retourne le nombre de parcelle(objet) à créer 
        {

            int maxi = 0;
            int nom;
            foreach (Unite U in unites)
            {
                if (U.Type == "Parcelle")
                {
                    nom = U.NomU;
                    if (nom > maxi)
                        maxi = nom;
                }
            }
            return maxi - 96;
        }


        public void CréationParcellesViaPointClair()  //Créer toutes les parcelles et les mets dans la liste de parcelle de l'Ile
        {
            ListParcelles = new List<Parcelles>();
            char nomParcelle = 'a';
            int nbDeParcelle = nbParcelle();
            Parcelles P;
            for (int i = 1; i <= nbDeParcelle; i++)
            {
                P = new Parcelles(nomParcelle, unites);
                ListParcelles.Add(P);
                nomParcelle = Convert.ToChar(Convert.ToInt32(nomParcelle) + 1);
            }
        }

        public void CréationParcellesViaPointChiffre()
        {
            char nomParcelle = 'a';
            ListParcelles = new List<Parcelles>();
            Parcelles P;
            int numeroUnite = 1;
            while (!DecrypterCrypter.ToutesUniteANomUnite(unites))
            {
                P = new Parcelles(nomParcelle, unites, numeroUnite);
                ListParcelles.Add(P);
                nomParcelle = Convert.ToChar(Convert.ToInt32(nomParcelle) + 1);
                numeroUnite = 1;
            }
        }

        public void tailleParcelles(char nomParcelle) //vérifie que la parcelle existe et l'affiche
        {
            bool existe = false;
            char nom = 'a';
            int taille = 0;
            foreach (Parcelles P in ListParcelles)
            {
                if (nomParcelle == P.NomP)
                {
                    existe = true;
                    nom = P.NomP;
                    taille = P.TailleP;
                }
            }
            if (existe)
                Console.WriteLine("Taille de la parcelle  {0} : {1} unites", nom, taille);
            else
                Console.WriteLine("Parcelle {0} : inexistante\nTaille de la parcelle {0}: 0 unites", nomParcelle);
        }

        public void tailleMoyenneParcelles()
        {
            int somme = 0;
            foreach (Parcelles P in ListParcelles)
                somme = somme + P.TailleP;
            Console.WriteLine("Aire moyenne : {0:.00}", somme * 1.0 / nbParcelle());
        }

        public void AfficheIle()
        {
            string FichierDecrypter;
            int compt = 0;
            foreach (Unite U in unites)
            {
                if (compt == 10)
                {
                    Console.WriteLine("");
                    compt = 0;
                }
                if (U.NomU == 'M')
                    ChangeForeGrounColorAfficheIle(ConsoleColor.Blue, U.NomU);
                else if (U.NomU == 'F')
                    ChangeForeGrounColorAfficheIle(ConsoleColor.Green, U.NomU);
                else
                    ChangeForeGrounColorAfficheIle(ConsoleColor.Gray, U.NomU);
                FichierDecrypter = Convert.ToString(U.NomU) + " ";
                 
                compt++;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void ChangeForeGrounColorAfficheIle(ConsoleColor Couleur, char nomUnite)
        {
            Console.ForegroundColor = Couleur;
            Console.Write("{0} ", nomUnite);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion
    }
}
