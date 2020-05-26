using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenação Símples
            string msgVariavel1 = "Olá, Meu nome é ";
            msgVariavel1 += "João Victor Furquim";
            Console.WriteLine(msgVariavel1);
            Console.ReadLine();
            Console.Clear();

            //Concatenação Info-User
            Console.WriteLine("Escreva seu nome !");
            string nome = Console.ReadLine();
            string msgVariavel = "Olá, Meu nome é ";
            msgVariavel += nome;

            Console.WriteLine(msgVariavel);
            Console.ReadLine();

        }
    }
}
