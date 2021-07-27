using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class CollectionDemo
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Capacity{0}", al.Capacity);
            al.Add(10);
            al.Add("Anu");
            al.Add(100.0f);
            al.Add('a');
            al.Add(20);

            foreach(var arrayList in al)
            {
                Console.WriteLine(arrayList);
            }
            Console.WriteLine("Count is {0}", al.Count);
            Console.WriteLine("indexof is {0}", al.IndexOf(20));
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Remove("Anu");
            al.Remove(20);
            foreach (var arrayList in al)
            {
                Console.WriteLine(arrayList);
            }
            Console.WriteLine("Capacity {0}", al.Capacity);
        }

        //Combination of key and value
        static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("N", "Networks");
            ht.Add("O", "Operating System");
            ht.Add("J", "Java");
            ht.Add("U", "Unix");
            Console.WriteLine(ht.Contains("O"));
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ": " + d.Value);
            }
        }

    }
}
