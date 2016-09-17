using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(f, false);
            sw.WriteLine("HOLA MUNDO");
            sw.WriteLine("hi world");
            Console.WriteLine("HOLA ELIZA ELIZABETH");
        }
    }
}
