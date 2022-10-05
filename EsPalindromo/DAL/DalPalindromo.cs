using System;
using System.Collections.Generic;
using System.Text;

namespace EsPalindromo.DAL
{
    class DalPalindromo
    {
        public static bool Palindromo(string dialogo)
        {
            int longitud = dialogo.Length;
            int posicion;

            if (longitud % 2 == 0)
                posicion = longitud / 2 + 1;
            else
                posicion = (longitud + 1) / 2;

            for (int i = 0; i < posicion; i++)
            {
                if (dialogo[i] != dialogo[longitud - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
