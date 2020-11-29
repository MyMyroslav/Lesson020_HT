using System;

namespace Lesson020_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList2<int> arrayList2 = new ArrayList2<int>();
            int[] arr = new int[10];
            arrayList2.Add(1);
            arrayList2.Add(15);
            arrayList2.Add(2);
            arrayList2.Add(5);
            arrayList2.Add(8);
            arrayList2.Add(7);
            arrayList2.Add(25);
            arrayList2.Add(123);
            arrayList2.Add(55);
            arrayList2.Add(81);
            Console.WriteLine(arrayList2.Contains(15));
            Console.WriteLine(arrayList2.Contains(3));
            Console.WriteLine(" ");
            arrayList2.Remove(15);
            Console.WriteLine(arrayList2.Contains(15));
        }
    }
}