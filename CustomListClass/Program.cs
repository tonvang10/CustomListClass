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
            CustomList<string> animals = new CustomList<string>();
            Console.WriteLine("A list of animals and the noise they make.\n");
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Duck");
            animals.Add("Cow");
            animals.Add("Pig");
            animals.Display();
            Console.WriteLine("\nCount: {0}\n", animals.Count);

            CustomList<string> noises = new CustomList<string>();
            noises.Add("Woof");
            noises.Add("Meow");
            noises.Add("Quack");
            noises.Add("Moo");
            noises.Add("Oink");
            noises.Display();
            Console.WriteLine("\nCount: {0}\n", noises.Count);

            noises.Remove("Moo");
            noises.Display();
            Console.WriteLine("\nCount: {0}\n", noises.Count);

            Console.ReadKey();
        }
    }
}


