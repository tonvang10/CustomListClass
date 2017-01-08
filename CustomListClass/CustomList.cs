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
            capacity = 50;
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
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
            temp[contents.Count()] = item;
            contents = temp;
            count++;
            capacity--;
        }
        public void Remove(T item)
        {
            bool remove = true;
            T[] temp = new T[contents.Count() - 1];
            for (int i = 0; i <= temp.Count(); i++)
            {
                if (remove)
                {
                    if (contents[i].Equals(item))
                    {
                        remove = false;
                    }
                    else
                    {
                        temp[i] = contents[i];
                    }
                }
                else
                {
                    temp[i - 1] = contents[i];
                }
            }
            contents = temp;
            count--;
            capacity++;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (T items in contents)
            {
                builder.Append(items).Append("");
            }
            string result = builder.ToString();
            Console.WriteLine(result);
            return result;
        }
        public static CustomList<T> operator +(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> AddArrayList = new CustomList<T>();
            foreach (T item in customList1)
            {
                AddArrayList.Add(item);
            }
            foreach (T item in customList2)
            {
                AddArrayList.Add(item);
            }
            return AddArrayList;
        }
        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            for (int i = 0; i < customList1.Count; i++)
            {
                for (int j = 0; j < customList2.Count; j++)
                {
                    if (customList1.contents[i].Equals(customList2.contents[j]))
                    {
                        customList1.Remove(customList2.contents[j]);
                    }
                }
            }
            return customList1;
        }
        public void Zipper(CustomList<T> customList1, CustomList<T> customList2)
        {
            if (customList1.contents.Count() >= customList2.contents.Count())
            {
                for (int i = 0; i < customList1.contents.Count(); i++)
                {
                    Console.WriteLine(customList1.contents[i] + "" + customList2.contents[i]);
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < contents.Count(); i++)
            {
                yield return contents[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

