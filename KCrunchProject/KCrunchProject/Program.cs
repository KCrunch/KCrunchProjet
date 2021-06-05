using System;
using System.Collections.Generic;
using System.IO;


namespace KCrunchProject
{
    class Program
    {

        static void Main(string[] args)
        {
            
            île Phatt = new île("../../../Phatt.clair.txt");
            Phatt.AfficheUnité();
            Console.WriteLine("\n");
            Phatt.AfficheParcelle();
            Phatt.tailleParcelles('a');
            Phatt.tailleMoyenneParcelles();
            Phatt.AfficheIle();





        }
    }
}
