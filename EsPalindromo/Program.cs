using EsPalindromo.DAL;
using System;

namespace EsPalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una palabra para determinar si es palindromo o no:");
            string palabra = Console.ReadLine();

            if (DalPalindromo.Palindromo(palabra))
                Console.WriteLine("es palindromo");
            else
                Console.WriteLine("no es palindromo");

            Console.ReadKey();
        }
    }
}
