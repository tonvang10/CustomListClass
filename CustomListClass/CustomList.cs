using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        T[] contents;
        T value;
        int capacity = 1;
        int count;
        public CustomList()
        {

        }
        public CustomList(T item)
        {
            contents = new T[Capacity];
            value = item;
        }
        //public CustomList(T item)
        //{
        //    value = item;
        //}
        public int Capacity
        {
            get
            {
                return capacity;
            }
        } 
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Display()
        {
            Console.WriteLine();
        }
        public void Add(T item)
        {
            T[] temp = new T[Capacity];
            for (int i = 0; i < Capacity; i++)
            {                
                contents[i] = temp[i];                
                count++;
            }  
        }
        public bool Remove(T item)
        {
            T[] ex = new T[1];
            for (int i = 1; i > 0; i--)
            {

            }
            return true;
        }
        //public override string ToString()
        //{
        //}
        //public void Insert(int index, T item)
        //{

        //}
        //public static CustomList<T> operator -(CustomList<T> animals, CustomList<T> noises)
        //{

        //}
        //public static CustomList<T> operator +(CustomList<T> animals, CustomList<T> noises)
        //{

        //}
        //public IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return contents;
        }
    }
}

