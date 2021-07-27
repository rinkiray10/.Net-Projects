using System;
using System.Collections.Generic;
using System.Text;

/* Write a Program to create a class named Vehicle having protected instance variables regnNumber,speed,color,ownerName, and a method showData() to show "This is a vehicle class".
 Inherit the Vehicle class into subclass named Bus and Car having individual private instance variables routeNumber in Bus and manufactureName in Car and both of them having ShowData() method showing 
all details of Bus and Car respectively with content of the parent class's showData() method.*/

namespace Assignment2
{
    class Vehicle
    {
        protected int regnNumber { get; set; }
        protected float speed { get; set; }
        protected string color { get; set; }
        protected string ownerName { get; set; }

        internal Vehicle(int regnNumber, float speed, string color, string ownerName)
        {
            this.regnNumber = regnNumber;
            this.speed = speed;
            this.color = color;
            this.ownerName = ownerName;
        }
        protected internal void showVehicleData()
        {
            Console.WriteLine("This is the Vehicle class");
            Console.WriteLine("regnNumber:{0} || speed:{1} || color:{2} || ownerName:{3}", regnNumber, speed, color, ownerName);
        }
        class Bus : Vehicle
        {
            internal int routeNumber { get; set; }
            internal Bus(int regnNumber, float speed, string color, string ownerName, int routeNumber) : base(regnNumber, speed, color, ownerName)
            {
                Console.WriteLine("This is Bus Constructor");
                this.routeNumber = routeNumber;
            }
            internal void showBusData()
            {
                showVehicleData();
                Console.WriteLine("Bus Details");
                Console.WriteLine("routeNumber:{0}", routeNumber);
            }
        }
        class Car : Vehicle
        {
            internal string manufacturerName;
            internal Car(int regnNumber, float speed, string color, string ownerName, string manufacturerName) : base(regnNumber, speed, color, ownerName)
            {
                Console.WriteLine("This is Car Constructor");
                this.manufacturerName = manufacturerName;
            }
            internal void showCarData()
            {
                showVehicleData();
                Console.WriteLine("Car Details");
                Console.WriteLine("ManufacturerName:{0}", manufacturerName);
            }

        }
        static void Main()
        {
            Bus bus = new Bus(1001, 340, "Red", "sdf", 897);
            bus.showBusData();
            Console.WriteLine();
            Car car = new Car(1000, 50, "Blue", "XYZ","abc");
            car.showCarData();
        }
    }
}
