using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class ArrayEg
    {
        //by default access specifier for member and member function is private
        string[] fruits = new string[3];
        int[] mark = { 87, 57, 98 };

        internal void Getfruits()
        {
            for(int i=0;i<fruits.Length;i++)
            {
                Console.WriteLine("Enter the Fruitname");
                fruits[i] = Console.ReadLine();
            }

            //foreach(string fu in fruits)
            //implicity type variable
            foreach(var fu in fruits)
            {
                Console.WriteLine("Fruitname:{0}", fu);
            }
        }

    }
}
class StringEg
{
    internal void StringFunctionEg()
    {
        string firstname = "Sai";
        string name = "Rinki Ray";
        Console.WriteLine("TO UPPER :{0}", firstname.ToUpper());
        Console.WriteLine("TO LOWER :{0}", firstname.ToLower());
        Console.WriteLine("Length :{0}", name.Length);
        bool isContains = name.Contains("IN");
        Console.WriteLine("Contains IN :{0}", isContains);
        Console.WriteLine("substring :{0}", name.Substring(3,5));
    }
}

class Array_static
{

    static void Main()
    {
        ArrayEg arrayEg = new ArrayEg();
        arrayEg.GetFruits();

        StringEg stringEg = new StringEg();
        stringEg.StringFunctionEg();
    }
}