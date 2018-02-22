using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios {
    class Program {
        static void Main(string[] args) {
            string s = "Oh look it a string \u0CA5 \u0C69 \u0CA5";
            string v = @"Oh look it an ugly string \u0CA5 \u0C69 \u0CA5";
            string c = "a" + 2;
            string d = $"{5} mais {5} e igual a {5 + 5}";
            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
