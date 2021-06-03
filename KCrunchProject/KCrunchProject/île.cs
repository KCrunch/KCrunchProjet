using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    class île
    {
        private List<Unité> code;

        private string chiffreP;

        public île(string cheminAccesFichier)
        {
            // instanciations de l'attribut unité
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {
                // Ici, instructions pouvant échouer
                StreamReader sr = new StreamReader(cheminAccesFichier);
                string str;
                Unité U;   azerty
                string Unit;
                while ((str = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Unit = str.Substring(i, i + 1);
                        U = new Unité(Unit,);
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
