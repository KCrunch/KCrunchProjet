using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject
{
    public class île 
    {
        #region Attributs
        private List<Unité> unités;
        #endregion

        #region Constructeurs
        public île(string cheminAccesFichier) 
        {
            int y = 0;
            // instanciations de l'attribut unité
            // Attention ! La lecture dans le fichier peut échouer
            // Il faut gérer les erreurs -> structure try...catch
            try
            {

                unités = new List<Unité>();

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
                        U = new Unité(Convert.ToChar(Unit), i, y);
                        unités.Add(U);
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
        #endregion

        #region Méthodes
        public void Affiche()
        {
            // Parcours de la liste Unités élément par élément
            foreach (Unité U in unités)
            {
                // Appel de la méthode Affiche de la classe Unité
                U.Affiche();
            }

        }
        public void Parcelle()
        {
            int maxi = 0;
            int nom;
            foreach (Unité U in unités)
            {
                if (U.Type =="Parcelle")
                {
                    nom = U.NomU1;
                    maxi = maxi + nom;
                    if (nom>maxi);
                }
            }
        }
        #endregion
    }
}
