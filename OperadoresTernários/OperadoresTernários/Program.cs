using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresTernários
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 10; int valor2 = 15;
            bool resultado = valor1 == valor2 ? true : false;
            Console.WriteLine(resultado);
            Console.ReadLine();
            //resultado == (Igual) False

            int valor3 = 5; int valor4 = 10;
            bool resultado2 = valor3 != valor4 ? true : false;
            Console.WriteLine(resultado2);
            Console.ReadLine();
            //reusltado != (Diferente) True

            int valor5 = 35; int valor6 = 40;
            bool resultado3 = valor5 > valor6 ? true : false;
            Console.WriteLine(resultado3);
            Console.ReadLine();
            // resultado > (Maior) False

            int valor7 = 25; int valor8 = 30;
            bool resultado4 = valor7 < valor8 ? true : false;
            Console.WriteLine(resultado4);
            Console.ReadLine();
            // resultado < (Menor) True

        }
    }
}
