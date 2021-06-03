using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Unité
    {
        private int CodeU;

        private int CoordonnéeU;

        private string NomU;

        
        public Unité(string nu,int cu)
        {
            NomU = nu;

            CoordonnéeU = cu;

        }
        public Unité(string code)
        {
            int[] tab = code.Split(':');

            CodeU = tab[0];

        }
    }
}
