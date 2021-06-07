using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("\n //////////////////////  Début Ile Phatt  ////////////////////// \n");
            Ile PhattChiffre = new Ile("../../../Phatt.chiffre.txt");
            Ile PhattClair = new Ile("../../../Phatt.clair.txt");

            Console.WriteLine("\n //////////////////////  Cryptage Ile Phatt  ////////////////////// \n");
            DecrypterCrypter.Crypter(PhattClair, "../../../Phatt.chiffre.txt");

            Console.WriteLine("\n ////////////////////  Décryptage Ile Phatt  //////////////////// \n");
            //mettre la commande ici et supprimer le com
            Console.WriteLine("\n");

            Console.WriteLine("\n ////////////////////  Affichage des informations parcelles Ile Phatt  //////////////////// \n");
            Console.WriteLine("\n");
            PhattClair.AfficheParcelle();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage la tailles parcelles Ile Phatt   //////////////////// \n");
            PhattClair.tailleParcelles('s');
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage de la moyenne des parcelles Ile Phatt //////////////////// \n");
            PhattClair.tailleMoyenneParcelles();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage de Ile Phatt  //////////////////// \n");
            PhattClair.AfficheIle();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Fin de Ile Phatt  //////////////////// \n");


            Console.WriteLine("\n //////////////////////  Début Ile Phatt  ////////////////////// \n");
            Ile ScabbClair = new Ile("../../../Scabb.clair.txt");
            Ile ScabbChiffre = new Ile("../../../Scabb.chiffre.txt");

            Console.WriteLine("\n //////////////////////  Cryptage Ile Scabb  ////////////////////// \n");
            DecrypterCrypter.Crypter(ScabbClair, "../../../Scabb.chiffre.txt");

            Console.WriteLine("\n ////////////////////  Décryptage Ile Scabb  //////////////////// \n");
            //mettre la commande ici et supprimer le com
            Console.WriteLine("\n");

            Console.WriteLine("\n ////////////////////  Affichage des informations parcelles Ile Scabb  //////////////////// \n");
            Console.WriteLine("\n");
            ScabbClair.AfficheParcelle();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage la tailles parcelles Ile Scabb   //////////////////// \n");
            ScabbClair.tailleParcelles('a');
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage de la moyenne des parcelles Ile Scabb //////////////////// \n");
            ScabbClair.tailleMoyenneParcelles();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Affichage de Ile Scabb  //////////////////// \n");
            ScabbClair.AfficheIle();
            Console.WriteLine();

            Console.WriteLine("\n ////////////////////  Fin de Ile Scabb  //////////////////// \n");

            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");
            Console.WriteLine("\n");
            PhattClair.AfficheParcelle();
            Console.WriteLine();
            PhattClair.tailleParcelles('s');
            Console.WriteLine();
            PhattClair.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            PhattClair.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

            Console.WriteLine("\n");
            ScabbClair.AfficheParcelle();
            Console.WriteLine();
            ScabbClair.tailleParcelles('s');
            Console.WriteLine();
            ScabbClair.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            ScabbClair.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");*/

            Ile PhattChiffre = new Ile("../../../Phatt.chiffre.txt");
            DecrypterCrypter.Decrypter(PhattChiffre,"../../../Phatt.claire.txt");

            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");
            Console.WriteLine("\n");
            PhattChiffre.AfficheParcelle();
            Console.WriteLine();
            PhattChiffre.tailleParcelles('s');
            Console.WriteLine();
            PhattChiffre.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            PhattChiffre.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

           /* Ile ScabbChiffre = new Ile("../../../Scabb.chiffre.txt");

            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");
            Console.WriteLine("\n");
            ScabbChiffre.AfficheParcelle();
            Console.WriteLine();
            ScabbChiffre.tailleParcelles('s');
            Console.WriteLine();
            ScabbChiffre.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            ScabbChiffre.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");*/
            /*
            Console.WriteLine("\n");
            ScabbChiffre.AfficheParcelle();
            Console.WriteLine();
            ScabbChiffre.tailleParcelles('s');
            Console.WriteLine();
            ScabbChiffre.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            ScabbChiffre.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");*/

        }
    }
}
