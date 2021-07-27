using System;
using System.Collections.Generic;
using System.Text;

/*Write a Program that contains "Car" as abstract class and an instance variable regno,one concreate method openTank(),
 two abstract methods steering(int direction,int angle), braking(int force) and its implementation sub classes Tata, Mahindra which overrides
above methods. Implement the above scenario and use all access specifiers*/

namespace Assignment2
{
    abstract class Car
    {
        internal int regno;
        
        internal void openTank()
        {
            Console.WriteLine("Open Tank");
        }
        internal abstract void Steering(int direction, int angle);
        internal abstract void Braking(int force);

        internal class Tata : Car
        {  
            internal override void Steering(int direction, int angle)
            {
                Console.WriteLine("Tata - Direction:{0} || Angle:{1}", direction, angle);
            }
            internal override void Braking(int force)
            {
                Console.WriteLine("Tata - Force:{0}", force);
            }
        }
        internal class Mahindra : Car
        {   
            internal override void Steering(int direction, int angle)
            {
                Console.WriteLine("Mahindra - Direction:{0} || Angle:{1}", direction, angle);
            }
            internal override void Braking(int force)
            {
                Console.WriteLine("Mahindra - Force:{0}", force);
            }
        }

        static void Main()
        {
            Car c = new Tata();
            c.openTank();

            Tata t = new Tata();
            t.Steering(34, 67);
            t.Braking(850);

        }
    }
}
