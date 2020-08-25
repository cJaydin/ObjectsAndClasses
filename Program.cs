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

            public Corgi()
            {
                name = "Floof";
                width = 40;
                length = 120;
                height = 70;
                temperament = "Derpy";
            }
            public Corgi(string name, int width, int height, int length, string temperament)
            {
                this.name = name;
                this.width = width;
                this.height = height;
                this.length = length;
                this.temperament = temperament;
            }

            public Corgi(string name, int width, int height, int length)
            {
                this.name = name;
                this.width = width;
                this.height = height;
                this.length = length;
                this.temperament = "Playful";
            }


            public Corgi(string name)
            {
                this.name = name;
                width = 50;
                height = 80;
                length = 100;
                temperament = "Chonker";
            }

            public string CorgiString()
            {
                return name + " is a " + temperament + " Corgi. They thiccccccc with 27 c's because " + height + " x " + width + " x " + length;
            }

            private string name;
            private int width, height, length;
            private string temperament;

            public string Name { get => name; }
            public int Width { get => width; }
            public int Height { get => height; }
            public int Length { get => length; }
            public string Temperament { get => temperament; }

            public string Borf()
            {
                return Name + ": BORK!";
            }
        }

        static void Main(string[] args)
        {
            Corgi[] army = new Corgi[4];
            string[] names = { "Clara", "Basil", "River", "Melody", "Rory" };
            string[] temps = { "Angry", "Reactive", "Sleepy", "Chomping", "Cuddly" };

            Random r = new Random();

            army[0] = new Corgi(names[r.Next(0, names.Length)]);
            army[1] = new Corgi(names[r.Next(0, names.Length)], r.Next(10, 100), r.Next(10, 100), r.Next(10, 100));
            army[2] = new Corgi(names[r.Next(0, names.Length)], r.Next(10, 100), r.Next(10, 100), r.Next(10, 100), temps[r.Next(0, temps.Length)]);
            army[3] = new Corgi();

            for (int i = 0; i < army.Length; i++)
            {
                Console.WriteLine(army[i].CorgiString());
            }

        }
    }
}
