﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    public class île 
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
                    
                    for (int i = 0; i <= 9; i=i+1)
                    {
                        Unit = str.Substring(i,1);
                        U = new Unité(Unit, i, y);
                        Console.WriteLine("Unité = {0}, X = {1}, Y = {2}",Unit, i, y);
                        unité.Add(U);
                    }
                    y = y + 1;
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

        public  void Affiche()
        {
            // Parcours de la liste camions élément par élément
            foreach (Unité U in unité)
            {
                // Appel de la méthode Affiche de la classe Camion
                U.Affiche();
            }

        }
    }
}
