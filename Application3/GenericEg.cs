using System;
using System.Collections.Generic;
using System.Text;

namespace Application3
{
    class Person
    {
        int id;
        string name;
        string city;
        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
        class GenericEg
        {
            static void ListEg()
            {
                //typesafe
                List<string> fruits = new List<string>();
                fruits.Add("Apple");
                fruits.Add("Mango");
                fruits.Add("Orange");

                fruits.Insert(1, "Pineapple");
                fruits.RemoveAt(3);
                //fruits.Add(19);//Type unsafe


                List<string> Vegetables = new List<string>();

                Vegetables.Add("Potato");
                Vegetables.Add("Carrot");

                foreach (var list in fruits)
                {
                    Console.WriteLine("Fuits: {0} ", list);
                }
                foreach (var list in Vegetables)
                {
                    Console.WriteLine("Vegetables: {0} ", list);
                }
            }

                //Key Value Pair

                static void DictionaryEg()
                {
                    Dictionary<int, string> dt = new Dictionary<int, string>();
                    dt.Add(1, "abc");
                    dt.Add(2, "xyz");
                    dt.Add(3, "ffd");

                    foreach (KeyValuePair<int, string> kp in dt)
                    {
                        Console.WriteLine(kp.Key + "" + kp.Value);
                    }
                }

                static void StackEg()
                {
                    //Push,Pop,peek,contains,clear,methods
                    Stack<int> st = new Stack<int>();
                    st.Push(30);
                    st.Push(40);
                    st.Push(10);
                    st.Push(50);

                    foreach (var stack in st)
                    {
                        Console.WriteLine(stack);
                    }
                    st.Pop();
                    Console.WriteLine("After 1 pop");
                    foreach (var stack in st)
                    {
                        Console.WriteLine(stack);
                    }
                    Console.WriteLine("Peek:{0}", st.Peek());
                }
            static void SortedList()
            {
                SortedList<int, string> numberNames = new SortedList<int, string>();
                numberNames.Add(3, "Three");
                numberNames.Add(1, "One");
                numberNames.Add(2, "Two");
                numberNames.Add(5, "Five");
                numberNames.Add(4, "Four");
            }

            static void QueueEg()
            {
                //Push,Pop,peek,contains,clear,methods
                Queue<int> callerids = new Queue<int>();
                callerids.Enqueue(1);
                callerids.Enqueue(2);
                callerids.Enqueue(3);
                callerids.Enqueue(4);

                foreach (var id in callerids)
                {
                    Console.WriteLine(id);
                }
                
            }
            static void Main()
            {
                ListEg();
                Console.WriteLine("Person details");
                Console.WriteLine("-------------");
                List<Person> person = new List<Person>();
                person.Add(new Person(1, "abc", "Pune"));
                person.Add(new Person(1, "abc", "Pune"));
                person.Add(new Person(1, "abc", "Pune"));

                foreach (Person p in person)
                {
                    Console.WriteLine("ID:{0} || name:{1} || city:{2}", p.id, p.name, p.city);
                }
                Console.WriteLine("-------------");
                DictionaryEg();
                Console.WriteLine("-------------");
                StackEg();
                SortedList();
                QueueEg();
            }
        }
    }
}
