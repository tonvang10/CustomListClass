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
        int capacity;
        int count;

        public CustomList()
        {
            contents = new T[0];
            capacity = count;
        }
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
            foreach (T items in contents)
            {
                Console.WriteLine(items);
            }
        }
        public void Add(T item)
        {
            T[] temp = new T[contents.Count() + 1];
            for (int i = 0; i < contents.Count(); i++)
            {
                temp[i] = contents[i];
            }
            temp[Count] = item;
            contents = temp;
            count++;
        }
        public bool Remove(T item)
        {
            T[] temp = new T[contents.Count()];
            for (int i = temp.Count() - 1; i >= 0; i--)
            {
                temp[i] = contents[i];
            }
            //temp[count] = item;
            contents = temp;
            count--;
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

