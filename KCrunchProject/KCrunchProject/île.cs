using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    class île 
    {
        private List<Unité> unité;

        public île(string cheminAccesFichier) 
        {
            int y = 0;
            // instanciations de l'attribut unité
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {

                unité = new List<Unité>();

                // Ici, instructions pouvant échouer
                StreamReader sr = new StreamReader(cheminAccesFichier);
                string str;
                string Unit;
                Unité U;

                while ((str = sr.ReadLine()) != null)
                {
                    y = y + 1;
                    for (int i = 0; i < 9; i=i+1)
                    {
                        Unit = str.Substring(i,1);
                        Console.WriteLine(" " + Unit);
                        U = new Unité(Unit, i, y);
                        unité.Add(U);
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

        private void Afficher()
        {
            int rang = 1;
            // Parcours de la liste camions élément par élément
            foreach (Unité U in unité)
            {
                Console.Write("{0} : ", rang);
                // Appel de la méthode Affiche de la classe Camion
                U.Afficher();
                rang++;
            }
            Console.WriteLine("Total : {0} camions", unité.Count);
        }
    }
}
