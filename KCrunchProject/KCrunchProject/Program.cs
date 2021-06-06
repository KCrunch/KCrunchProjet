using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Ile PhattClair = new Ile("../../../Phatt.clair.txt");
            DecrypterCrypter.Crypter(PhattClair,"../../../Phatt.chiffre.txt");
            
            Ile ScabbClair = new Ile("../../../Scabb.clair.txt");
            DecrypterCrypter.Crypter(ScabbClair, "../../../Scabb.chiffre.txt");

            Ile PhattChiffre = new Ile("../../../Phatt.chiffre.txt");


            Ile ScabbChiffre = new Ile("../../../Scabb.chiffre.txt");


            
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
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

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
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

        }
    }
}
