using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    class île
    {


        public île(string cheminAccesFichier)
        {
            int y = 0;
            // instanciations de l'attribut unité
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {
                // Ici, instructions pouvant échouer
                StreamReader sr = new StreamReader(cheminAccesFichier);
                string str;
                Unité U;
                string Unit;
                while ((str = sr.ReadLine()) != null)
                {
                    y = y + 1;
                    for (int i = 0; i < 9; i=i+1)
                    {
                        Unit = str.Substring(i,1);
                        Console.WriteLine(" " + Unit);
                        U = new Unité(Unit, i, y);

                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                // Exécuté uniquement si erreur dans le bloc try
                // e est alimentée par Windows avec un message d'erreur
                Console.WriteLine(e.Message);
            }


        }
    }
}
