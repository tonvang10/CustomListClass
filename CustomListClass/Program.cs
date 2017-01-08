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
            Console.WriteLine("A list of animals:");
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Duck");
            animals.Add("Cow");
            animals.Add("Pig");
            animals.Display();
            Console.WriteLine("\nCount: {0}", animals.Count);
            Console.WriteLine("Capacity: {0}\n", animals.Capacity);

            CustomList<string> noises = new CustomList<string>();
            Console.WriteLine("The noises they make:");
            noises.Add("Woof");
            noises.Add("Meow");
            noises.Add("Quack");
            noises.Add("Moo");
            noises.Add("Oink");
            noises.Display();
            Console.WriteLine("\nCount: {0}", noises.Count);
            Console.WriteLine("Capacity: {0}", noises.Capacity);

            Console.WriteLine("\nToString method:");
            animals.ToString();
            noises.ToString();

            Console.WriteLine("\nRemoving a COW from list:");
            animals.Remove("Cow");
            animals.Display();
            Console.WriteLine("\nCount: {0}", animals.Count);
            Console.WriteLine("Capacity: {0}", animals.Capacity);

            Console.WriteLine("\nRemoving MOO:");
            noises.Remove("Moo");
            noises.Display();
            Console.WriteLine("\nCount: {0}", noises.Count);
            Console.WriteLine("Capacity: {0}", noises.Capacity);

            Console.WriteLine("\nPlus operator:");
            CustomList<string> plusOperator = new CustomList<string>();
            plusOperator = animals + noises;
            plusOperator.Display();

            Console.WriteLine("\nMinus operator:");
            CustomList<string> minusOperator = new CustomList<string>();
            minusOperator = (animals - noises);
            minusOperator.Display();

            Console.WriteLine("\nZip both lists:");
            CustomList<string> zip = new CustomList<string>();
            zip.Zipper(animals, noises);
            zip.Display();

            Console.ReadKey();
        }
    }
}


