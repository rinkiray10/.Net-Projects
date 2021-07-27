using System;
using System.Collections.Generic;
using System.Text;

namespace SecondApplication
{
    interface INormalCal
    {
        //Public and Abstract
        int Add(int x, int y);
        int Sub(int x, int y);
    }
    class Calculator: INormalCal,ISciCal
    {
        int INormalCal.Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x,int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(4, 7));
            Console.WriteLine("Subtraction of Normal Calculator:{0}", ncal.Sub(40, 7));
            ISciCal scical = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", scical.Add(4, 7));
            Console.WriteLine("Multiplication of Normal Calculator:{0}", scical.Mul(4, 8));
        }
    }
}
