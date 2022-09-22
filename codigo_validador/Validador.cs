using System;
using System.Collections.Generic;
using System.Text;

namespace codigo_validador
{
    class Validador
    {
        public int codigo;
        public int d5;
        public int verif;
        public bool Validar(){
            int d = 0;
            for (int n = 0; n < 4; n++)
            {
                d = codigo / ((int)Math.Pow(10, 4 - n)) % 10;
                verif = verif + d * (5 - n);
            }
            d = codigo % 10;
            verif = verif % 10;
            d5 = d;
            return d5 == verif;
        }

    }
}
