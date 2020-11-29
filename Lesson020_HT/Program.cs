using System;
using System.Collections;

namespace Lesson020_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("Age");
            for(int i =0; i < 2; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
