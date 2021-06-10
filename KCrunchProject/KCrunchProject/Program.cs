using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    class Program
    {

        static void Main(string[] args)
        {
            string Fichier;
            string Type;
            char Continuer;
            bool verif;
            
            Console.WriteLine("IL faut au moins un fichier dans le dossier où se trouve toute les class");
            
            do
            {
                do
                {
                    Console.WriteLine("Quel est le type de fichier que vous voulez utiliser ? (clair / chiffre) ");
                    Type = Console.ReadLine();
                    if (Type != "clair" && Type != "chiffre")
                    {
                        Console.WriteLine("Répondez par chiffre ou clair");
                    }
                } while (Type != "clair" && Type != "chiffre");
                do
                {
                    Console.WriteLine("Quel est le nom du fichier ? ex : Phatt "); // choisissez juste le nom de l'ile. Pas besoin de mettre le .clair.txt ou .chiffre.txt il sera mit automatiquement
                    Fichier = Console.ReadLine();
                    if (File.Exists("../../../" + Fichier + "." + Type + ".txt"))
                    {
                        verif = true;
                        
                    }else{
                        verif = false;
                        Console.WriteLine("Votre fichier n'existe pas ou il est mal écrit veuillez verifier les majuscule");
                    }
                } while (verif != true);
                DecrypterCrypter.SiChiffreOuChiffre(Type, Fichier);
                
                do
                {
                    Console.WriteLine("Voulez vous donnez un autre fichier ? o / n");
                    Continuer = Convert.ToChar(Console.ReadLine());
                    if (Continuer != 'n' && Continuer != 'o')
                    {
                        Console.WriteLine("Répondez par 'o' ou 'n' ");
                    }
                } while (Continuer != 'n' && Continuer != 'o');
            } while (Continuer == 'o');
        }
    }
}
