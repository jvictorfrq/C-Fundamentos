using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLógicos
{
    class Program
    {     
        static int Main(string[] args)
        {
            //Capitulo 4 - Operadores

            //ADIÇÃO
            Console.WriteLine("---------- OPERADORES ------------");
            int a, b, c, d;

            Console.WriteLine("33 + 56 + 58");
            a = 33;
            b = 56;
            c = 58;
            d = a + b + c;

            Console.WriteLine("Resultado é = " + d );
            Console.ReadLine();


            //SUBTRAÇÃO
            int aa, ba, ca, da;

            Console.WriteLine("100 - 435 - 98");
            aa = 100;
            ba = 435;
            ca = 98;
            da = aa - ba - ca;

            Console.WriteLine("Resultado é = " + da);
            Console.ReadLine();

            //MULTIPLICAÇÃO
            int ab, bb, cb, db;

            Console.WriteLine("49 x 29 x 23");

            ab = 49;
            bb = 29;
            cb = 23;
            db = ab * bb * cb;

            Console.WriteLine("Resultado é = " + db);
            Console.ReadLine();

            //DIVISÃO
            int ac, bc, cc, dc, ll;

            Console.WriteLine("98 / 50 / 5");
            ac = 98;
            bc = 50;
            cc = 5;
            dc = ac / bc / cc;

            Console.WriteLine("Resultado é = " + dc);
            Console.ReadLine();

            //resto/modulo

            ll = ac / bc;
            Console.WriteLine("Resto = " + ll);
            Console.ReadLine();


            //LÓGICOS ---------------------------------------------------

            Console.WriteLine("------- Testando os Operadores Lógicos --------");
            Console.WriteLine("1 > 3 E 3 < 10");
            int num1 = 1, num2 = 3;
            bool PrimeiroTeste = num1 > 3 && num2 < 10;
            Console.WriteLine(PrimeiroTeste);
            //Primeiro teste da falso

            Console.WriteLine("1 > 2 OU 3 < 1");
            int num11 = 1, num22 = 3;
            bool SegunteTeste = num11 > 2 || num22 < 5;
            Console.WriteLine(SegunteTeste);
            //Segundo teste da true

            Console.ReadLine();

            //Atribuidores---------------------
            // "=" (Atribuição Simples)
            // "+=" (Atribuição Aditiva)
            // "-=" (Atribuição Subtrativa)
            // "*=" (Atribuição Multiplicativa)
            // "/=" (Atribuição Divisi)
            // "%=" (Atribuição Modular)
            // "++" (Adição de 1 unidade)
            // "--" (Subtração de 1 unidade)
            //----------------------------------

            //SIMPLES
            string simp = "Simples";

            //ADTIVA
            int lll = 3; lll += 1; //r = 4

            //Subtrativa
            int llll = 3; llll -= 1; //r - 2

            //Multiplicativa 
            int lllll = 3; lllll *= 4; //r = 12

            //divisiva
            int  llllll = 8; llllll /= 2; //r =4

            //Adição de uma unidade
            int lls = 11; lls ++ 3; //r = 12

            //Subtração de uma unidade
            int lsl = 11; lsl--3; //r = 8



        }
      
    }
}
