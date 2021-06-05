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


            /*
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("../../../Phatt.clair.txt");
                //Read the first line of text
                //line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                        
                }
                //close the file
                sr.Close();
                Console.ReadLine();

        }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }*/



        }
    }
}
