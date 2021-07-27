using System;
using System.Collections.Generic;
using System.Text;

namespace Application3
{

    //Generic Class
    class Sample<T>
    {
        T name;
        T city;
        internal Sample(T name, T city)
        {
            this.name = name;
            this.city = city;
        }

        //Normal Method
        internal void Add(int x, int y)
        {
            Console.WriteLine("Addition is:{0}", (x + y));
        }
        //Generic Method
        //<T>
        internal void swap<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || Y is {1}", x, y);

        }
    }

    /*Generic Constraint
     where T:struct  //value type
    where T:class //reference type
    where T:new //default parameter constraint
    where T:<interface name>
    */

    class Student<T> where T : struct
    {

    }
    class GenericMethods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu", "Pune");
            sample.swap<int>(6, 8);
            sample.swap<string>("Good", "Morning");

            //Struct Constraint
            //error because student class will accept only struct value(Value type)
            //Student<string> student=new Student<string>();

            Student<int> student1 = new Student<int>();
        }
    }

}
