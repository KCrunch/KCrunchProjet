using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    /// <summary>
    /// Classe principal utilisant tous les outils de cryptage et de décryptage disponible
    /// </summary>
    class Logiciel
    {

        /// <summary>
        /// Permet d'afficher et de choisir le type de fichier à utiliser
        /// </summary>
        /// <returns>Retourne le type du fichier (.clair ou .chiffre)</returns>
        public static string type()
        {
            string Type;
            do
            {
                Console.WriteLine("Quel est le type de fichier que vous voulez utiliser ? (clair / chiffre) ");
                Type = Console.ReadLine();
                if (Type != "clair" && Type != "chiffre"){
                Console.WriteLine("Répondez par chiffre ou clair");
                }
            } while (Type != "clair" && Type != "chiffre") ;
        return Type;
        }

        /// <summary>
        /// Permet d'afficher et de choisir le fichier à utiliser
        /// </summary>
        /// <param name="Type"></param>
        public static void fichier(string Type)
        {
            string Fichier;
            bool verif;
            Ile cmdType;
            do
            {
                Console.WriteLine("Quel est le nom du fichier ? ex : Phatt "); // choisissez juste le nom de l'ile. Pas besoin de mettre le .clair.txt ou .chiffre.txt il sera mit automatiquement
                Fichier = Console.ReadLine();
                if (File.Exists("../../../" + Fichier + "." + Type + ".txt"))
                {
                    verif = true;
                }
                else
                {
                    verif = false;
                    Console.WriteLine("Votre fichier n'existe pas ou il est mal écrit veuillez verifier les majuscule");
                }
            } while (verif != true);
            cmdType=DecrypterCrypter.SiClairOuChiffre(Type, Fichier);
            cmdMode(cmdType, Type, Fichier);
        }
        public static void cmdMode(Ile TypeCMD,string type,string fichier)
        {
            char reponse;
            do
            {
                Console.WriteLine("Voulez vous utiliser le cmd Mode ? o / n");
                reponse = Convert.ToChar(Console.ReadLine());
                if (reponse != 'n'&& reponse != 'c'&& reponse != 'o')
                {
                    Console.WriteLine("Répondez par 'o' ou 'n' ");
                }
                if (reponse == 'o')
                {
                    Commande(TypeCMD,type,fichier);
                }
                if(reponse == 'n')
                {
                    DecrypterCrypter.AfficheTout(TypeCMD, type, fichier);
                }
            } while (reponse != 'n' && reponse != 'o');
        }

        /// <summary>
        /// Permet de recommencer ou non l'opération effectué avant
        /// </summary>
        /// <returns>Retourne le choix de l'utilisateur</returns>
        public static char continuer()
        {
            char Continuer;
            do
            {
                Console.WriteLine("Voulez vous donnez un autre fichier ? o / n ");
                Continuer = Convert.ToChar(Console.ReadLine());
                if (Continuer != 'n' && Continuer != 'o' && Continuer != 'c')
                {
                    Console.WriteLine("Répondez par 'o' ou 'n' ");
                }
            } while (Continuer != 'n' && Continuer != 'o');
            return (Continuer);
        }
        public static void Commande(Ile TypeCMD,string type,string fichier)
        {
            int numCommande;
            char lettre;
            do
            {
                AfficheCommande();
                Console.WriteLine("Choisissez la commande que vous voulez");
                numCommande = Convert.ToInt32(Console.ReadLine());
                if (numCommande == 1) TypeCMD.AfficheIle();
                if (numCommande == 2) DecrypterCrypter.AfficheUnitesCrypt(TypeCMD);
                if (numCommande == 3) TypeCMD.tailleMoyenneParcelles();
                if (numCommande == 4) 
                {
                    Console.WriteLine("Choisissez le nom de la parcelle");
                    lettre = Convert.ToChar(Console.ReadLine());
                    TypeCMD.tailleParcelles(lettre);
                }
                if (numCommande == 5) TypeCMD.AfficheParcelle();
                if(numCommande == 6) DecrypterCrypter.AfficheTout(TypeCMD, type, fichier);
                if (numCommande > 7) Console.WriteLine("Vous devez choisir un nombre entre 1 et 7");
                Console.WriteLine();
                if (numCommande == 7) Console.Clear();
            } while (numCommande != 7);
        }
        public static void AfficheCommande()
        {
            Console.WriteLine();
            Console.WriteLine("1- Affiher l'île");
            Console.WriteLine("2- Afficher l'île chiffré");
            Console.WriteLine("3- taille moyenne des parcelles");
            Console.WriteLine("4- taille de la parcelle lettre");
            Console.WriteLine("5- Afficher les parcelles");
            Console.WriteLine("6- Afficher Tout");
            Console.WriteLine("7- Quitter le cmdMode");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string Type;
            char Continuer;
            Console.WriteLine("IL faut au moins un fichier dans le dossier où se trouve toute les class");
            do
            {
                Type = type();
                fichier(Type);
                Continuer = continuer();
            } while (Continuer == 'o');
        }   
    }     
}
