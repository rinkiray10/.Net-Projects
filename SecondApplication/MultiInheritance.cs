using System;
using System.Collections.Generic;
using System.Text;

namespace SecondApplication
{
    enum Feedback
    {
        Poor,Fair,Good,Excellent
    };

    //Base Class or parent class

    class Department
    {
        //Protected is used within the classs and derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }

        protected string city { get; set; }

        internal Department(int Did,string Dname,string city)
        {
            Console.WriteLine("Department constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.city = city;
        }
        protected internal void DisplayDepartmentInfo()
        {
            //Console.WriteLine("City is :{0}", city);
            Console.WriteLine("Did:{0},Dname:{1}", Did, Dname);
        }
        ~Department()
        {
            Console.WriteLine("Department Deallocated");
        }
    }

    //Single Inheritance
    //Child or derived class
    class Employee : Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal String name { get; set; }
        internal string city = "Pune";

        internal Employee(int Eid, string name, int Did, String Dname,string city) : base(Did, Dname,city)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.name = name;

        }
        internal void DisplayEmployeeInfo()
        {
            DisplayDepartmentInfo();
            Console.WriteLine("Department City is :{0}", base.city);
            Console.WriteLine("Eid:{0} || Ename:{1}|| Feedback:{3}", Eid, name, (int)Feedback.Excellent);
            Console.WriteLine("Employee City is :{0}", city);
        }
        ~Employee()
        {
            Console.WriteLine("Employee Deallocated");
        }
    }

    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid,string name,int Did,String Dname,string city,int hoursofwork,int salary ):base(Eid,name,Did,Dname,city)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }

        internal int MonthlySalary()
        {
            int payment = hoursofwork * 30 * salary;
            return payment;
        }
        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Deallocated");
        }
    }
    class MultiInheritance
    {
        static void Main()
        {
            //Single Inheritance
           /* Employee employee = new Employee(1000, "Sai",103,"HR","Kolkata");
            employee.DisplayEmployeeInfo();*/
            //employee.DisplayDepartmentinfo();

            //Multilevel Inheritance
            PartTimeEmployee pt = new PartTimeEmployee(1000, "Sai", 101, "HR", "Kolkata", 48, 039);
            pt.DisplayDepartmentInfo();
            Console.WriteLine("Monthly Salary: {0}", pt.MonthlySalary());

            GC.Collect();

        }
    }
}
