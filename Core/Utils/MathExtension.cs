using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utils
{
    public static class MathExtensions
    {
        public static bool EsPotencia2(int numero)
        {
            return System.Math.Log(numero, 2) % 1 == 0;
        }

        public static bool EsPotenciaN(int numero, int esPotenciaDe)
        {
            return System.Math.Log(numero, esPotenciaDe) % 1 == 0;
        }
    }
}
