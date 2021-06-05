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
            DécyrpterCrypter.Crypter(Phatt);
            Console.WriteLine();
            Phatt.AfficheUnité();
            Console.WriteLine();
            Phatt.AfficheParcelle();
            Console.WriteLine();
            Phatt.tailleParcelles('a');
            Console.WriteLine();
            Phatt.tailleMoyenneParcelles();
            Console.WriteLine();
            Phatt.AfficheIle();
        }
    }
}
