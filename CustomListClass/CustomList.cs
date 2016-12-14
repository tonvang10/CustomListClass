using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class CustomList<T> : IEnumerable
    {
        string animal;
        string noise;
        T value;

        public CustomList(T itemToDisplay)
        {
            value = itemToDisplay;
        }

        public CustomList()
        {
        }

        public void Display()
        {
            Console.WriteLine(value);
        }
        public int Capacity
        {
            set
            {

            }
        }
        public int Count { get; set; }
        public string Animal
        {
            set
            {
                animal = value;
            }
        }
        public string Noise
        {
            set
            {
                noise = value;
            }
        }
        public void Add(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(i);
            }
        }
        //public void Insert(int index, T item)
        //{

        //}
        //public bool Remove(T item)
        //{

        //}
        //public static CustomList<T> operator -(CustomList<T> animals, CustomList<T> noises)
        //{

        //}
        //public static CustomList<T> operator +(CustomList<T> animals, CustomList<T> noises)
        //{

        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
