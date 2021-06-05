using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Ile Phatt = new Ile("../../../Phatt.clair.txt");
            DécyrpterCrypter.Crypter(Phatt,"../../../Phatt.chiffre.txt");
            
            Ile Scabb = new Ile("../../../Scabb.clair.txt");
            DécyrpterCrypter.Crypter(Scabb, "../../../Scabb.chiffre.txt");

            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");
            Console.WriteLine("\n");
            Phatt.AfficheParcelle();
            Console.WriteLine();
            Phatt.tailleParcelles('a');
            Console.WriteLine();
            Phatt.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Phatt.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

            Console.WriteLine("\n");
            Scabb.AfficheParcelle();
            Console.WriteLine();
            Scabb.tailleParcelles('a');
            Console.WriteLine();
            Scabb.tailleMoyenneParcelles();
            Console.WriteLine();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Scabb.AfficheIle();
            Console.WriteLine("\n --------------------------------------------------------------------------------- \n");
            Console.WriteLine("\n ///////////////////////////////////////////////////////////////////////////////// \n");

        }
    }
}
