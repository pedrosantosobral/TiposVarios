using System;

namespace TiposVarios
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string n = "Isto é uma string\u00A9";
            string v = @"testedecodigo\u03A9";
            string c = "a" + 2;
            string d = "ABC" + n;
            Console.WriteLine(n);
            Console.WriteLine(v);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
 