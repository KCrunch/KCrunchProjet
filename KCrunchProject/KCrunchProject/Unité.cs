using System;
using System.Collections.Generic;
using System.Text;

namespace KCrunchProject
{
    class Unité
    {
        private int CodeU;

        private int CoordonnéeU;

        private string NomU = "a";

        
        public Unité(string nu,int cu)
        {
            NomU = nu + 1;

            CoordonnéeU = cu;

        }
        public Unité(string code)
        {
            string[] tab = code.Split(':');

            code = tab [0];

        }
    }
}
