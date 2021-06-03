using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KCrunchProject 
{
    class Parcelle : île
    {
        private string NomP;

        private int CP;

        private int TailleP; 
        
        public Parcelle(string np)
        {
            NomP = np;
        }
    }
}
