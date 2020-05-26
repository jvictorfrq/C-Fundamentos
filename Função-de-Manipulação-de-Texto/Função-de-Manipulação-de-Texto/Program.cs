using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Função_de_Manipulação_de_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoAntigo = "Esse é um texto ANTIGO";
            string textoNovo = textoAntigo.Replace("ANTIGO", "NOVO");
            Console.WriteLine(textoNovo);
            Console.ReadKey();

            string textAntigo = "0123456";
            string textNovo = textAntigo.Substring(1, 4);
            Console.WriteLine(textNovo);
            Console.ReadKey();

            string texAntigo = "ESTOU APRENDENDO C#";
            string texNovo = texAntigo.ToLower().Replace("maiúsculas", "minusculas");
            Console.WriteLine(texNovo);
            Console.ReadKey();
        }
    }
}
