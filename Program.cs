using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Program
    {
        class Fairy
        {

        }

        class Corgi
        {
            public string name;
            public static bool winner = true; // class variable
            private int width, height, length;
            private Fairy rider;

            public string Borf()
            {
                return name + ": Bark!";
            }
        }
        static void Main(string[] args)
        {
            Corgi clara = new Corgi();
            Corgi basil = new Corgi();

            clara.name = "clara";
            basil.name = "basil";

            Console.WriteLine(clara.Borf());
            Console.WriteLine(basil.Borf());
        }
    }
}
