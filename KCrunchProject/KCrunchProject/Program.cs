using System;
using System.IO;


namespace KCrunchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            île U = new île("../../../Phatt.clair.txt");

            string line,test;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("../../../Phatt.clair.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    test = line.Substring(0, 4);
                    Console.WriteLine(" "+test);
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
            }

        }
    }
}
