using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    public class île 
    {
        #region Attributs
        private List<Unité> unités;
        private List<Parcelles> ListParcelles;
        #endregion

        #region Accesseurs
        public List<Unité> Unités { get => unités; set => unités = value; }
        
        
        #endregion

        #region Constructeurs
        public île(string cheminAccesFichier) 
        {
            int y = 0;
            // instanciations de l'attribut unité
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {

                unités = new List<Unité>();
                ListParcelles = new List<Parcelles>();

                // Ici, instructions pouvant échouer
                StreamReader sr = new StreamReader(cheminAccesFichier);
                string str;
                string Unit;
                Unité U;

                while ((str = sr.ReadLine()) != null)
                {
                    
                    for (int i = 0; i <= 9; i=i+1)
                    {
                        Unit = str.Substring(i,1);
                        U = new Unité(Convert.ToChar(Unit), i, y);
                        unités.Add(U);
                    }
                    y = y + 1;
                }
                sr.Close();
                créationParcelles();
            }

            catch (Exception e)
            {
                // Exécuté uniquement si erreur dans le bloc try
                // e est alimentée par Windows avec un message d'erreur
                Console.WriteLine(e.Message);
            }


        }
        #endregion

        #region Méthodes
        public void AfficheUnité()
        {
            // Parcours de la liste Unités élément par élément
            foreach (Unité U in unités)
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
        public int nbParcelle()   //retourne le nombre de parcelle(objet) à créer 
        {
            int maxi = 0;
            int nom;
            foreach (Unité U in unités)
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
        public void créationParcelles()  //Créer toutes les parcelles et les mets dans la liste de parcelle de l'île
        {
            ListParcelles = new List<Parcelles>();
            char nomParcelle = 'a';
            int nbDeParcelle = nbParcelle();
            Parcelles P;
            for (int i = 1; i <= nbDeParcelle; i++)
            {
                P = new Parcelles(nomParcelle, unités);
                ListParcelles.Add(P);
                nomParcelle = Convert.ToChar(Convert.ToInt32(nomParcelle) + 1);
            }
        }

        public void tailleParcelles(char nomParcelle) //vérifie que la parcelle existe et l'affiche
        {
            bool existe = false;
            char nom='a';
            int taille=0;
            foreach(Parcelles P in ListParcelles)
            {
                if (nomParcelle == P.NomP)
                {
                    existe = true;
                    nom = P.NomP;
                    taille = P.TailleP;
                }        
            }
            if (existe)
                Console.WriteLine("Taille de la parcelle  {0} : {1} unites",nom ,taille );
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
            int compt = 0;
            foreach(Unité U in unités)
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
