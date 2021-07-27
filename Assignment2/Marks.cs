using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    abstract class Marks
    {
        abstract internal double getpercentage();
        class A : Marks
        {
            internal float sub1;
            internal float sub2;
            internal float sub3;

            public A(float s1, float s2, float s3)
            {
                this.sub1 = s1;
                this.sub2 = s2;
                this.sub3 = s3;
            }
            internal override double getpercentage()
            {
                return (sub1 + sub2 + sub3) / 3;
            }
        }
        class B : Marks
        {
            internal float sub1;
            internal float sub2;
            internal float sub3;
            internal float sub4;

            public B(float s1, float s2, float s3, float s4)
            {
                this.sub1 = s1;
                this.sub2 = s2;
                this.sub3 = s3;
                this.sub4 = s4;
            }
            internal override double getpercentage()
            {
                return (sub1 + sub2 + sub3 + sub4) / 4;
            }
        }
        public static void Main()
        {
            A a = new A(56, 78, 67);
            B b = new B(76, 45, 88,90);

            Console.WriteLine("Percentage of student A = "+ a.getpercentage());
            Console.WriteLine("Percentage of student B = "+ b.getpercentage());
        }
    }
}

