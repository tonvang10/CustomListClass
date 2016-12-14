using CustomListClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A list of animals and the noise they make.");
            CustomList<string> animals = new CustomList<string>();
            animals.Add("Dog ");
            animals.Add("Cat ");
            animals.Add("Duck ");
            animals.Add("Cow ");
            animals.Add("Pig ");
            animals.Add("Bird ");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            CustomList<string> noises = new CustomList<string>();
            noises.Add("Bark");
            noises.Add("Meow");
            noises.Add("Quack");
            noises.Add("Moo");
            noises.Add("Oink");
            noises.Add("Churp");
            foreach (string noise in noises)
            {
                Console.WriteLine(noises);
            }

            Console.ReadKey();
        } 
    }
}

