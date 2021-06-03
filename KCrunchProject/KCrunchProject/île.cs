﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    class île
    {
        private List<Parcelle> code;

        private string chiffreP;

        public île(string cheminAccesFichier)
        {
            // instanciations de l'attribut camions
            code = new List<Parcelle>();
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {
                // Ici, instructions pouvant échouer
                StreamReader sr = new StreamReader(cheminAccesFichier);
                string str;
                Parcelle P;
                while ((str = sr.ReadLine()) != null)
                {
                    P = new Parcelle(str);
                    code.Add(P);
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
