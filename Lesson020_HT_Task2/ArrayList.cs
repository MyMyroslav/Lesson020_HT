using System;
namespace Lesson020_HT_Task2
{
    public class ArrayList2<T>
    {
        public T[] array = new T[10];
        public T[] arr = new T[10];
        int i = 0;
        int j = 0;
        public ArrayList2()
        {
        }
        public void Add(T el)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("Max Length");
                return;
            }
            array[i] = el;
            Console.WriteLine(array[i]);
            i++;
        }
        public void Clear()
        {
            array = new T[array.Length];
        }
        public bool Contains(T el)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(el))
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(T el)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(el))
                {
                    T temp = array[i];
                    array[i] = default;
                }
            }
        }
    }
}

